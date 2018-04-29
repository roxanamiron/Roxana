using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListBox.Repository.Entity
{
    [Table("dbo.UserToDos")]
    public class UserToDosEntity
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        
        public int ToDoId { get; set; }

    }
}
