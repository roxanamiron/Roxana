using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using ToDoListBox.Core.Models;
using ToDoListBox.Repository.Entity;

namespace ToDoListBox.Repository.Ports
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private string connectionString;
              
        public Repository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ToDoListBoxModels"].ConnectionString;
        }

        public bool Delete(int id)
        {

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var entity = connection.Get<T>(id);

                connection.Delete<T>(entity);

                connection.Close();

                return true;
            }

        }

        public List<T> GetAll()
        {
            
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var collection = connection.GetAll<T>();
                               
                connection.Close();

                return collection.ToList();
            }
        }
        
        public T GetById(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var entity = connection.Get<T>(id);

                connection.Close();

                return entity;
            }
        }
        public int Insert(T entity)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var id = connection.Insert<T>(entity);

                connection.Close();

                return Convert.ToInt32(id);
            }
        }

        public void Remove(TaskEntity entity)
        {
            throw new NotImplementedException();
        }

        public abstract void Remove(CategoryToDoListEntity category);

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                connection.Update<T>(entity);

                connection.Close();
            }
        }        
    }
}
