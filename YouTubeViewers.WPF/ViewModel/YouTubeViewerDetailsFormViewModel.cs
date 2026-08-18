using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Text;
using System.Windows.Input;

namespace YouTubeViewers.WPF.ViewModel
{
    public class YouTubeViewerDetailsFormViewModel : ViewModelBase
    {
        private string _username;
            public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
                OnPropertyChanged(nameof(CanSubmit));
            }

        }

        private bool _isSubscribed;
        public bool IsSubscribed
        {
            get { return _isSubscribed; }
            set
            {
                _isSubscribed = value;
                OnPropertyChanged(nameof(IsSubscribed));
            }
        }

        private bool _isMember;
        public bool IsMember
        {
            get { return _isMember; }
            set
            {
                _isMember = value;
                OnPropertyChanged(nameof(IsMember));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        public bool CanSubmit =>  !string.IsNullOrWhiteSpace(Username);

        //commands defined in xamal

        public ICommand SubmitCommand { get;  } //removed set cause its readonly
        public ICommand CancelCommand { get;  }

        //can subimit logic that unblurs button
         
    }
}
