using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, BookDbContext>, ICategoryDal
    {
        public Category Get(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
