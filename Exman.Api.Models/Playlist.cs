﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exman.Api.Models
{
    public class Playlist
    {
        public Playlist() => PlaylistTracks = new HashSet<PlaylistTrack>();

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
}
