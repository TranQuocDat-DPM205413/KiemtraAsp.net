using AutoMapper;
using Infrastructure.Entities;
using Infrastructure.Entitites;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Demo.Models;

namespace Demo.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly ISinhVienService sinhvienService;
        private readonly IMapper mapper;

        public SinhVienController(ISinhVienService sinhvienService, IMapper mapper)
        {
            this.sinhvienService = sinhvienService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(sinhvienService.GetSinhViens());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            SinhVienViewModel data = new SinhVienViewModel();
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI SINH VIÊN" : "CẬP NHẬT THÔNG TIN SINH VIÊN";

            if (id != 0)
            {
                SinhVien res = sinhvienService.GetSinhVien(id);
                data = mapper.Map<SinhVienViewModel>(res);
                if (data == null)
                {
                    return NotFound();
                }
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, SinhVienViewModel data)
        {
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI SINH VIÊN" : "CẬP NHẬT THÔNG TIN SINH VIÊN";

            if (ModelState.IsValid)
            {
                try
                {
                    SinhVien res = mapper.Map<SinhVien>(data);
                    if (id != 0)
                    {
                        sinhvienService.UpdateSinhVien(res);
                    }
                    else
                    {
                        sinhvienService.InsertSinhVien(res);
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction("Index", "SinhVien");
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            SinhVien res = sinhvienService.GetSinhVien(id);
            sinhvienService.DeleteSinhVien(res);

            return RedirectToAction("Index", "SinhVien");
        }
    }
}
