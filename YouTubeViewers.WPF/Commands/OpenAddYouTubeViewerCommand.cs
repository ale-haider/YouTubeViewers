using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using YouTubeViewers.WPF.Stores;
using YouTubeViewers.WPF.ViewModel;

namespace YouTubeViewers.WPF.Commands
{
    public class OpenAddYouTubeViewerCommand : CommandBase
    {
        private readonly ModelNavigationStore _modalNavigationStore;

        public OpenAddYouTubeViewerCommand(ModelNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            AddYouTubeViewerViewModel addYouTubeViewerViewModel = new AddYouTubeViewerViewModel(_modalNavigationStore);

            _modalNavigationStore.CurrentViewModel = addYouTubeViewerViewModel;
        }

    }
}
