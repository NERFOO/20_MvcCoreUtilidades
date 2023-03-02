using _20_MvcCoreUtilidades.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace _20_MvcCoreUtilidades.Controllers
{
    public class UploadFilesController : Controller
    {

        private HelperPathProvider helperPath;

        public UploadFilesController(HelperPathProvider helperPath)
        {
            this.helperPath = helperPath;
        }

        public IActionResult SubirFichero()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SubirFichero(IFormFile fichero)
        {
            string fileName = fichero.FileName;

            string path = this.helperPath.MapPath(fileName, Folders.Uploads);

            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                await fichero.CopyToAsync(stream);
            }

            ViewData["MENSAJE"] = "Fichero subido a " + path;
            ViewData["URL"] = "<a href=''>Mi fichero</a>";

            return View();
        }
    }
}
