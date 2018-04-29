using ToDoListBox.Core.Models;
using System.Collections.Generic;
using ToDoListBox.Repository.Entity;

namespace ToDoListBox.BLL.Ports
{
    public interface ITaskService
    {
        Task GetTaskById(int id);

        List<Task> GetAllTask();

        void Save(TaskEntity task);

        void SaveTask(Task task);

        void Delete(int taskId);
    }
}
