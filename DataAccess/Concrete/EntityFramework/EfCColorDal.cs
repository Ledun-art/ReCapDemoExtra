using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCColorDal : ICColorDal
    {
        public List<CColor> GetAll(Expression<Func<CColor, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<CColor>().ToList()
                    : context.Set<CColor>().Where(filter).ToList();
            }
        }

        public CColor Get(Expression<Func<CColor, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<CColor>().SingleOrDefault(filter);
            }
        }

        public void Add(CColor entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
            }
        }

        public void Update(CColor entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
            }
        }

        public void Delete(CColor entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
            }
        }
    }
}