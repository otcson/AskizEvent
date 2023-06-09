using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AskizEvent.Models;
using AskizEvent.Services;

namespace AskizEvent.Repository
{
    public class TypeEventRepository : ITypeEvent
    {
        public DBContext db;
        public TypeEventRepository(DBContext _db)
        {
            db = _db;
        }

        public IEnumerable<TypeEvent> GetTypeEvents => db.TypeEvents;

        public void Add(TypeEvent _TypeEvent)
        {
            db.TypeEvents.Add(_TypeEvent);
            db.SaveChanges();
        }

        public TypeEvent GetTypeEvent(int ID)
        {
            return db.TypeEvents.Find(ID);
        }

        public void Remove(int ID)
        {
            TypeEvent dbEntity = db.TypeEvents.Find(ID);
            db.TypeEvents.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
