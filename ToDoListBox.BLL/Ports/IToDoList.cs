using System.Collections.Generic;
using ToDoListBox.Core.Models;
using ToDoListBox.Repository.Entity;

namespace ToDoListBox.BLL.Ports
{
    public interface IToDoList
    {
        void Save(ToDoListEntity toDoListEntity);

        void Delete(ToDoListEntity toDoListEntity);

        List<ToDoList> GetToDoList();
    }
}
