using LihueDev.StockControl.Models;
using System.Collections.Generic;

namespace LihueDev.StockControl.Repositories
{
    public interface IRepository<T> where T : IModel
    {
        void Insert(T _entity);
        void Update(T _entity);
        void Delete(T _entity);
        T GetById(int _id);
        IEnumerable<T> GetAll();
    }
}
