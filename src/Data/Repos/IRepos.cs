using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repos
{
    public interface IUserRepos: IReposBase<User>
    {
    }

    public interface IHistoryRepos : IReposBase<History>
    {
    }

}
