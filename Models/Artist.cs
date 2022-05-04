using System;
using System.Collections.Generic;

namespace MusicBox.Models{
    public class Artist{
        public int ArtistID {get;set;}
        public string ArtistName{get;set;}
        public List<Album> Albums {get;set;}
    }
}