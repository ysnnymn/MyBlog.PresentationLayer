using Microsoft.AspNetCore.Mvc;
using MyBlog.BusinessLayer.Abstract;

namespace MyBlog.PresentationLayer.ViewComponents.DefaultViewComponents;

public class _CategoryComponentPartial:ViewComponent
{
    private readonly ICategoryService _categoryService;

    public _CategoryComponentPartial(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _categoryService.TGetListAll();
        return View(result);  
    }
    
}