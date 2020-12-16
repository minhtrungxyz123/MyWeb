using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWeb.ViewModels.Catalog.Categories;
using MyWeb.ViewModels.Catalog.Products;
using MyWeb.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.App.Models
{
    public class ProductCategoryViewModel
    {
        public  CategoryViewModel Category { get; set; }
        public PagedResult<ProductViewModel> Products { get; set; }
    }
}
