using System;
using System.Collections.Generic;
using System.Text;
using YouTubeViewers.WPF.Stores;

namespace YouTubeViewers.WPF.Commands
{
    internal class CloseModalCommand : CommandBase
    {
        private readonly ModelNavigationStore _modelNavigationStore;

        public CloseModalCommand(ModelNavigationStore modelNavigationStore)
        {
            _modelNavigationStore = modelNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            _modelNavigationStore.Close();
        }
    }
}
