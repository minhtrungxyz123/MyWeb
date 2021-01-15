using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.App.Controllers
{
    public class AllController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DieukienvaDieukhoan()
        {
            return View();
        }
        public IActionResult Gioithieu()
        {
            return View();
        }
        public IActionResult Muatragop()
        {
            return View();
        }
        public IActionResult Chinhsachgiahang()
        {
            return View();
        }
        public IActionResult Chinhsachhangchinhhang()
        {
            return View();
        }
    }
}
