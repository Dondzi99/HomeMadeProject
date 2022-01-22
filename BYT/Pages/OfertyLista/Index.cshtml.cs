using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BYT.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BYT.Pages.OfertyLista
{
    public class IndexModel : PageModel
    {
        //private readonly ApplicationDbContext _DB;


        //ApplicationDbContext DB
        public IndexModel()
        {
           // _DB = DB;
        }

        //public IEnumerable<Oferta> OfertyLista { get; set; } 

        public async Task OnGet()
        {
            //OfertyLista = await _DB.Oferta.ToListAsync();
        }
    }
}
