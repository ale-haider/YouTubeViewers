using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace YouTubeViewers.WPF.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanging
    {
        public event PropertyChangingEventHandler? PropertyChanging;


        protected virtual void OnPropertyChanged( string propertyName)
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void Dispose() { }

    }
}
