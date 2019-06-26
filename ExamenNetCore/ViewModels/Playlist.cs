using Exman.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.ViewModels
{
    public class Playlist
    {
        public string Name { get; set; }
        public ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
}
