using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataProviders.Entity_Framework_Providers.Core
{
    public abstract class DatabaseContext: DbContext
    {
        protected DatabaseContext()
        { 
            Database.EnsureCreated();
        }
        public DbSet<User> Users
        {
            get;
        }
        public DbSet<History> Histories
        {
            get;
        }

    }

}
