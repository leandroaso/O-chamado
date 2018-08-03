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
        public UsuarioDao Dao { get; set; }
        public IndexModel(UsuarioDao dao)
        {
            Dao = dao;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Usuario usuarioLogado { get; set; }

        public void OnPostAsync()
        {
            var user = Dao.Find(usuarioLogado);
            if (user !=null)
            {
                UsuarioLogado.Nome = user.Nome;
            }
        }
    }
}
