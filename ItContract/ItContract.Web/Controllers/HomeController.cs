using System.Web.Mvc;

namespace ItContract.Web.Controllers
{
    public class HomeController : ItContractControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}