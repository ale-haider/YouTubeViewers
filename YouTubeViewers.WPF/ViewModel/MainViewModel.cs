using System;
using System.Collections.Generic;
using System.Text;
using YouTubeViewers.WPF.Stores;

namespace YouTubeViewers.WPF.ViewModel
{
     class MainViewModel : ViewModelBase
    {
        private readonly ModelNavigationStore _modelNavigationStore;
        public ViewModelBase CurrentModelViewModel => _modelNavigationStore.CurrentViewModel;

        public bool IsModalOpen => _modelNavigationStore.IsOpen;

        public YouTubeViewersViewModel YouTubeViewersViewModel { get;  }


        public MainViewModel(ModelNavigationStore modelNavigationStore, YouTubeViewersViewModel youTubeViewersViewModel)
        {
            _modelNavigationStore = modelNavigationStore;
            YouTubeViewersViewModel = youTubeViewersViewModel;

            _modelNavigationStore.CurrentViewModelChanged += ModalNavigation_CurrentViewModelIChanged;
        }

        private void ModalNavigation_CurrentViewModelIChanged()
        {
            OnPropertyChanged(nameof(CurrentModelViewModel));
            OnPropertyChanged(nameof(IsModalOpen));
        }

    }
}
