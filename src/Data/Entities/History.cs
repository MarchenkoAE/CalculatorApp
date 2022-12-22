using System;

namespace Data.Entities
{
    public class History
    {
        public Guid Id
        {
            get;

            set;
        }


        public Guid TicketId
        {
            get;

            set;
        }

        public string Action
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

        public Ticket Ticket
        {
            get;

            set;
        } = null!;
    }



}
