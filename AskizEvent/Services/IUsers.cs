using AskizEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Services
{
    public interface IUsers
    {
        IEnumerable<Users> GetUsers { get; }
        Users GetUser(int ID);
        void Add(Users _Users);
        void Remove(int? ID);
    }
}
