using Microsoft.AspNetCore.Mvc;
using MyBlog.BusinessLayer.Abstract;

namespace MyBlog.PresentationLayer.ViewComponents.DefaultViewComponents;

public class _SocialMediaComponentPartial:ViewComponent
{
    ISocialMediaService _socialMediaService;

    public _SocialMediaComponentPartial(ISocialMediaService socialMediaService)
    {
        _socialMediaService = socialMediaService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _socialMediaService.TGetListAll();
        return View(result);
    }
}