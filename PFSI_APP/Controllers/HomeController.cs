using PFSI_APP.Models;
using System.Web.Mvc;

namespace PFSI_APP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            var UserModel = new PFSIModel();
            return View(UserModel);
        }
    }
}