using FriendStorage.DataAccess;
using FriendStorage.Model;
using System;
using System.Collections.ObjectModel;

namespace FriendStorage.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase
    {
        public ObservableCollection<Friend> Friends { get; private set; }

        public NavigationViewModel()
        {
            Friends = new ObservableCollection<Friend>();
        }

        public void Load()
        {
            var service = new FileDataService();
            foreach (var friend in service.GetAllFriends())
            {
                Friends.Add(friend);
            }
        }
    }
}
