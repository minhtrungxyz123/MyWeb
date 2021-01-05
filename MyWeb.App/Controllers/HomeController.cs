using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWeb.ApiIntegration;
using MyWeb.App.Models;
using MyWeb.Utilities.Constants;

namespace MyWeb.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISharedCultureLocalizer _loc;
        private readonly ISlideApiClient _slideApiClient;
        private readonly IProductApiClient _productApiClient;

        public HomeController(ILogger<HomeController> logger,
            ISlideApiClient slideApiClient,
            IProductApiClient productApiClient)
        {
            _logger = logger;
            _slideApiClient = slideApiClient;
            _productApiClient = productApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var culture = CultureInfo.CurrentCulture.Name;
            var viewModel = new HomeViewModel
            {
                Slides = await _slideApiClient.GetAll(),
                FeaturedProducts = await _productApiClient.GetFeaturedProducts(culture, SystemConstants.ProductSettings.NumberOfFeaturedProducts),
                LatestProducts= await _productApiClient.GetLatestProducts(culture, SystemConstants.ProductSettings.NumberOfLatestProducts),
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Tannhiet()
        {
            return View();
        }
        
        public IActionResult KhaySsd()
        {
            return View();
        }
        public IActionResult ViewSonic()
        {
            return View();
        }

        public IActionResult Dell()
        {
            return View();
        }
        public IActionResult TannhietColor()
        {
            return View();
        }

        public IActionResult Ed273a()
        {
            return View();
        }

        public IActionResult TaiNghe()
        {
            return View();
        }

        public IActionResult Macbook()
        {
            return View();
        }

        public IActionResult ManhinhDell()
        {
            return View();
        }

        public IActionResult PcAsus()
        {
            return View();
        }
        public IActionResult PcHNC()
        {
            return View();
        }
        public IActionResult Main()
        {
            return View();
        }

        public IActionResult LaptopMsi()
        {
            return View();
        }
        public IActionResult MacBookPro13()
        {
            return View();
        }
        public IActionResult LaptopGamingMsi()
        {
            return View();
        }
        public IActionResult PCENTHUSIAST()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult SetCultureCookie(string cltr, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cltr)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
        }
        public IActionResult ThongTinKhuyenMai()
        {
            return View();
        }
    }
}
