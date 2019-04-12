using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA2_prep2.Data;
using CA2_prep2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CA2_prep2.Pages
{
    public class AppEntryModel : PageModel
    {
        [BindProperty]
        public Browncoat browncoat { get; set; }

        private readonly RebellionContext _db;

        public AppEntryModel(RebellionContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            else
            {
                _db.BrownCoats.Add(browncoat);
                await _db.SaveChangesAsync();
                return RedirectToPage("Confirmation", new {id = browncoat.ID });
            }
        }

        //public void OnGet()
        //{

        //}
    }
}