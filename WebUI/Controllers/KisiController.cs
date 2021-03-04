using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class KisiController : Controller
    {

        private readonly IKisiService k;
        public KisiController (IKisiService kisi)
        {
            k = kisi;
        }

        public async Task<IActionResult> Index()
        {
            var result = await k.GetAll();

            return View(result);
        }

        [HttpPost]
        public IActionResult Create(Kisi kisi)
        {
            k.Insert(kisi);
            return RedirectToAction("Index", "Kisi");
        }
        public IActionResult Yeni()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            var result = k.GetById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Update(Kisi kisi)
        {
            if (kisi == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                k.Update(kisi);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Delete(Kisi kisi)
        {
            if (kisi == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                k.Delete(kisi);
                return RedirectToAction("Index");
            }
        }

      
        public IActionResult Detay(int id)
        {
            var result = k.GetById(id);
            return View("Detay",result);
        }

       

    }
}
