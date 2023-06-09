using AskizEvent.Models;
using AskizEvent.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Repository
{
    public class EventRepository : IEvent
    {
        public DBContext db;
        public EventRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<Event> GetEvents => db.Event;

        public void Add(Event _Event)
        {
            db.Event.Add(_Event);
            db.SaveChanges();
        }

        public Event GetEvent(int ID)
        {
            Event dbEntity = db.Event.Find(ID);
            return dbEntity;
        }


        public void Remove(int? ID)
        {
            Event dbEntity = db.Event.Find(ID);
            db.Event.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
