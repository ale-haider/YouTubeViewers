using System;
using System.Collections.Generic;
using System.Text;
using YouTubeViewers.WPF.ViewModel;

namespace YouTubeViewers.WPF.Stores
{
    public class ModelNavigationStore
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }

            set
            {
                _currentViewModel = value;

                CurrentViewModelChanged?.Invoke();
            }
        }


        public event Action CurrentViewModelChanged;
        
    }
}
