using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repos
{
    public interface IReposBase<TTable> where TTable : class
    { 
        IQueryable<TTable> Items  //read
        {
            get;
        }
        Task<TTable> GetItemByIdAsync(Guid id); //read

        Task UpdateAsync(TTable table);    //update

       

        Task DeleteAsync(TTable table);     //delete



    }
}
