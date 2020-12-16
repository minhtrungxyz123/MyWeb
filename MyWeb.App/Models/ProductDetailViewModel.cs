using MyWeb.ViewModels.Catalog.Categories;
using MyWeb.ViewModels.Catalog.ProductImages;
using MyWeb.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.App.Models
{
    public class ProductDetailViewModel
    {
        public  CategoryViewModel Category { get; set; }
        public  ProductViewModel Product { get; set; }
        public List<ProductViewModel> RelatedProducts { get; set; }
        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}
