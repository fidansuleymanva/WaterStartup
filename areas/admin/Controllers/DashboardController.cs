
namespace WaterStartup.areas.admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
  
        public IActionResult Index()
        {
            return View();
        }
    }
}
