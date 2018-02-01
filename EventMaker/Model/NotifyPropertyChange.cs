using System.ComponentModel;
using System.Runtime.CompilerServices;
using EventMaker.Annotations;

namespace EventMaker.Model
{
    public class NotifyPropertyChange
    {
       
        public event NotifyPropertyChange PropertyChanged;

       
        protected virtual void NotifyPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Invoke(NotifyPropertyChange notifyPropertyChange, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            throw new System.NotImplementedException();
        }
    }
}