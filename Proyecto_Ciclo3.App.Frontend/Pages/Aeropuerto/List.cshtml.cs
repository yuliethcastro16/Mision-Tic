using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto_Ciclo3.App.Persistencia.AppRepositorios;
using Proyecto_Ciclo3.App.Dominio;
 
namespace Proyecto_Ciclo3.App.Frontend.Pages
{
    public class ListAeropuertoModel : PageModel
    {
       
        private readonly RepositorioAeropuertos repositorioAeropuertos;
        public IEnumerable<Aeropuertos> Aeropuertos {get;set;}
        [BindProperty]
        public Aeropuertos Aeropuerto {get;set;}
 
    public ListAeropuertoModel(RepositorioAeropuertos repositorioAeropuertos)
    {
        this.repositorioAeropuertos=repositorioAeropuertos;
     }
 
    public void OnGet()
    {
        Aeropuertos=repositorioAeropuertos.GetAll();
    }
     public IActionResult OnPost()
        {
            if(Aeropuerto.id>0)
            {
                 repositorioAeropuertos.Delete(Aeropuerto.id);
            }
            
            return RedirectToPage("./List");
        }
    

    }
    
}




