using System;
namespace MusicBox.Models{
    public class Album{
        public int AlbumID {get;set;}
        public string Title{get;set;}
        public string Genre{get;set;}
        public string Rating{get;set;}
        public Artist Artist{get;set;}
    }
}