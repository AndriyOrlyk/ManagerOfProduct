using DAL.Concrete;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.Abstract
{
    public abstract class ADalRead<TEntity> : IDalRead<TEntity> where TEntity : IEntity 
    {
        protected const string QUERY_NOT_FOUND = "Query not found {0}";
        protected const string EMPTY_DATA_READER = "Empty DataReader by Query {0}";
        protected const string DATABASE_READING_ERROR = "Database Reading Error";
        
        protected IDictionary<ESqlQueries, string> sqlQueries;

        public ADalRead()
        {
            sqlQueries = new Dictionary<ESqlQueries, string>();
            InitReadQueries();
        }
        
        private void InitReadQueries()
        {
            sqlQueries.Add(ESqlQueries.GET_BY_ID, "SELECT * FROM " + GetTableName() + " WHERE " + GetTableIdName() +"id = {0};"); 
            sqlQueries.Add(ESqlQueries.GET_BY_FIELD, "SELECT * FROM " + GetTableName() + " WHERE {0} = '{1}';");
            sqlQueries.Add(ESqlQueries.GET_ALL, "SELECT * FROM " + GetTableName() + ";");
        }


        protected abstract string GetTableIdName();
        protected abstract string GetTableName();

        protected abstract TEntity CreateInstance(ICollection<string> args);

        // Read
        private IList<TEntity> GetQueryResult(string query, ESqlQueries sqlQueries)
        {
            IList<TEntity> all = new List<TEntity>();
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            IList<string> queryResult;
            if (query == null)
            {
                throw new Exception(string.Format(QUERY_NOT_FOUND, Enum.GetName(typeof(ESqlQueries), sqlQueries)));
            }
            try
            {
                connection = ConnectionManager.Get().GetConnection();
                command = new SqlCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    queryResult = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        queryResult.Add(reader[i].ToString());
                    }
                    all.Add(CreateInstance(queryResult));
                }

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
            if (all.Count == 0)
            {
                throw new Exception(string.Format(EMPTY_DATA_READER, query));
            }
            return all;
        }

        public TEntity GetById(long id)
        {
            return GetQueryResult(string.Format(
                sqlQueries[ESqlQueries.GET_BY_ID], id.ToString()),
                ESqlQueries.GET_BY_ID).First();
        }

        public IList<TEntity> GetByFieldName(string fieldName, string text)
        {
            return GetQueryResult(string.Format(
                sqlQueries[ESqlQueries.GET_BY_FIELD], fieldName, text),
                ESqlQueries.GET_BY_FIELD);
        }

        public IList<TEntity> GetAll()
        {
            return GetQueryResult(
                sqlQueries[ESqlQueries.GET_ALL],
                ESqlQueries.GET_ALL);
        }
    }
}
