using AskizEvent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Repository
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext>options):base(options)
        {

        }
        public DbSet<Application>  Application { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Statuses> Statuses { get; set; }
        public DbSet<TypeEvent> TypeEvents { get; set; }
        public DbSet<Users> Users { get; set; }
     }
} 
