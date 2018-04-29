using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListBox.UI.Models.Task;

namespace ToDoListBox.UI.Models.CategoryToDoList
{
    public class CategoryToDoListWorkers
    {
        public List<CategoryToDoListUIModel> CategoryToDoList { get; set; }

        public List<TaskUIModel> Task { get; set; }
    }
}