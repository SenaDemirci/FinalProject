using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal; //constructor injection

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodları
            return _categoryDal.GetAll();
        }

        //Select * from Categories where CategoryId=3
        Category ICategoryService.GetById(int categoryId)
        {
            return _categoryDal.GetById(c => c.CategoryId == categoryId);
        }
    }
}
