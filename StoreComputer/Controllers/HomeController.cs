﻿using StoreComputer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using PagedList;
using System.Web.UI;
using System.Collections.ObjectModel;

namespace StoreComputer.Controllers
{
    public class HomeController : Controller
    {
        StoreComputerEntities1 db = new StoreComputerEntities1();
        // GET: Home
        public ActionResult TrangChu()
        {
            StoreComputerEntities1 db = new StoreComputerEntities1();
            List<HangHoa> hangHoas = db.HangHoas.ToList();
            return View(hangHoas);
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
        public ActionResult Laptop()
        {
            return RedirectToAction("DanhSachLaptop", "Laptop");
        }
        
        public ActionResult LinhKien()
        {
            return RedirectToAction("DanhSachLinhKien","LinhKien");
        }
        public ActionResult TinTuc()
        {
            return View();
        }
        public ActionResult ThongTinLienHe()
        {
            return View();
        }
        // Tạo phiếu hỗ trợ khách hàng
        [HttpPost]
        public ActionResult ThongTinLienHe(TuVanKH tv)
        {
            db.TuVanKHs.Add(tv);
            try
            {
                db.SaveChanges();
                return Json(new { success = true });
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return Json(new {success = false});
            }
        }
        public ActionResult GuiPhieuHoTro()
        {
            return RedirectToAction("TrangChu");
        }
        public ActionResult DangNhap()
        {
            return View();
        }
    }
}