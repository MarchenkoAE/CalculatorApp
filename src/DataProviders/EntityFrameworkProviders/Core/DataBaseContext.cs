using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataProviders.Entity_Framework_Providers.Core
{
    public abstract class DatabaseContext : DbContext
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
        public DbSet<Cinema> Cinemas
        {
            get;
        }
        public DbSet<Movie> Movies
        {
            get;
        }
        public DbSet<Room> Rooms
        {
            get;
        }
        public DbSet<Seat> Seats
        {
            get;
        }
        public DbSet<Ticket> Tickets
        {
            get;
        }
        public DbSet<Timetable> Timetables
        {
            get;
        }


    }

}
