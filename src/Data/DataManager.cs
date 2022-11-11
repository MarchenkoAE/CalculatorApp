using System;
using System.Collections.Generic;
using System.Text;
using Data.Repos;

namespace Data
{
    public class DataManager
    { 
        public IUserRepos Users
        {
            get;
        }

        public DataManager(IUserRepos users, IHistoryRepos history)
        {
            Users = users;
            History = history;
        }

        public IHistoryRepos History
        {
            get;
        }
    }
}
