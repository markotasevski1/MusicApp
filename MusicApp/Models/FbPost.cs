﻿using System;

namespace Ukim.MusicApp.Models
{
    public class FbPost
    {
        public Guid Id { get; set; }

        public DateTime Timestamp { get; set; }

        public string Content { get; set; }
    }
}
