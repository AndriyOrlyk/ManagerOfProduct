using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IDalRead<TEntity> where TEntity : IEntity
    {
        // Read
        TEntity GetById(long id);

        IList<TEntity> GetByFieldName(string fieldName, string text);

        IList<TEntity> GetAll();

    }
}
