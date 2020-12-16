using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWeb.ApiIntegration;
using MyWeb.App.Models;
using MyWeb.ViewModels.Catalog.Products;

namespace MyWeb.App.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;
        public ProductController(IProductApiClient productApiClient,
            ICategoryApiClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
            _productApiClient = productApiClient;
        }
        public async Task<IActionResult> Detail(int id, string culture)
        {
            var product = await _productApiClient.GetById(id, culture);
            return View(new ProductDetailViewModel() 
            {
              Product=product
            });
        }

        public async Task<IActionResult> Category(string keyword,int id, string culture, int page = 1)
        {
            var  products = await _productApiClient.GetPagings(new GetManageProductPagingRequest()
            {
                Keyword=keyword,
                CategoryId = id,
                PageIndex = page,
                LanguageId= culture,
                PageSize=9
            });
            return View(new ProductCategoryViewModel() 
            {
                Category=await _categoryApiClient.GetById(culture, id),
                Products=products
            });
        }
    }
}
