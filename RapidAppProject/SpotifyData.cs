using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidAppProject
{
    public class SpotifyData : EventArgs
    {
        public string cover { get; set; }
        public SpotifyData(string Cover)
        {
            cover = Cover;
        }

    }
}
