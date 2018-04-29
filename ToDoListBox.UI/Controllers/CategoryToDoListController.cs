using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListBox.BLL;
using ToDoListBox.BLL.Ports;
using ToDoListBox.Core.Models;
using ToDoListBox.UI.Models.CategoryToDoList;

namespace ToDoListBox.UI.Controllers
{
    public class CategoryToDoListController : Controller

      {
        #region Attributes

        private readonly ICategoryToDoList _categoryToDoList = null;

        #endregion Attributes

        #region Constructor

        public CategoryToDoListController(ICategoryToDoList categoryToDoList)
        {
           this._categoryToDoList = categoryToDoList;
        }

        #endregion Constructor

        // GET: CategoryToDoList
        public ActionResult Index()
        {
            return View();
        }

       
        // GET: CategoryToDoList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryToDoList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryToDoList/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: CategoryToDoList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryToDoList/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: CategoryToDoList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryToDoList/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
