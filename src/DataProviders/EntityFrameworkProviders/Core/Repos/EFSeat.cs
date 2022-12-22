using Data.Entities;
using Data.Repos;
using DataProviders.Entity_Framework_Providers.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DataProviders.EntityFrameworkProviders.Core.Repos
{
    public class EFSeat : ISeatRepos
    {
        protected DatabaseContext Context
        {
            get;
        }
        protected EFSeat(DatabaseContext context) => Context = context;
        public IQueryable<Seat> Items => Context.Seats;


        public async Task DeleteAsync(Seat seat)
        {
            Context.Seats.Remove(seat);
            await Context.SaveChangesAsync();
        }

        public Task<Seat> GetItemByIdAsync(Guid id)
        => Context.Seats.Include(x => x.Ticket).Where(x => x.Id == id).FirstOrDefaultAsync();


        public async Task UpdateAsync(Seat seat)
        {
            if (seat.Id == default || await Context.Cinemas.Where(x => x.Id == seat.Id).FirstOrDefaultAsync() == default)
            {
                await Context.Seats.AddAsync(seat);
            }
            else
            {
                Context.Seats.Update(seat);
            }
            await Context.SaveChangesAsync();
        }
    }
}
