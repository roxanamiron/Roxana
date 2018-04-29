using ToDoListBox.Core.Models;
using System.Collections.Generic;

namespace ToDoListBox.BLL.Ports
{
    public interface ICategoryToDoList
    {
        List<ICategoryToDoList> GetCategoryToDoListList();

        void SaveCategory(CategoryToDoList category);

        void DeleteCategory(int id);
    }
}
