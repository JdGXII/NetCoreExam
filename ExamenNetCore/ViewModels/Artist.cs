﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.ViewModels
{
    public class Artist
    {
        public string Name { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
