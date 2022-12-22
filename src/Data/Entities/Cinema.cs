using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;


namespace Data.Entities
{
    public class Cinema
    {
        public Guid Id
        {
            get;

            set;
        }


        public string Name
        {
            get;

            set;
        } = null!;

        public string Address
        {
            get;

            set;
        } = null!;


    }
}
