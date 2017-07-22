using System;
using Pib.NP.Domain.CommandHandlers;
using Pib.NP.Domain.Core.Bus;
using Pib.NP.Domain.Core.Events;
using Pib.NP.Domain.Core.Notifications;
using Pib.NP.Domain.Membro.Events;
using Pib.NP.Domain.Membro.Repository;
using Pib.NP.Domain.Interfaces;


namespace Pib.NP.Domain.Membro.Commands
{
    public class MembroCommandHandler : CommandHandler,
        IHandler<AtualizarMembroCommand>,
        IHandler<DesativarMembroCommand>,
        IHandler<RegistrarMembroCommand>

    {
        private readonly IDomainNotificationHandler<DomainNotification> notification;
        private readonly IMembroRepository membroRepository;
        private readonly IBus bus;

        public MembroCommandHandler(IMembroRepository membroRepository, IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notification)
            : base(uow, bus, notification)
        {
            this.membroRepository = membroRepository;
        }

        public void Handle(RegistrarMembroCommand message)
        {
            var membro = Membro.Factor.Create(
                message.Nome,
                message.Foto,
                message.Email,
                message.Aniversario,
                message.Batismo,
                message.Residencial,
                message.Celular,
                message.Comercial,
                message.Sexo,
                message.EstadoCivil,
                message.Cpf,
                message.Rg);

            if (!membro.EhValido()) NotificarValidacoes(membro.ValidationResult);

            #region Implementação: Validação de negocio

            #endregion

            membroRepository.Add(membro);

            if (Commit())
            {
                //Notificar Processo concluido
                Console.WriteLine("Evento registrado com sucesso");
                this.bus.RaiseEvent(new MembroRegistradoEvent(
                    membro.Id,
                    membro.Nome,
                    membro.Foto,
                    membro.Email,
                    membro.Aniversario,
                    membro.Batismo,
                    membro.Residencial,
                    membro.Celular,
                    membro.Comercial,
                    membro.Sexo,
                    membro.EstadoCivil,
                    membro.Cpf,
                    membro.Rg));
            }
        }

        public void Handle(DesativarMembroCommand message)
        {
            throw new NotImplementedException();
        }

        public void Handle(AtualizarMembroCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
