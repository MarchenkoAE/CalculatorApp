using Data.Entities;
using Data.Repos;
using DataProviders.Entity_Framework_Providers.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DataProviders.EntityFrameworkProviders.Core.Repos
{
    public class EFCinema : ICinemaRepos
    {
        protected DatabaseContext Context
        {
            get;
        }
        protected EFCinema(DatabaseContext context) => Context = context;
        public IQueryable<Cinema> Items => Context.Cinemas;


        public async Task DeleteAsync(Cinema cinema)
        {
            Context.Cinemas.Remove(cinema);
            await Context.SaveChangesAsync();
        }

        public Task<Cinema> GetItemByIdAsync(Guid id)
        => Context.Cinemas.Include(x => x.Ticket).Where(x => x.Id == id).FirstOrDefaultAsync();


        public async Task UpdateAsync(Cinema cinema)
        {
            if (cinema.Id == default || await Context.Cinemas.Where(x => x.Id == cinema.Id).FirstOrDefaultAsync() == default)
            {
                await Context.Cinemas.AddAsync(cinema);
            }
            else
            {
                Context.Cinemas.Update(cinema);
            }
            await Context.SaveChangesAsync();
        }
    }
}
