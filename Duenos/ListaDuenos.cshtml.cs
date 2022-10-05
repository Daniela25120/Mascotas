using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ListaDuenosModel : PageModel
    {
        private readonly IRepositorioDueno _repoDuenos;

        public IEnumerable<Dueno> listaDuenos {get;set;}

        public ListaDuenosModel()
        {
            this._repoDuenos = new RepositorioDueno (new Persistencia.AppContext());
        }
        public void OnGet()
        {
            listaDuenos = _repoDuenos.GetAllDuenos();
        }
    }
}
