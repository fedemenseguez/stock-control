using System.Collections.Generic;
using LihueDev.StockControl.Models;
using LiteDB;

namespace LihueDev.StockControl.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : IModel
    {
        private const string _dbFile = @"C:\Temp\StockControl.db";

        public void Insert(T _entity)
        {
            using (var db = new LiteDatabase(_dbFile))
            {
                db.GetCollection<T>().Insert(_entity);
            }
        }

        public void Update(T _entity)
        {
            using (var db = new LiteDatabase(_dbFile))
            {
                db.GetCollection<T>().Update(_entity);
            }
        }

        public void Delete(T _entity)
        {
            using (var db = new LiteDatabase(_dbFile))
            {
                db.GetCollection<T>().Delete(_entity.Id);
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var db = new LiteDatabase(_dbFile))
            {
                return db.GetCollection<T>().FindAll();
            }
        }

        public T GetById(int _id)
        {
            using (var db = new LiteDatabase(_dbFile))
            {
                return db.GetCollection<T>().FindById(_id);
            }
        }
    }
}
