using AskizEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Services
{
    public interface IStatuses
    {
        IEnumerable<Statuses> GetStatuses { get; }
        Statuses GetStatus(int ID);
        void Add(Statuses _Statuses);
        void Remove(int ID);
    }
}
