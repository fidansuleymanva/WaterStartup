
namespace WaterStartup.areas.admin.Controllers
{
    [Area("Admin")]
    public class OceanthemeController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IWebHostEnvironment _env;

        public OceanthemeController(DataContext dataContext, IWebHostEnvironment env)
        {
            _dataContext = dataContext;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            var query = _dataContext.ocean_Themes.AsQueryable();
            var PaginationList = PaginationList<Ocean_theme>.Create(query, 3, page);
            return View(PaginationList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Ocean_theme ocean_Theme)
        {
            if (!ModelState.IsValid) return View();
            _dataContext.Add(ocean_Theme);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Ocean_theme ocean_Theme = _dataContext.ocean_Themes.FirstOrDefault(x => x.Id == id);
            if (ocean_Theme == null) return View();
            return View(ocean_Theme);
        }
        [HttpPost]
        public IActionResult Update(Ocean_theme ocean_Theme)
        {
            if (ocean_Theme is null) return View();

            Ocean_theme exsistocean_Theme = _dataContext.ocean_Themes.FirstOrDefault(x => x.Id == ocean_Theme.Id);
            if (exsistocean_Theme == null) return View();
            if (!ModelState.IsValid) return View(exsistocean_Theme);

            exsistocean_Theme.Title = ocean_Theme.Title;
            exsistocean_Theme.Description = ocean_Theme.Description;
            exsistocean_Theme.URL = ocean_Theme.URL;
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
