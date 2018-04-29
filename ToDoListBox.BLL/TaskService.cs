using System;
using System.Collections.Generic;
using AutoMapper;
using ToDoListBox.BLL.Ports;
using ToDoListBox.Core.Models;
using ToDoListBox.Repository;
using ToDoListBox.Repository.Entity;

namespace ToDoListBox.BLL
{
    public class TaskService : ITaskService
    {
        #region Attributes
        private readonly TaskRepository _taskRepository;

        private IMapper Mapper { get; set; }

        #endregion Attributes

        #region Constructor

        public TaskService(TaskRepository taskRepository)
        {
            this._taskRepository = taskRepository;

            Mapper = SetMapperConfigs();
        }      

        #endregion Constructor

        #region PublicMethods
        public TaskEntity GetTaskById(int id)
        {
            var task = new TaskEntity();
            var taskEntity = this._taskRepository.GetById(id);

            task = Mapper.Map<TaskEntity>(taskEntity);

            return task;
        }

        public void SaveTask(Task task)
        {
            var _task = new TaskEntity();
            _task = Mapper.Map<TaskEntity>(task);
            this._taskRepository.InsertTask(_task);
        }     

        public void Save(TaskEntity task)
        {
            if (task.Id == 0)
            {
                this._taskRepository.Insert(task);
            }
            else
            {
                this._taskRepository.Update(task);
            }
        }

        public void Delete(int taskId)
        {
            var taskEntity = this._taskRepository.GetById(taskId);

            if (taskEntity != null)
            {
                this._taskRepository.Delete(taskId);
            }
        }
        #endregion PublicMethods

        #region PrivateMethods

        private static Core.Models.Task ConvertToEntity(TaskEntity entity)
        {
            var taskEntity = new Core.Models.Task
            {
                Id = entity.Id,
                ToDoListId = entity.ToDoListId,
                Name = entity.Name,
                Description = entity.Description,
                Priority = entity.Priority,
                Created = entity.Created,
                UpDated = entity.UpDated,
                DueDate = entity.UpDated,
                Completed = entity.Completed
            };

            return taskEntity;
        }
        private IMapper SetMapperConfigs()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Core.Models.Task, TaskEntity>();
                cfg.CreateMap<TaskEntity, Core.Models.Task>();
            });

            IMapper mapper = config.CreateMapper();

            return mapper;
        }

        Core.Models.Task ITaskService.GetTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetAllTask()
        {
            var taskList = new List<Task>();

            var taskEntityList = this._taskRepository.GetAll();

            if (taskEntityList != null)
            {
                taskEntityList.ForEach(tel => taskList.Add(ConvertToEntity(tel)));
            }

            return taskList;
        }

      
        private TaskEntity ConvertToModel(TaskEntity entity)
        {
            var taskListEntity = new TaskEntity();

            taskListEntity.Id = entity.Id;
            taskListEntity.Name = entity.Name;
            taskListEntity.Priority = entity.Priority;
            taskListEntity.ToDoListId = entity.ToDoListId;
            taskListEntity.UpDated = entity.UpDated;

            return taskListEntity;
        }        

        #endregion PrivateMethods
    }

}
