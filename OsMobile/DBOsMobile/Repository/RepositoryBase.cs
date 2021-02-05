using System;
using System.Collections.Generic;
using System.Data.Common;
using OsMobile.DBOsMobile.Interface;
using SQLite;

namespace OsMobile.DBOsMobile.Repository
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : new()
    {
        protected SQLiteConnection connect = DBConnection.Conexao();

        private static object lockObject = new object();
        private static object connectionObject = new object();

        public void Add(TEntity obj)
        {
            try
            {
                connect.Insert(obj);

            }
            catch (Exception e)
            {
                new Exception(e.Message);
            }
        }


        public List<TEntity> GetAll()
        {

            lock (connectionObject)
            {
                return connect.Table<TEntity>().ToList();
            }
        }

        public TEntity Get(int id)
        {

            lock (connectionObject)
            {
                return connect.Get<TEntity>(id);
            }
        }

        public void RemoveAll()
        {
            connect.DeleteAll<TEntity>();
        }

        public void Remove(TEntity obj)
        {
            connect.Delete<TEntity>(obj);
        }

        public void Update(TEntity obj)
        {
            lock (connectionObject)
            {
                connect.Update(obj);
            }
        }

        public void Dispose()
        {
            connect.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}



