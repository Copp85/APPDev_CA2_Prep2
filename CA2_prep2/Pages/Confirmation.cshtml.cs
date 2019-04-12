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
    public class ConfirmationModel : PageModel
    {
        private readonly RebellionContext _db;

        public ConfirmationModel(RebellionContext db)
        {
            _db = db;
        }

        public Browncoat browncoat { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            browncoat = await _db.BrownCoats.FindAsync(id);

            if (browncoat == null)
            {
                return NotFound();
            }
            return Page();
        }

        //public void OnGet()
        //{

        //}
    }
}