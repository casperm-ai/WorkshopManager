using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WorkshopManager.Controllers
{
    public class JobcardController : Controller
    {
        // GET: JobcardController
        public ActionResult Index()
        {
            return View();
        }

        // GET: JobcardController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JobcardController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobcardController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobcardController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JobcardController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobcardController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JobcardController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
