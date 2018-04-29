using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListBox.UI.Models.Task
{
    public class TaskViewModel
    {
        public int Id { get; set; }
      
        public string Name { get; set; }

        public string Description { get; set; }

        public int Priority { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public DateTime DueDate { get; set; }

        public bool Completed { get; set; }
        
    }
}