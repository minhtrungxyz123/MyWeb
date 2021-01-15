using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebLapTop.Data.Entities
{
   public class Chitiet
    {
        public int Id { get; set; }
        public int IdBantin { get; set; }
        public  string Tieude { get; set; }
        public string Noidung { get; set; }
        public  int Lanxem { get; set; }
        public DateTime Ngaydang { get; set; }
        public  Bantin Bantin { get; set; }
           
   }
}
