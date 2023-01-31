using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Model
{
    public class Album
    {
        public int albumId { get; set; }
        public string albumName { get; set; }
        public List<string> songsNames { get; set; }

    }
}
