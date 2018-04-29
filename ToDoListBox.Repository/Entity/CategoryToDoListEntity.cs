using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListBox.Repository.Entity
{
    [Table("dbo.CategoryToDoList")]
    public class CategoryToDoListEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        
    }
}
