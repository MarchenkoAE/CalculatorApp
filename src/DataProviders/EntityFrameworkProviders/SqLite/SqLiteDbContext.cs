using DataProviders.Entity_Framework_Providers.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataProviders.EntityFrameworkProviders.SqLite
{
    public class SqLiteDbContext : DatabaseContext
    {  
        protected override void OnConfiguring(DbContextOptionsBuilder builder) =>
            builder.UseSqlite("Data Source = C:\\0\\Data.db");
    }
}
