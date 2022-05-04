using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicBox.Models;

namespace MusicBox.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ArtistDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        public List<Artist> Artists {get;set;}
        



        public IndexModel(ArtistDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Artists = _context.Artist.ToList();
        }
    }
}
