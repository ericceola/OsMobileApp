using System;
using System.Collections.Generic;

namespace OsMobile.DBOsMobile.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : new()
    {


        void Add(TEntity obj);

        List<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();

    }
}
