using System;

namespace Data.Entities
{
    public class Seat
    {
        public Guid Id
        {
            get;

            set;
        }

        public string Status
        {
            get;

            set;
        } = null!;
        public string Type
        {
            get;

            set;
        } = null!;

        public string Price
        {
            get;

            set;
        } = null!;



        public Guid TimetableId
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
