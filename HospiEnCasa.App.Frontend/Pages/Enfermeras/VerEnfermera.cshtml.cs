using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Authorization;


namespace HospiEnCasa.App.Frontend.Pages
{   [Authorize]
    public class VerEnfermeraModel : PageModel
    {
        private static IRepositorioEnfermera _repositorioEnfermera = new RepositorioEnfermera(new HospiEnCasa.App.Persistencia.AppContext());
        [BindProperty]
        public Enfermera Enfermera{get; set; }
        public VerEnfermeraModel()
        {}
        public ActionResult OnGet(int id)
        {
            this.Enfermera = _repositorioEnfermera.GetEnfermera(id);
            return Page();
        }
    }
}
