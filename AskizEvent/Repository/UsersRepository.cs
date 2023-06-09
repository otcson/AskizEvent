using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AskizEvent.Models;
using AskizEvent.Services;

namespace AskizEvent.Repository
{
    public class UsersRepository : IUsers
    {
        public DBContext db;
        public UsersRepository(DBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Users> GetUsers => db.Users;

        public void Add(Users _Users)
        {
            db.Users.Add(_Users);
            db.SaveChanges();
        }

        public Users GetUser(int ID)
        {
            return db.Users.Find(ID);
        }

        public void Remove(int? ID)
        {
            Users dbEntity = db.Users.Find(ID);
            db.Users.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
