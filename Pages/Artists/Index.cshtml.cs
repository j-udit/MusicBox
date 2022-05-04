using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicBox.Models;

namespace MusicBox.Pages.Artists
{
    public class IndexModel : PageModel
    {
        private readonly MusicBox.Models.ArtistDbContext _context;

        public IndexModel(MusicBox.Models.ArtistDbContext context)
        {
            _context = context;
        }

        public IList<Artist> Artist { get;set; }

        public async Task OnGetAsync()
        {
            Artist = await _context.Artist.ToListAsync();
        }
    }
}
