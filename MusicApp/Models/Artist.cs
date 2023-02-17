using System;

namespace Ukim.MusicApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public List<FbPost> Posts { get; set; }
    }
}
