using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;

namespace Data.Entities
{
    public class Room
    {
        public Guid Id
        {
            get;

            set;
        }


        public string Type
        {
            get;

            set;
        } = null!;

        public Guid CinemaId
        {
            get;

            set;
        }

        public Cinema Cinema
        {
            get;

            set;
        } = null!;


    }
}
