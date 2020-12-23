using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyWebLapTop.Data.Entities
{
    [Table("Feedbacks")]
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(500)]
        public  string Message { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}
