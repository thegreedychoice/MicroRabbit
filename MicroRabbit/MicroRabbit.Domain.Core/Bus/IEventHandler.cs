using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent>: IEventHandler
        where TEvent: Event
    {
        //This EventHandler takes in any event with a constraint that it should be of Type Event and implements IEventHandler

        //Interface has a task handle that handles any Event
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
