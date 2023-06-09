using AskizEvent.Models;
using AskizEvent.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Repository
{
    public class ApplicationRepository : IApplication
    {
        public DBContext db;
        public ApplicationRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<Application> GetEvents => db.Application;

        public IEnumerable<Application> GetApplications => db.Application;

        public void Add(Application _Application)
        {
            db.Application.Add(_Application);
            db.SaveChanges();
        }

        public Application GetApplication(int ID)
        {
            return db.Application.Find(ID);
        }

        public void Remove(int ID)
        {
            Application dbEntity = db.Application.Find(ID);
            db.Application.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
