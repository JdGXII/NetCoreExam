using System;
using System.Collections.Generic;
using System.Text;

namespace Exman.Api.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
    }
}
