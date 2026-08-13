using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeViewers.WPF.ViewModel
{
    public class AddYouTubeViewerViewModel: ViewModelBase
    {
        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }

        public AddYouTubeViewerViewModel()
        {
           YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel();
        }
    }
}
