using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstASP.Controllers
{
    public class SubmitController : Controller
    {
        // GET: Submit
        public ActionResult Submit()
        {
            return View();
        }

        // GET: Submit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Submit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Submit/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Submit));
            }
            catch
            {
                return View();
            }
        }

        // GET: Submit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Submit/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Submit));
            }
            catch
            {
                return View();
            }
        }

        // GET: Submit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Submit/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Delete));
            }
            catch
            {
                return View();
            }
        }
    }
}