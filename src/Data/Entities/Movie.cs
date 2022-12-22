using System;



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
