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
        }

        public string Password
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }

        public bool IsConfirmed
        {
            get;
            set;
        }

        public IList<History> Histories
        {
            get;

            set;
        } = new List<History>();


    }


}
