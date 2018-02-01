using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Appointments.DataProvider;
using EventMaker.Annotations;
using EventMaker.Model;

namespace EventMaker.Handler
{
    public class EventHandler : INotifyPropertyChanged
    {
        public Event SelectedEvent
        {
            get => _selectedEvent;
            set
            {
                _selectedEvent = value;
                OnPropertyChanged(nameof(SelectedEvent));
            }
        }

        public Event CreateEvent
        {
            get => _createEvent;
            set
            {
                _createEvent = value;
                OnPropertyChanged(nameof(CreateEvent));
            }
        }

        public Event DeleteEvent
        {
            get => _deleteEvent;
            set
            {
                _deleteEvent = value;
                OnPropertyChanged(nameof(DeleteEvent));
            }
        }


        private void OnPropertyChanged(string selectedEventName)
        {
            throw new NotImplementedException();
        }


        private static Event _selectedEvent;
        private Event _createEvent;
        private Event _deleteEvent;
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string createEventName, [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}