using Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class History
    {
        public Guid Id
        {
            get;

            set;
        }
        public Calculations Calculations
        {
            get;

            set;
        }
        public DateTime DateTime
        {
            get;

            set;
        }

        public Guid UserId
        {
            get;

            set;
        }

        public User User
        {
            get;

            set;
        } 
    }

   

}
