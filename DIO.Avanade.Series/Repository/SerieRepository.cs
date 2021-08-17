using DIO.Avanade.Series.App.Model;
using DIO.Avanade.Series.App.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DIO.Avanade.Series.App.Repository
{
    public class SerieRepository : IBaseRepository<Serie>
    {
        private List<Serie> seriesList = new();
        public List<Serie> DataList()
        {
            return seriesList;
        }

        public void Insert(Serie entity)
        {
            seriesList.Add(entity);
        }

        public void Remove(int id)
        {
            seriesList[id].Exclude();
        }

        public Serie SearchById(int id)
        {
            return seriesList[id];
        }

        public int SetId()
        {
            return seriesList.Count();
        }

        public void Update(int id, Serie entity)
        {
            seriesList[id] = entity;
        }
    }
}
