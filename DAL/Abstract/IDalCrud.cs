using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IDalCrud<TEntity> : IDalRead<TEntity> where TEntity : IEntity
    {
        // Create
        int Insert(TEntity entity);

        // Update
        int UpdateByEntity(TEntity entity);

        int UpdateByFieldName(string fieldName, string text, string fieldCondition, string textCondition);

        // Delete
        int deleteById(long id);

        int deleteByFieldName(string fieldCondition, string textCondition);

        int delete(TEntity entity);

    }
}
