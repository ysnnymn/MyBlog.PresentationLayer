using MyBlog.BusinessLayer.Abstract;
using MyBlog.BusinessLayer.ValidationRules.CategoryValidation;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Concrete;

public class CategoryManager:ICategoryService
{
    private ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void TInsert(Category entity)
    {
       _categoryDal.Insert(entity);
    }

    public void TUpdate(Category entity)
    {
        _categoryDal.Update(entity);
    }

    public void TDelete(int id)
    {
        _categoryDal.Delete(id);
    }

    public Category TGetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public List<Category> TGetListAll()
    {
        return _categoryDal.GetListAll();
    }
}