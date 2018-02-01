using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EventMaker.Annotations;
using EventMaker.Model;

namespace EventMaker.ViewModel
{
    public class EventVM :INotifyPropertyChanged
    {
        private DateTime _dateTime;
        private int _id;
        private string _description;
        private string _name;
        private string _place;
        
        private DateTimeOffset _date;
        private TimeSpan _time;

        public EventVM(DateTime dateTime)
        {
            _dateTime = dateTime;
          
            _date = new DateTimeOffset();
            _time = new TimeSpan();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}