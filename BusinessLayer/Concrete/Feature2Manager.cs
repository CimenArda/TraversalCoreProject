using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    internal class Feature2Manager : IFeature2Service
    {
        private readonly IFeature2Dal _Feature2Dal;

        public Feature2Manager(IFeature2Dal Feature2Dal)
        {
            _Feature2Dal = Feature2Dal;
        }

        public List<Feature2> TGetAllList()
        {
            return _Feature2Dal.GetAllList();
        }

        public Feature2 TGetById(int id)
        {
            return _Feature2Dal.GetById(id);
        }

        public void TInsert(Feature2 entity)
        {
            _Feature2Dal.Insert(entity);
        }

        public void TRemove(Feature2 entity)
        {
            _Feature2Dal.Remove(entity);
        }

        public void TUpdate(Feature2 entity)
        {
            _Feature2Dal.Update(entity);
        }
    }
}
