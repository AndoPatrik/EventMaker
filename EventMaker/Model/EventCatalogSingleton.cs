using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class EventCatalogSingleton
    {
        private ObservableCollection<Event> _events;
        private static EventCatalogSingleton Instance { get; set; }

        private EventCatalogSingleton()
        {
            _events = new ObservableCollection<Event>();
        }

        public static EventCatalogSingleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EventCatalogSingleton();
            }

            return Instance;
        }

        {
            _events = events;
        }

        public ObservableCollection<Event> GetEvent()
        {
            return _events;
        }

        private class ObserverableCollection<T> : ObservableCollection<Event>
        {
        }

        #region Operations

        //public void AddEVent(Event Event)
        //{

        //}

        //public void async LoadEventsAsync()
        //{

        //}

        //public void RemoveEvent(Event Event)
        //{

        //}

        #endregion
    }

    
}
