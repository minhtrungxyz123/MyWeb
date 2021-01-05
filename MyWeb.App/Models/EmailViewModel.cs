using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.App.Models
{
    public class EmailViewModel
    {
        [Display(Name = "Gửi Đến")]
        public  string To { get; set; }

        [Display(Name = "Tên Người Gửi")]
        public  string Subject { get; set; }

        [Display(Name = "Ý Kiến Phản Hồi")]
        public  string Body { get; set; }

    }
}
