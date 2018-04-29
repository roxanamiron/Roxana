using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListBox.UI.Models.UserToDos
{
    public class UserToDosViewModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ToDoId { get; set; }
    }
}