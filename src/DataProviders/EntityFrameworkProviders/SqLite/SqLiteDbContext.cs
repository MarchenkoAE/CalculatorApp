using DataProviders.Entity_Framework_Providers.Core;
using Microsoft.EntityFrameworkCore;

namespace DataProviders.EntityFrameworkProviders.SqLite
{
    public class SqLiteDbContext : DatabaseContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder) =>
            builder.UseSqlite("Data Source = C:\\0\\Data.db");
    }
}
