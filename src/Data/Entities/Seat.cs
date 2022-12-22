using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;

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
    }
}
