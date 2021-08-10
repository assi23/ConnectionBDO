using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityBancoDeDados.Models;
using EntityBancoDeDados.Repository;

namespace EntityBancoDeDados.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games/Details/5
        GamesRepository repository;
		public GamesController()
		{
            repository = new GamesRepository();
        }
        public ActionResult Details(int id)
        {
            return View(repository.Read(id));
        }

        // GET: Games/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        [HttpPost]
        public ActionResult Create(Games model)
        {
            try
            {
                repository.Create(model);
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Games/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repository.Read(id));
        }

        // POST: Games/Edit/5
        [HttpPost]
        public ActionResult Edit(Games model)
        {
            try
            {
                repository.Update(model);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Games/Delete/5
        public ActionResult Delete(int id)
        {
            return View(repository.Read(id));
        }

        // POST: Games/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,Games model)
        {
            try
            {
                repository.Delete(id);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult List() 
        {
            return View(repository.Read());
        }
    }
}
