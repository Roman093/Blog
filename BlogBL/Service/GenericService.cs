using BlogBL.Interface;
using BlogDAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogBL.Service
{
    public abstract class GenericService<BLModel, DModel> : IGenereicService<BLModel> 
        where BLModel : class
        where DModel : class
    {
        private readonly IRepository<DModel> _repository;
        public GenericService(IRepository<DModel> repository)
        {
            _repository = repository;
        }
        public virtual BLModel Find(Func<Article, Boolean> predicate)
        {
            var entity = _repository.Find(predicate);
            return Map(entity);
        }
        public IEnumerable<BLModel> GetAll()
        {
            var listEntity = _repository.Get();
            return Map(listEntity);
        }
        public abstract BLModel Map(DModel entity);
        public abstract DModel Map(BLModel blmodel);

        public abstract IEnumerable<BLModel> Map(IList<DModel> entity);
        public abstract IEnumerable<DModel> Map(IList<BLModel> entity);
    }
}
