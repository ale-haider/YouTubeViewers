using System;
using System.Collections.Generic;
using System.Text;
using YouTubeViewers.WPF.Stores;
using YouTubeViewers.WPF.ViewModel;

namespace YouTubeViewers.WPF.Commands
{
    public class OpenEditYouTubeViewerCommand : CommandBase
    {
        private readonly ModelNavigationStore _modalNavigationStore;

        public OpenEditYouTubeViewerCommand(ModelNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            EditYouTubeViewerViewModel editYouTubeViewerViewModel = new EditYouTubeViewerViewModel(_modalNavigationStore);

            _modalNavigationStore.CurrentViewModel = editYouTubeViewerViewModel;
        }

    }
}
