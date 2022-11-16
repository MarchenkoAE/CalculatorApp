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
        public string FirstOperand
        {
            get;

            set;
        } = null!;
        public string? SecondOperand
        {
            get;

            set;
        }

        public string Operation
        {
            get;

            set;
        } = null!;

        public string Result
        {
            get;

            set;
        } = null!;

        public DateTime DateTime
        {
            get;

            set;
        } = DateTime.UtcNow;

        public Guid UserId
        {
            get;

            set;
        }

        public User User
        {
            get;

            set;
        } = null!;
    }

   

}
