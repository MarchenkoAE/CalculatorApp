using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Timetable
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

        public Movie Movie
        {
            get;

            set;
        } = null!;

        public Guid RoomId
        {
            get;

            set;
        }
        public Room Room
        {
            get;

            set;
        } = null!;

        public DateTime DateTime
        {
            get;

            set;
        } = DateTime.UtcNow;
    }
}
