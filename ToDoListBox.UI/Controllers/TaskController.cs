using System;
using System.Collections.Generic;
using System.Linq;
using ToDoListBox.UI.Models.Task;
using System.Web.Mvc;
using ToDoListBox.BLL;
using ToDoListBox.Core.Models;
using ToDoListBox.BLL.Ports;
using System.Net;

namespace ToDoListBox.UI.Controllers
{
    public class TaskController : Controller
    {
        #region Attributes

        private readonly ITaskService _taskService;
        private readonly object tasks;
        #endregion Attributes

        #region Constructor

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        #endregion Constructor


        // GET: Task
        public ActionResult Index()
        {
            return View();
        } 

        public ActionResult ViewAll()
        {
            var taskList = new List<TaskViewModel>();

            taskList = ConvertToModel(_taskService.GetAllTask());

            return View("ViewAll", taskList);
        }
     

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task/Create
        [HttpPost]
       public ActionResult Create(ToDoListBox.UI.Models.Task.TaskUIModel task)
        {
            if(ModelState.IsValid)
            {
                Task _task = new Task();
                _task.Completed = task.Completed;
                _task.Created = task.Created;
                _task.Description = task.Description;
                _task.DueDate = task.DueDate;
                _task.Id = task.Id;
                _task.Name = task.TaskName;
                _task.Priority = task.Priority;
                _task.UpDated = task.Updated;
                _task.ToDoListId = task.ToDoListId;

                _taskService.SaveTask(_task);
                
                return RedirectToAction("ViewAll");
            }
            else
            {
                return View(task);
            }
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Task/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
          
            if(tasks == null)
            {
                return HttpNotFound();
            }
            return View(tasks);          
        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Task/Delete/5
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
        #region Private Method

        private static List<TaskViewModel> ConvertToModel(List<Task> bllList)
        {
            var taskList = new List<TaskViewModel>();

            foreach (var bllItem in bllList)
            {
                var taskItem = new TaskViewModel();

                taskItem.Id = bllItem.Id;
                taskItem.Name = bllItem.Name;
                taskItem.Description = bllItem.Description;
                
                taskList.Add(taskItem);
            }

            return taskList;
        }
        #endregion Private Method
    }
}
