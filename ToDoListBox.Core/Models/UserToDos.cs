using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListBox.Core.Models
{
   public class UserToDos
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ToDoId { get; set; }
    }
}
