using ChatApp.Models;
using ChatApp.Services;
using ChatApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ChatApp.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        ObservableCollection<User> _users;
        ObservableCollection<Message> _recentChat;

        public HomeViewModel()
        {
            LoadData();
        }

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Message> RecentChat
        {
            get { return _recentChat; }
            set
            {
                _recentChat = value;
                OnPropertyChanged();
            }
        }

        [RelayCommand]
        async Task GoToDetails(Message message)
        {
            if (message == null)
                return;

            await Shell.Current.GoToAsync(nameof(DetailView), true, new Dictionary<string, object>
            {
                {"Message", message }
            });
        }

        void LoadData()
        {
            Users = new ObservableCollection<User>(MessageService.Instance.GetUsers());
            RecentChat = new ObservableCollection<Message>(MessageService.Instance.GetChats());
        }
    }
}