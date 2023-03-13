using _20_MvcCoreUtilidades.Models;
using Microsoft.AspNetCore.Mvc;

namespace _20_MvcCoreUtilidades.Controllers
{
    public class CochesController : Controller
    {
        private List<Coche> Cars;
        
        public CochesController()
        {
            this.Cars = new List<Coche>
            {
                new Coche
                {
                    IdCoche = 1, Marca = "Mazda", Modelo = "RX-8", Imagen = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdn.motor1.com%2Fimages%2Fmgl%2FjEA01%2Fs1%2F2012-353350-mazda-rx-8-blacknight-coupe-project1.jpg&f=1&nofb=1&ipt=3921351a989247a75f1282d2a9b953329dd301aee2c3afbe5834aef03123f82f&ipo=images"
                },
                new Coche
                {
                    IdCoche = 2, Marca = "Nissan", Modelo = "Skyline", Imagen = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2F2.bp.blogspot.com%2F-Uhbey2aBHKE%2FUptWUtY6FoI%2FAAAAAAAAItA%2FNcg05Z0iz7M%2Fs1600%2F2014-Nissan-skyline-R34-3-1024X768-Wallpaper.jpg&f=1&nofb=1&ipt=85efc141c77627eda21c71847eba124e935860245270c9ef63c13f28d458fb3f&ipo=images"
                },
                new Coche
                {
                    IdCoche = 3, Marca = "Toyota", Modelo = "Supra", Imagen = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fw-dog.ru%2Fwallpapers%2F0%2F11%2F347259610908269.jpg&f=1&nofb=1&ipt=51d06f00cbea3aabf4261506986356218adea2dcc5a81c8e704767c2193c69c6&ipo=images"
                },
                new Coche
                {
                    IdCoche = 4, Marca = "Ford", Modelo = "Mustang Shelby", Imagen = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.carscoops.com%2Fwp-content%2Fuploads%2F2019%2F09%2F3f2ff3ff-ford-mustang-shelby-gt500.jpg&f=1&nofb=1&ipt=cb8a2089c433f8f27cd64ce60f8b8c35c9e61bdf583fa9db0a5ff213455a878e&ipo=images"
                },
            };
        }

        public IActionResult Index()
        {
            return View();
        }

        //NECESITAMOS UNA PETICION PARA CADA VISTA ASINCRONA QUE VAMOS A UTILIZAR
        //LOS METODOS PUEDEN LLAMARSE COMO QUERMOS, ES DECIR, DIFERENTES A LOS NOMBRES DE LAS VISTAS QUE UTILIZAN
        public IActionResult _CochesPartial()
        {
            //SI VAMOS A UTILIZAR UNA VISTA PARCIAL CON AJAX DEVEMOS DEVOLVER PARTIALVIEW
            //DEBE TENER EL NOMBRE DE LA VISTA PARCIAL Y EL MODEL SI LO NECESITAMOS
            return PartialView("_CochesPartial", this.Cars);
        }


        //SI ESTAMOS UTIILIZANDO PARTIAL VIEW, SOLAMENTE PODEMOS RECIBIR PRIMITIVOS
        public IActionResult _DetailsCoches(int idCoche)
        {
            Coche car = this.Cars.FirstOrDefault(x => x.IdCoche == idCoche);
            return PartialView("_DetailsCoches", car);
        }
    }
}
