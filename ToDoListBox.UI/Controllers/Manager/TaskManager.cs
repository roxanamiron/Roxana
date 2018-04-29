using System.Collections.Generic;
using ToDoListBox.BLL.Ports;
using ToDoListBox.Core.Models;
using ToDoListBox.Repository.Entity;
using ToDoListBox.UI.Models.Task;

namespace ToDoListBox.UI.Controllers.Manager
{
    public class TaskManager
    {
        #region Attributes

        private readonly ITaskService _taskService;       

        #endregion Attributes

        #region Constructor

        public TaskManager(ITaskService taskService)
        {
            _taskService = taskService;
          
        }

        #endregion Constructor

        #region Public Methods

        public List<Models.Task.TaskViewModel> ViewAllTask()
        {
            var taskList = new List<Models.Task.TaskViewModel>();
            var taskListService = _taskService.GetAllTask();
         
            return taskList;
        }
      
        public void SaveTask(Models.Task.TaskUIModel taskModel)
        {
            var task = new TaskEntity(); 

            _taskService.Save(task);
        }
              
        #endregion Public Methods        
    }
}
  
