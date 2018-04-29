using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListBox.UI.Models.ToDoList
{
    public class ToDoListViewModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }
    }
}