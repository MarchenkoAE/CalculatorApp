using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class User
    {
        public Guid Id
            { get;

              set;
            }
        public string Login
        {
            get;
            set;
        } = null!;

        public string Password
        {
            get;
            set;
        } = null!;

        public IList<History> Histories
        {
            get;

            set;
        } = new List<History>();

    }


}
