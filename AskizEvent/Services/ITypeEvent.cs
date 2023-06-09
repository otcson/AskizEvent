using AskizEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Services
{
    public interface ITypeEvent
    {
        IEnumerable<TypeEvent> GetTypeEvents { get; }
        TypeEvent GetTypeEvent(int ID);
        void Add(TypeEvent _TypeEvent);
        void Remove(int ID);
    }
}
