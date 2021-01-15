using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWeb.ViewModels.Catalog.Products
{
    public class ProductUpdateRequest
    {
        public int Id { set; get; }

        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
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

        [Required(ErrorMessage = "Bạn nhập thiếu!!")]
        [Display(Name = "Ảnh sản phẩm")]
        public IFormFile ThumbnailImage { get; set; }
    }
}
