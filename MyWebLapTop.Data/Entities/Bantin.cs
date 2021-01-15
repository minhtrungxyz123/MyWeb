using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebLapTop.Data.Entities
{
   public class Bantin
    {
        public int Id { get; set; }
        public  string Noidung { get; set; }
        public List<Chitiet> Chitiets { get; set; }
    }
}
