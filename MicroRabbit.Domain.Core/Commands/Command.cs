﻿using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestam { get; protected set; }
        protected Command()
        {
            Timestam = DateTime.Now;
        }
    }
}