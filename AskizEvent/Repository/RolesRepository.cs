using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AskizEvent.Models;
using AskizEvent.Services;

namespace AskizEvent.Repository
{
    public class RolesRepository : IRoles
    {
        public DBContext db;
        public RolesRepository(DBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Roles> GetRoles => db.Roles;

        public void Add(Roles _Roles)
        {
            db.Roles.Add(_Roles);
            db.SaveChanges();
        }

        public Roles GetRole(int ID)
        {
            return db.Roles.Find(ID);
        }

        public void Remove(int ID)
        {
            Roles dbEntity = db.Roles.Find(ID);
            db.Roles.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
