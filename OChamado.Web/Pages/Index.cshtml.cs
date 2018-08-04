using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OChamado.API.DAO;
using OChamado.API.Models;

namespace OChamado.Web.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }

        public void OnPostAsync(Usuario Usuario)
        {
        }
    }
}
