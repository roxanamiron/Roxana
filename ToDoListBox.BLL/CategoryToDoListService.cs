using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListBox.BLL.Ports;
using ToDoListBox.Core.Models;
using ToDoListBox.Repository;
using ToDoListBox.Repository.Entity;

namespace ToDoListBox.BLL
{
    public class CategoryToDoListService : ICategoryToDoList
    {
        #region Attributes
        private readonly CategoryToDoListRepository _categoryToDoListRepository = null;
        #endregion Attributes

        #region Constructor
        public CategoryToDoListService(CategoryToDoListRepository categoryToDoListRepository)
        {
            _categoryToDoListRepository = categoryToDoListRepository;
        }
       #endregion Constructor

        #region PublicMethods

        
        public CategoryToDoListEntity GetCategoryToDoList(int id)
        {
            var categoryToDoListEntity = new CategoryToDoListEntity();

            var categoryToDoList = this._categoryToDoListRepository.GetById(id);

            categoryToDoListEntity = ConvertToModel(categoryToDoListEntity);

            return categoryToDoListEntity;
        }

        

        public List<CategoryToDoListEntity> GetAllTasks()
        {
            var categoryToDoList = new List<CategoryToDoListEntity>();

            var categoryToDoListEntityList = this._categoryToDoListRepository.GetAll();

            if (categoryToDoListEntityList != null)
            {
                categoryToDoListEntityList.ForEach(tel => categoryToDoList.Add(ConvertToModel(tel)));
            }

            return categoryToDoList;
        }

        public List<CategoryToDoListEntity> GetAllCategory()
        {
             return this._categoryToDoListRepository.GetAllCategory();
        }     

       public void DeleteCategory(int id)
    {
        if (id == 0)
        {
            throw new Exception("Select a category to delete");
        }
        var category = this._categoryToDoListRepository.GetById(id);
        var categoryid = category.Id;

            this._categoryToDoListRepository.Delete(category);
    }

        public List<ICategoryToDoList> GetCategoryToDoListList()
        {
            var categoryToDoList = new List<ICategoryToDoList>();
            var categoryToDoEntityList = this._categoryToDoListRepository.GetAll();

            categoryToDoList = Mapper.Map<List<ICategoryToDoList>>(categoryToDoEntityList);

            return categoryToDoList;
        }

        public void SaveCategory(CategoryToDoList category)
        {
            var categ = Mapper.Map<CategoryToDoListEntity>(category);

            if (categ.Id == 0)
            {
                this._categoryToDoListRepository.Insert(categ);
            }
            else
            {
                this._categoryToDoListRepository.Update(categ);
            }
        }
        #endregion PublicMethods       

        private CategoryToDoListEntity ConvertToModel(CategoryToDoListEntity entity)
        {
            var categoryToDoListEntity = new CategoryToDoListEntity();

            categoryToDoListEntity.Id = entity.Id;
            categoryToDoListEntity.Name = entity.Name;


            return categoryToDoListEntity;
        }
    }
}
