using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWeb.ViewModels.Feedback
{
   public class FeedbackViewmodel
    {
        public int ID { get; set; }
        [MaxLength(250,ErrorMessage ="Tên không được quá 250 ký tự")]
        [Required(ErrorMessage ="Tên phải nhập")]
        public string Name { get; set; }

        [MaxLength(250, ErrorMessage = "Tên không được quá 250 ký tự")]
        public string Email { get; set; }

        [MaxLength(500, ErrorMessage = "tin nhắn không quá 500 ký tự")]
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage ="phải nhập trạng thái")]
        public bool Status { get; set; }
    }
}
