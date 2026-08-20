using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using YouTubeViewers.WPF.Commands;
using YouTubeViewers.WPF.Stores;

namespace YouTubeViewers.WPF.ViewModel
{
     class YouTubeViewersViewModel : ViewModelBase
    {
        public YouTubeViewersListingViewModel YouTubeViewersListingViewModel { get;  }
        public YouTubeViewerDetailsViewModel YouTubeViewerDetailsViewModel { get;  }
        public ICommand AddYouTubeViewersCommand { get;}

        public YouTubeViewersViewModel(SelectedYouTubeViewerStore _selectedYouTubeViewerStore, ModelNavigationStore modalNavigationStore)
        {
            YouTubeViewerDetailsViewModel = new YouTubeViewerDetailsViewModel(_selectedYouTubeViewerStore);

            YouTubeViewersListingViewModel = new YouTubeViewersListingViewModel(_selectedYouTubeViewerStore);

            AddYouTubeViewersCommand = new OpenAddYouTubeViewerCommand(modalNavigationStore);
        }

    }
}
