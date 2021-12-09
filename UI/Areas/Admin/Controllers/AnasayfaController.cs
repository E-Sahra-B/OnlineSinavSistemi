using Microsoft.AspNetCore.Mvc;
using UI.Areas.Admin.Controllers;

namespace OnlineSinavUI.Areas.Admin.Controllers
{
    public class AnasayfaController : AdminBaseController
    {
      
        public IActionResult Index()
        {
            return View();
        }
    }
}