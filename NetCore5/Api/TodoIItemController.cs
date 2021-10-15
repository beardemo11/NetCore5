using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCore5.Models;

namespace NetCore5.Api
{
    public class TodoIItemController : Controller
    {
        private readonly TodoContext _db;

        public TodoIItemController(TodoContext context)
        {
            _db = context;
        }


        // GET: TodoIItemController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TodoIItemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TodoIItemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TodoIItemController/Create
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

        // GET: TodoIItemController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TodoIItemController/Edit/5
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

        // GET: TodoIItemController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TodoIItemController/Delete/5
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
