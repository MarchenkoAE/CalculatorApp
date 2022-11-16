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
    public abstract class EFUsers : IUserRepos

    {  
        protected DataBaseContext Context
        {
            get;
        }
        protected EFUsers(DataBaseContext context) => Context = context;
        public IQueryable<User> Items => Context.Users;

        public Task<User> GetItemByIdAsync(Guid id)
            => Context.Users.Include(x => x.Histories).Where(x => x.Id == id).FirstOrDefaultAsync();
        public  async Task UpdateAsync(User user)
        {
            if (user.Id == default || await Context.Users.Where(x => x.Id == user.Id).FirstOrDefaultAsync()== default)
            {
                await Context.Users.AddAsync(user);
            }
            else
            {
                Context.Users.Update(user);
            }
            await Context.SaveChangesAsync();
        }
        public async Task DeleteAsync(User user)
        {
            Context.Users.Remove(user);
            await Context.SaveChangesAsync();
        }
    }
}
