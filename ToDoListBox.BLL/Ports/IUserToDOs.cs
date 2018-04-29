using System.Collections.Generic;
using ToDoListBox.Core.Models;
using ToDoListBox.Repository.Entity;

namespace ToDoListBox.BLL.Ports
{
    public interface IUserToDos
    {
        void Save(UserToDosEntity userToDosEntity);

        void Delete(UserToDosEntity userToDosEntity);

        List<UserToDos> GetUserToDosList();
    }
}
