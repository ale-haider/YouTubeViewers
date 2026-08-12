using System;
using System.Collections.Generic;
using System.Text;
using YouTubeViewers.WPF.Models;
using YouTubeViewers.WPF.Stores;

namespace YouTubeViewers.WPF.ViewModel
{
    class YouTubeViewerDetailsViewModel : ViewModelBase
    {
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;


        private YouTubeViewer SelectedYouTubeViewer => _selectedYouTubeViewerStore.SelectedYouTubeViewer;

        public bool HasSelectedYouTubeViewer =>  SelectedYouTubeViewer != null;

        public string Username => SelectedYouTubeViewer?.Username ?? "Unknown" ;
        public string IsSubscribedDisplay => (SelectedYouTubeViewer?.IsSubscribed ?? false) ? "Yes" : "No"; //these are fall back values that displayes and handle exception of null and case of false and true
        public string IsMemberDisplay => (SelectedYouTubeViewer?.IsMember  ?? false) ? "Yes" : "No";
         

        public YouTubeViewerDetailsViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore)
        {
            _selectedYouTubeViewerStore = selectedYouTubeViewerStore;

            //now displays the selected user
            _selectedYouTubeViewerStore.SelectedYouTubeViewerChanged += SelectedYouTubeViewerStore_SelectedYouTubeViewerChanged;
        }

        private void SelectedYouTubeViewerStore_SelectedYouTubeViewerChanged()
        {
            OnPropertyChanged(nameof(HasSelectedYouTubeViewer));
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(IsSubscribedDisplay));
            OnPropertyChanged(nameof(IsMemberDisplay));
        }



        protected override void Dispose()
        {
            _selectedYouTubeViewerStore.SelectedYouTubeViewerChanged -= SelectedYouTubeViewerStore_SelectedYouTubeViewerChanged;

            base.Dispose();
        }

    }
}
