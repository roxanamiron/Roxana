using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoListBox.UI.Models.CategoryToDoList
{
    public class CategoryToDoListUIModel
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select a Category Name")]        
        public string CategoryName { get; set; }

    }
}