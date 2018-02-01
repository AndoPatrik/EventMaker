using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization.DateTimeFormatting;

namespace EventMaker.Model
{
    public class Event
    {
        private DateTime _dateTime;
        private int _id;
        private string _description;
        private string _name;
        private string _place;

        public Event()
        {
            
        }

        public DateTime DateTime { get => _dateTime; set => _dateTime = value; }
        public global::System.Int32 Id { get => _id; set => _id = value; }
        public global::System.String Description { get => _description; set => _description = value; }
        public global::System.String Name { get => _name; set => _name = value; }
        public global::System.String Place { get => _place; set => _place = value; }
    }
}
