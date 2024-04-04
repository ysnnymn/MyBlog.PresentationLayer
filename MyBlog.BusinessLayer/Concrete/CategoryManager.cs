using FluentValidation;
using System;
using System.Collections.Generic;
using MyBlog.BusinessLayer.Abstract;
using MyBlog.EntitiyLayer.Concrete;
using MyProject.DataAccessLayer.Abstract;

namespace MyBlog.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
      //  private readonly CategoryValidator _validator;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
           // _validator = new CategoryValidator(); 
        }

        public void TDelete(int id)
        {
            
            _categoryDal.Delete(id);

        }

        public Category TGetById(int id)
        {
           return _categoryDal.GetById(c => c.CategoryId == id);
        }

        public List<Category> TGetListAll()
        {
            return _categoryDal.GetListAll();
        }

        public void TInsert(Category entity)
        {
            /*// Gelen entity'yi doğrula
            //var validationResult = _validator.Validate(entity);

            // Doğrulama başarısız ise
           // if (!validationResult.IsValid)
            {
                
                // Burda daha Güzel Bir Clean Code İçin Aspect Uygulanabilir İlerleyen zamanlara bıraktım
              
                return;
            }*/

            // Doğrulama başarılı ise, ekleme işlemini yapabilirsiniz
            _categoryDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
