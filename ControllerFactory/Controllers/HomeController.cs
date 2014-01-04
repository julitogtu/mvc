using System.Web.Mvc;

namespace ControllerFactory.Controllers
{
    public class HomeController : Controller
    {
        private string username = string.Empty;
        public HomeController(string username)
        {
            this.username = username;
        }
    }
}