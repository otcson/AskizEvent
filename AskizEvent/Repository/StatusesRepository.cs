using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AskizEvent.Models;
using AskizEvent.Services;

namespace AskizEvent.Repository
{
    public class StatusesRepository : IStatuses
    {
        public DBContext db;
        public StatusesRepository(DBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Statuses> GetStatuses => db.Statuses;

        public void Add(Statuses _Statuses)
        {
            db.Statuses.Add(_Statuses);
            db.SaveChanges();
        }

        public Statuses GetStatus(int ID)
        {
            return db.Statuses.Find(ID);
        }

        public void Remove(int ID)
        {
            Statuses dbEntity = db.Statuses.Find(ID);
            db.Statuses.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
