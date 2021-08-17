using System.Collections.Generic;

namespace DIO.Avanade.Series.App.Repository.Interfaces
{
    public interface IBaseRepository<T>
    {
        List<T> DataList();
        void Insert(T entity);
        void Remove(int id);
        void Update(int id, T entity);
        int SetId();
        T SearchById(int id); 
    }
}
