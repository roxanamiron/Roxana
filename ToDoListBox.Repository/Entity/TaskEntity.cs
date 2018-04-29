using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListBox.Repository.Entity
{
    [Table("dbo.Task")]
    public class TaskEntity
    {
        [Key]
        
        public int Id { get; set; }

        public int ToDoListId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Priority { get; set; }

        public DateTime Created { get; set; }

        public DateTime UpDated { get; set; }

        public DateTime DueDate { get; set; }

        public bool Completed { get; set; }

    }
}
