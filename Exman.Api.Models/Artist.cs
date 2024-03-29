﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exman.Api.Models
{
    public class Artist
    {
        public Artist() => Albums = new HashSet<Album>();

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
