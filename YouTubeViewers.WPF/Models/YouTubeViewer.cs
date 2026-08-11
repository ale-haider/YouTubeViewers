using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeViewers.WPF.Models
{
    public class YouTubeViewer
    {
        public string Username { get;  }
        public bool IsSubscribed { get;  }
        public bool IsMember { get;  }

        public YouTubeViewer(string username, bool isSubscribed, bool isMember)
        {
            Username = username;
            IsSubscribed = isSubscribed;
            IsMember = isMember;
        }

    }
}
