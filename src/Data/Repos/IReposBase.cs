using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Data.Repos
{
    public interface IReposBase<TTable> where TTable : class
    { 
        IQueryable<TTable> Items  //read
        {
            get;
        }
        TTable GetItemById(Guid id); //read

        int Update(TTable table);    //update

       

        int Delete(TTable table);     //delete



    }
}
