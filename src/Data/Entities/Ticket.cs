using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;

namespace Data.Entities
{
    public class Ticket
    {
      
            public Guid Id
            {
                get;

                set;
            }


            public Guid MovieId
            {
                get;

                set;
            }
            public Guid RoomId
            {
                get;

                set;
            }

            public Guid CinemaId
            {
                get;

                set;
            }

            public DateTime DateTime
            {
                get;

                set;
            } = DateTime.UtcNow;

            public Guid SeatId
            {
                get;

                set;
            }

            public string Price
            {
                get;

                set;
            } = null!;


        public Movie Movie
        {
            get;

            set;
        } = null!;

        public Room Room
        {
            get;

            set;
        } = null!;

        public Cinema Cinema
        {
            get;

            set;
        } = null!;
        public Seat Seat
        {
            get;

            set;
        } = null!;


    }
}
