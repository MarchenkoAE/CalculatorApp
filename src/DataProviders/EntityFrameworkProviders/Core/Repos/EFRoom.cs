using Data.Entities;
using Data.Repos;
using DataProviders.Entity_Framework_Providers.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace DataProviders.EntityFrameworkProviders.Core.Repos
{
    public class EFRoom : IRoomRepos
    {
        protected DatabaseContext Context
        {
            get;
        }
        protected EFRoom(DatabaseContext context) => Context = context;
        public IQueryable<Room> Items => Context.Rooms;


        public async Task DeleteAsync(Room room)
        {
            Context.Rooms.Remove(room);
            await Context.SaveChangesAsync();
        }

        public Task<Room> GetItemByIdAsync(Guid id)
        => Context.Rooms.Include(x => x.Ticket).Where(x => x.Id == id).FirstOrDefaultAsync();


        public async Task UpdateAsync(Room room)
        {
            if (room.Id == default || await Context.Rooms.Where(x => x.Id == room.Id).FirstOrDefaultAsync() == default)
            {
                await Context.Rooms.AddAsync(room);
            }
            else
            {
                Context.Rooms.Update(room);
            }
            await Context.SaveChangesAsync();
        }
    }
}
