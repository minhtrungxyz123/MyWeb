using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWeb.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        [Required(ErrorMessage = "Bạn phải nhập giá sản phẩm")]
        [Display(Name = "giá khuyến mãi của sản phẩm")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập giá sản phẩm")]
        [Display(Name = "giá thị trường của sản phẩm")]
        public decimal OriginalPrice { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập số lượng tồn của sản phẩm")]
        [Display(Name = "Số lượng tồn")]
        public int Stock { get; set; }

        [Required(ErrorMessage ="Bạn phải nhập tên sản phẩm")]
        [Display(Name = "Tên sản phẩm")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Bạn thiếu miêu tả sản phẩm")]
        [Display(Name = "Miêu tả")]
        public string Description { set; get; }

        [Required(ErrorMessage = "Bạn thiếu chi tiết sản phẩm")]
        [Display(Name = "Chi tiết")]
        public string Details { set; get; }

        [Required(ErrorMessage = "Bạn nhập thiếu!!")]
        [Display(Name = "Thông tin bảo hành")]
        public string SeoDescription { set; get; }

        [Required(ErrorMessage = "Bạn nhập thiếu thiếu!!")]
        [Display(Name = "Dịch vụ đi kèm")]
        public string SeoTitle { set; get; }

        [Required(ErrorMessage = "Bạn nhập thiếu!!")]
        [Display(Name = "Khuyến mãi đi kèm")]
        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }
        public IFormFile ThumbnailImage { get; set; }
    }
}
