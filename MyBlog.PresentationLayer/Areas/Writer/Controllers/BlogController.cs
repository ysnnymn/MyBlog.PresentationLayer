using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlog.BusinessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.PresentationLayer.Areas.Writer.Controllers;

[Area("Writer")]  
public class BlogController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IArticleService _articleService;
    private readonly ICategoryService _categoryService;
    // GET


    public BlogController(UserManager<AppUser> userManager, IArticleService articleService, ICategoryService categoryService)
    {
        _userManager = userManager;
        _articleService = articleService;
        _categoryService = categoryService;
    }

    public async Task<IActionResult> MyBlogList()
    {
        var user =  await _userManager.FindByNameAsync(User.Identity.Name);
        var values = _articleService.TGetArticlesWithCategoryByWriter(user.Id);
        return View(values);
    }

    public IActionResult DeleteBlog(int id)
    {
        _articleService.TDelete(id);
        return RedirectToAction("MyBlogList");
    }
[HttpGet]
    public IActionResult UpdateBlog(int id)
    {
        List<SelectListItem> values = (from x in _categoryService.TGetListAll()
            select new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()

            }).ToList();
        ViewBag.v=values;
        var values2 = _articleService.TGetById(id);
        
        return View(values2);
        
    }

    [HttpPost]
    public IActionResult UpdateBlog(Article article)
    {
        _articleService.TUpdate(article);
        return RedirectToAction("MyBlogList");
    }

    [HttpGet]
    public IActionResult CreateBlog()
    {
        List<SelectListItem> values = (from x in _categoryService.TGetListAll()
            select new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()

            }).ToList();
            ViewBag.v=values;
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateBlog(Article article)
    {
        var user=await _userManager.FindByNameAsync(User.Identity.Name);
        article.CreatedDate = DateTime.Now;
   article.AppUserId = user.Id;
        
        _articleService.TInsert(article);
        return RedirectToAction("MyBlogList");
    }
}