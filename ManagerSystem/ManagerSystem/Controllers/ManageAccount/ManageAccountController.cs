using ManagerSystem.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManagerSystem.Controllers.ManageAccount
{
    public class ManageAccountController : Controller
    {
        public DBManagerReposity dbManager = new DBManagerReposity();
        //
        // GET: /ManageAccount/

        public ActionResult Managers()
        {
            IQueryable<Manager> allManagers = dbManager.GetAllManagers();
            return View(allManagers);
        }

        //
        // GET: /ManageAccount/Details/5

        public ActionResult ManagerDetails(int id)
        {
            return View();
        }

        //
        // GET: /ManageAccount/Create

        public ActionResult AddManager()
        {
            return View();
        }

        //
        // POST: /ManageAccount/Create

        [HttpPost]
        public ActionResult AddManager(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ManageAccount/Edit/5

        public ActionResult EditManager(int id)
        {
            return View();
        }

        //
        // POST: /ManageAccount/Edit/5

        [HttpPost]
        public ActionResult EditManager(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ManageAccount/Delete/5

        public ActionResult DeleteManager(int id)
        {
            return View();
        }

        //
        // POST: /ManageAccount/Delete/5

        [HttpPost]
        public ActionResult DeleteManager(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
