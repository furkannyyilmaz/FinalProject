using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
                                            //generic Constraint = kısıt
                                            // class: referans tip
                                            // IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
                                            //new: newlenebilir olmalı.
    public interface IEntityRepository <T> where T : class, IEntity,new ()

    {
        List<T> GetAll(Expression<Func< T, bool>> filter= null);// bir kere yazılır.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

        // List<T> GetAllByCategory(int categoryId); >>>> ihtiyac kalmadi


    }
}
