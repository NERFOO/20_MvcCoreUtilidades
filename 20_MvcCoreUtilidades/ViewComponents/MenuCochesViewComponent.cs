using _20_MvcCoreUtilidades.Models;
using _20_MvcCoreUtilidades.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _20_MvcCoreUtilidades.ViewComponents
{
    public class MenuCochesViewComponent : ViewComponent
    {
        //POR SUPUESTO PODEMOS UTILIZAR INYECCION
        private RepositoryCoches repo;

        public MenuCochesViewComponent(RepositoryCoches repo)
        {
            this.repo = repo;
        }

        //AQUI PODRIAMOS TENER CUALQUIER METODO DE UNA CLASE, PERO LA PETICION SE REALIZA MEDIANTE EL METODO INVOKEASYNC, ES OBLIGATORIO TENERLO
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Coche> coches = this.repo.GetCoches();
            return View(coches);
        }
    }
}
