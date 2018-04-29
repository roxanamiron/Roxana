using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListBox.Repository.Entity;
using ToDoListBox.Repository.Ports;

namespace ToDoListBox.Repository
{
    public class TaskRepository : Repository<TaskEntity>
    {
        #region Constructor 

        public TaskRepository()
        {
            //_taskRepository = taskRepository;
        }
        #endregion Constructor

        public TaskEntity GetTaskById(int id)
        {
            return GetById(id);
        }

        public List<TaskEntity> GetAllTask()
        {
            return GetAll();
        }

        public int InsertTask(TaskEntity entity)
        {
            return Insert(entity);
        }

        public void UpdateTask(TaskEntity entity)
        {
            Update(entity);
        }

        public bool DeleteTask(TaskEntity entity)
        {
            return true;
        }

        public override void Remove(CategoryToDoListEntity category)
        {
            throw new NotImplementedException();
        }       
    }
}
