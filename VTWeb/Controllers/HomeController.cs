using System.Web.Mvc;
using VTLib;
using VTWebFW.Models.Home;

namespace VTWebFW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vtMaker = new VTMaker();

            var vt = vtMaker.GetVT();

            var viewModel = new IndexViewModel
            {
                VT = vt,
            };

            return View(viewModel);
        }
    }
}