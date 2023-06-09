using AskizEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Services
{
    public interface IEvent
    {
        IEnumerable<Event> GetEvents { get; }
        Event GetEvent(int ID);
        void Add(Event _Event);
        void Remove(int? ID);
    }
}
