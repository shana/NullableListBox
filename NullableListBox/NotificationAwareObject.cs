using System.ComponentModel;

namespace NullableListBox
{
    public abstract class NotificationAwareObject : INotifyPropertyChanged, INotifyPropertySource
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}