namespace NullableListBox
{
    public interface INotifyPropertySource
    {
        void RaisePropertyChanged(string propertyName);
    }
}