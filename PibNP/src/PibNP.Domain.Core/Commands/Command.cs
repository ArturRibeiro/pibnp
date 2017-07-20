using System;
using FluentValidation.Results;
using PibNP.Domain.Core.Events;

namespace PibNP.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp
        {
            get;
            private set;
        }

        public ValidationResult ValidationResult
        {
            get;
            set;
        }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}