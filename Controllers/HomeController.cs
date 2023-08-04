using Microsoft.AspNetCore.Mvc;
using WaterStartup.Model;
using WaterStartup.ViewModel;

namespace WaterStartup.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;

        public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;

        }


        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                ocean_Themes =_dataContext.ocean_Themes.ToList(),
            };
            return View(homeViewModel);
           
        }

       
    }
}