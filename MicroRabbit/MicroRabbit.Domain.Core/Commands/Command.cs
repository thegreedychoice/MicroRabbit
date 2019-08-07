using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command: Message 
    {
        public DateTime Timestamp { get; protected set; } //only classes that inherit from this class can set the timestamp

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
