using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class EventCatalogSingleton
    {
        private ObserverableCollection<Event> _events;
        private static EventCatalogSingleton Instance { get , set; }

        private EventCatalogSingleton()
        {
            _events = new ObserverableCollection<Event>();
        }

        public static EventCatalogSingleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EventCatalogSingleton();
            }

            return Instance;
        }

        public ObserverableCollection<Event> SetEvents(ObserverableCollection<Event> events)
        {
            _events = events;
        }

        public ObserverableCollection<Event> GetEvent()
        {
            return _events;
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
