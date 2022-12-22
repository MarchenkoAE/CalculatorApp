using Data.Entities;
using Data.Repos;
using DataProviders.Entity_Framework_Providers.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace DataProviders.EntityFrameworkProviders.Core.Repos
{
    public class EFTicket : ITicketRepos
    {
        protected DatabaseContext Context
        {
            get;
        }
        protected EFTicket(DatabaseContext context) => Context = context;
        public IQueryable<Ticket> Items => Context.Tickets;


        public async Task DeleteAsync(Ticket ticket)
        {
            Context.Tickets.Remove(ticket);
            await Context.SaveChangesAsync();
        }

        public Task<Ticket> GetItemByIdAsync(Guid id)
        => Context.Tickets.Include(x => x.History).Where(x => x.Id == id).FirstOrDefaultAsync();


        public async Task UpdateAsync(Ticket ticket)
        {
            if (ticket.Id == default || await Context.Tickets.Where(x => x.Id == ticket.Id).FirstOrDefaultAsync() == default)
            {
                await Context.Tickets.AddAsync(ticket);
            }
            else
            {
                Context.Tickets.Update(ticket);
            }
            await Context.SaveChangesAsync();
        }
    }
}
