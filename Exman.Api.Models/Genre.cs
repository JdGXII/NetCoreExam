﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exman.Api.Models
{
    public class Genre
    {
        public Genre()
        {
            Tracks = new HashSet<Track>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}
