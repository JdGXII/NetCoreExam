﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exman.Api.Models
{
    public class Track
    {
        public Track()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
            PlaylistTracks = new HashSet<PlaylistTrack>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public int GenreId { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public int Bytes { get; set; }
        public float UnitPrice { get; set; }
        public Album Album { get; set; }
        public MediaType MediaType { get; set; }
        public Genre Genre { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
        public ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
}
