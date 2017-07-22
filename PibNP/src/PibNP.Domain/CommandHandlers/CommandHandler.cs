using FluentValidation.Results;
using Pib.NP.Domain.Core.Bus;
using Pib.NP.Domain.Core.Notifications;
using Pib.NP.Domain.Interfaces;
using System;

namespace Pib.NP.Domain.CommandHandlers
{
    public abstract class CommandHandler
    {
        private readonly IUnitOfWork uow;
        private readonly IBus bus;
        private readonly IDomainNotificationHandler<DomainNotification> notification;

        public CommandHandler(IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notification)
        {
            this.uow = uow;
            this.bus = bus;
            this.notification = notification;
        }

        protected void NotificarValidacoes(ValidationResult validationResult)
        {
            foreach (var item in validationResult.Errors)
            {
                Console.WriteLine(item.ErrorMessage);
                this.bus.RaiseEvent(new DomainNotification(item.PropertyName, item.ErrorMessage));
            }
        }

        protected bool Commit()
        {
            //Implementação: Validação de Negocio

            if (this.notification.HasNotifications()) return false;

            var commandResponse = this.uow.Commit();

            if (commandResponse.Success) return true;

            Console.WriteLine("Ocorreu um erro ao salvar no BD.");
            this.bus.RaiseEvent(new DomainNotification("Commit", "Ocorreu um erro ao salvar os dados no Banco."));
            return false;
        }
    }
}
