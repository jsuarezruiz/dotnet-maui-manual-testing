using ChatApp.Models;
using ChatApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ChatApp.ViewModels
{
    [QueryProperty(nameof(Message), "Message")]
    public partial class DetailViewModel : ObservableObject
    {
        readonly MessageService _messageService;

        Message _message;
        User _user;
        ObservableCollection<Message> _messages;
        
        public DetailViewModel(MessageService messageService)
        {
            _messageService = messageService;
        }

        public Message Message
        {
            get { return _message; }
            set 
            { 
                _message = value; 
                
                if (_message is not null)
                {
                    User = _message.Sender;
                    Messages = new ObservableCollection<Message>(_messageService.GetMessages(User));
                }

                OnPropertyChanged();
            }
        }

        public ObservableCollection<Message> Messages
        {
            get { return _messages; }
            set
            {
                _messages = value;
                OnPropertyChanged();
            }
        }

        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}