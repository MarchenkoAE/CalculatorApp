using DataProviders.Entity_Framework_Providers.Core;
using DataProviders.EntityFrameworkProviders.Core.Repos;

namespace DataProviders.EntityFrameworkProviders.SqLite
{
    public class EFHistorySqLite : EFHistory
    {
        protected EFHistorySqLite(DatabaseContext context) : base(context)
        {
        }
    }

    public class EFUsersSqLite : EFUsers
    {
        public EFUsersSqLite(DatabaseContext context) : base(context)
        {
        }
    }

}
