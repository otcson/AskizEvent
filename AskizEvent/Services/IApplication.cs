using AskizEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Services
{
    public interface IApplication
    {
        IEnumerable<Application> GetApplications { get; }
        Application GetApplication (int ID);
        void Add(Application _Application);
        void Remove(int ID);
    }
}
