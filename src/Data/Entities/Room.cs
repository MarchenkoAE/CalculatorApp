using System;

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
        public Timetable Timetable
        {
            get;

            set;
        } = null!;
        public Ticket Ticket
        {
            get;

            set;
        } = null!;

    }
}
