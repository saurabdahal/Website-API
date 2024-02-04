using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Website_API.Controllers
{
    public class BirthplaceController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
