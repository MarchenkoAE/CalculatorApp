using Data.Entities;
using Data.Repos;
using DataProviders.Entity_Framework_Providers.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DataProviders.EntityFrameworkProviders.Core.Repos
{
    public class EFTimetable : ITimetableRepos
    {
        protected DatabaseContext Context
        {
            get;
        }
        protected EFTimetable(DatabaseContext context) => Context = context;
        public IQueryable<Timetable> Items => Context.Timetables;


        public async Task DeleteAsync(Timetable timetable)
        {
            Context.Timetables.Remove(timetable);
            await Context.SaveChangesAsync();
        }

        public Task<Timetable> GetItemByIdAsync(Guid id)
        => Context.Timetables.Include(x => x.Movie).Where(x => x.Id == id).FirstOrDefaultAsync();


        public async Task UpdateAsync(Timetable timetable)
        {
            if (timetable.Id == default || await Context.Timetables.Where(x => x.Id == timetable.Id).FirstOrDefaultAsync() == default)
            {
                await Context.Timetables.AddAsync(timetable);
            }
            else
            {
                Context.Timetables.Update(timetable);
            }
            await Context.SaveChangesAsync();
        }
    }
}
