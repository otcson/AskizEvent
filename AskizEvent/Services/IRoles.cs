using AskizEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Services
{
    public interface IRoles
    {
        IEnumerable<Roles> GetRoles { get; }
        Roles GetRole(int ID);
        void Add(Roles _Roles);
        void Remove(int ID);
    }
}
