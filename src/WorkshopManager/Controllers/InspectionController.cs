using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WorkshopManager.Controllers
{
    public class InspectionController : Controller
    {
        // GET: InspectionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InspectionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InspectionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InspectionController/Create
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

        // GET: InspectionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InspectionController/Edit/5
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

        // GET: InspectionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InspectionController/Delete/5
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
