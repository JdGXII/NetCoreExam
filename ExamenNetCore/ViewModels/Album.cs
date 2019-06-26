using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.ViewModels
{
    public class Album
    {
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}
