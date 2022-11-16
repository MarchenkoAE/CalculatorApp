using Data.Entities;
using Data.Repos;
using DataProviders.Entity_Framework_Providers.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders.EntityFrameworkProviders.Core.Repos
{
    public class EFHistory : IHistoryRepos
    {
        protected DataBaseContext Context
        {
            get;
        }
        protected EFHistory(DataBaseContext context) => Context = context;
        public IQueryable<History> Items => Context.Histories;

        public async Task DeleteAsync(History history)
        {
            Context.Histories.Remove(history);
            await Context.SaveChangesAsync();
        }

        public Task<History> GetItemByIdAsync(Guid id)
            => Context.Histories.Include(x => x.User).Where(x => x.Id == id).FirstOrDefaultAsync();

        public async Task UpdateAsync(History history)
        {
            if (history.Id == default || await Context.Histories.Where(x => x.Id == history.Id).FirstOrDefaultAsync() == default)
            {
                await Context.Histories.AddAsync(history);
            }
            else
            {
                Context.Histories.Update(history);
            }
            await Context.SaveChangesAsync();
        }
    }
}
