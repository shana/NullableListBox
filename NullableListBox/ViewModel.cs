using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableListBox
{
    public class ViewModel : NotificationAwareObject, INotifyPropertySource
    {
        ObservableCollection<string> users = new ObservableCollection<string>
        {
            "User 1",
            "User 2",
            "User 3",
            "User 4",
            "User 5",
            "User 6",
            "User 7",
            "User 8",
        };
        public ObservableCollection<string> Users
        {
            get { return users; }
            set { users = value; this.RaisePropertyChange(); }
        }
        string selectedUser;
        public string SelectedUser
        {
            get { return selectedUser; }
            set { selectedUser = value; this.RaisePropertyChange(); }
        }

        public string EmptyUser { get { return "[None]"; } }
    }
}
