﻿using DAL.Concrete;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL.Abstract
{
    public abstract class ADalCrud<TEntity> : ADalRead<TEntity>, IDalCrud<TEntity> where TEntity : IEntity //, new()
    {
        private const string TABLE_ID = "id";

        public ADalCrud() : base()
        {
            InitCrudQueries();
        }
        // Додаємо в словник crud операції
        private void InitCrudQueries()
        {
            sqlQueries.Add(ESqlQueries.INSERT, "INSERT INTO " + GetTableName() + " ({0}) VALUES({1});");
            sqlQueries.Add(ESqlQueries.UPDATE_BY_ID, "UPDATE " + GetTableName() + " SET {0} WHERE "+ GetTableIdName()+"id = {1};");
            sqlQueries.Add(ESqlQueries.UPDATE_BY_FIELD, "UPDATE " + GetTableName() + " SET {0} = '{1}' WHERE {2} = '{3}';");
            sqlQueries.Add(ESqlQueries.DELETE_BY_ID, "DELETE FROM " + GetTableName() + " WHERE "+ GetTableIdName()+"id = {0};");
            sqlQueries.Add(ESqlQueries.DELETE_BY_FIELD, "DELETE FROM " + GetTableName() + " WHERE {0} = '{1}';");
        }

        // TODO Use Enum
        protected abstract IDictionary<string, string> GetValues(TEntity entity);

        // Execute Query
        private int ExecuteQuery(string query, ESqlQueries sqlQueries)
        {
            int result = 0;
            SqlConnection connection = null;
            SqlCommand command = null;
            if (query == null)
            {
                throw new Exception(string.Format(QUERY_NOT_FOUND, Enum.GetName(typeof(ESqlQueries), sqlQueries)));
            }
            try
            {
                connection = ConnectionManager.Get().GetConnection();
                command = new SqlCommand(query, connection);
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(DATABASE_READING_ERROR, e);
            }
            finally
            {
                if ((connection != null) && (connection.State == System.Data.ConnectionState.Open))
                {
                    connection.Close();
                }
            }
            return result;
        }

        // Create
        public int Insert(TEntity entity)
        {
            string insertFields = string.Empty;
            string insertValues = string.Empty;
            IDictionary<string, string> entityValues = GetValues(entity);
            entityValues.Remove(TABLE_ID);
            foreach (KeyValuePair<string, string> kvp in entityValues)
            {
                if (insertValues.Length > 0)
                {
                    insertFields = insertFields + ", ";
                    insertValues = insertValues + ", ";
                }
                insertFields = insertFields + $"{kvp.Key}";
                insertValues = insertValues + $"'{kvp.Value}'";
            }
            string query = string.Format(
                sqlQueries[ESqlQueries.INSERT], insertFields, insertValues);
            return ExecuteQuery(query, ESqlQueries.INSERT);
        }

        // Update
        public int UpdateByEntity(TEntity entity)
        {
            string updateValues = string.Empty;
            IDictionary<string, string> entityValues = GetValues(entity);
            entityValues.Remove(TABLE_ID);
            foreach (KeyValuePair<string, string> kvp in entityValues)
            {
                if (updateValues.Length > 0)
                {
                    updateValues = updateValues + ", ";
                }
                updateValues = updateValues + $"{kvp.Key} = '{kvp.Value}'";
            }
            string query = string.Format(
                sqlQueries[ESqlQueries.UPDATE_BY_ID], updateValues, entity.Id);
            Console.WriteLine("\t*** query = " + query);
            return ExecuteQuery(query, ESqlQueries.UPDATE_BY_ID);
        }

        public int UpdateByFieldName(string fieldName, string text, string fieldCondition, string textCondition)
        {
            string query = string.Format(
                sqlQueries[ESqlQueries.UPDATE_BY_FIELD],
                fieldName, text, fieldCondition, textCondition);
            return ExecuteQuery(query, ESqlQueries.UPDATE_BY_FIELD);
        }

        // Delete
        public int deleteById(long id)
        {
            string query = string.Format(
                sqlQueries[ESqlQueries.DELETE_BY_ID], id);
            return ExecuteQuery(query, ESqlQueries.DELETE_BY_ID);
        }

        public int deleteByFieldName(string fieldCondition, string textCondition)
        {
            string query = string.Format(
                sqlQueries[ESqlQueries.DELETE_BY_FIELD],
                fieldCondition, textCondition);
            return ExecuteQuery(query, ESqlQueries.DELETE_BY_FIELD);
        }

        public int delete(TEntity entity)
        {
            return deleteById(entity.Id);
        }
    }
}
