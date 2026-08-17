using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeViewers.WPF.ViewModel
{
    public class EditYouTubeViewerViewModel
    {
        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }

        public EditYouTubeViewerViewModel()
        {
            YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel(); 
        }

    }
}
