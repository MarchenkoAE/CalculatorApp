using System;


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

        public Room Room
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
