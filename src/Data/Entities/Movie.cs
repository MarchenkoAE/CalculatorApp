using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;



namespace Data.Entities
{
    public class Movie
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

        public string Genre
        {
            get;

            set;
        } = null!;

        public DateTime Date
        {
            get;

            set;
        }

    }
}
