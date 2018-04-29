using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ToDoListBox.UI.Models.Task
{
    public class TaskUIModel
    {
        public int Id { get; set; }

        [Display(Name = "Task")]
        // [Range(1, int.MaxValue, ErrorMessage = "Please select a task")]
        public int ToDoListId { get; set; }

        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false , ErrorMessage = "Please provide a name")]
        [StringLength(50, ErrorMessage = "Lenght cannot exceed 50 characters")]
        public string TaskName { get; set; }

        [Display(Name = "Description")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a description")]
        [StringLength(150, ErrorMessage = "Lenght cannot exceed 150 characters")]
        public string Description { get; set; }

        [Display(Name = "Priority")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a priority")]
        public int Priority { get; set; }

        [Required(ErrorMessage = "Please provide a date!")]
        public DateTime Created { get; set; }

        [Required(ErrorMessage = "Please provide a date!")]
        public DateTime DueDate { get; set; }

        public DateTime Updated { get; set; }       

        public bool Completed { get; set; }
    }
}