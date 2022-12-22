using Data.Entities;
using Data.Repos;
using DataProviders.Entity_Framework_Providers.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DataProviders.EntityFrameworkProviders.Core.Repos
{
    public class EFMovie : IMovieRepos
    {
        protected DatabaseContext Context
        {
            get;
        }
        protected EFMovie(DatabaseContext context) => Context = context;
        public IQueryable<Movie> Items => Context.Movies;


        public async Task DeleteAsync(Movie movie)
        {
            Context.Movies.Remove(movie);
            await Context.SaveChangesAsync();
        }

        public Task<Movie> GetItemByIdAsync(Guid id)
        => Context.Movies.Include(x => x.Ticket).Where(x => x.Id == id).FirstOrDefaultAsync();


        public async Task UpdateAsync(Movie movie)
        {
            if (movie.Id == default || await Context.Movies.Where(x => x.Id == movie.Id).FirstOrDefaultAsync() == default)
            {
                await Context.Movies.AddAsync(movie);
            }
            else
            {
                Context.Movies.Update(movie);
            }
            await Context.SaveChangesAsync();
        }
    }
}
