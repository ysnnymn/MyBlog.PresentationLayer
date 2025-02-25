using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlog.EntityLayer.Concrete;
using MyBlog.PresentationLayer.Areas.Writer.Models;

namespace MyBlog.PresentationLayer.Areas.Writer.Controllers;
[Area("Writer")]
[Route("Writer/Profile")]
public class ProfileController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public ProfileController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    // GETe
    [HttpGet]
    [Route("EditProfile")]
    public  async Task<IActionResult> EditProfile()
    {
        var values=await _userManager.FindByNameAsync(User.Identity.Name);
        UserEditViewModel model=new UserEditViewModel();
        model.Name = values.Name;
        model.Email = values.Email;
        model.SurName = values.Surname;
        model.Phonenumber=values.PhoneNumber;
        model.ImageUrl=values.ImageUrl;
        model.City=values.City;
        model.UserName=values.UserName;
        return View(model);
    }

    [HttpPost]
    [Route("EditProfile")]
    public async Task<IActionResult> EditProfile(UserEditViewModel p)
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);
        if (p.Image != null)
        {
            var resource = Directory.GetCurrentDirectory();
            var extensions=Path.GetExtension(p.Image.FileName);
            var imagename=Guid.NewGuid() + extensions;
            var savePath = resource + "/wwwroot/images/" + imagename;
            var stream = new FileStream(savePath, FileMode.Create);
            await p.Image.CopyToAsync(stream);
            user.ImageUrl = imagename;
        }
        user.Surname=p.SurName;
        user.Name=p.Name;
        user.Email=p.Email;
        user.PhoneNumber = p.Phonenumber;
        user.City=p.City;
        user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
        var result = await _userManager.UpdateAsync(user);
        if (result.Succeeded)
        {
            return RedirectToAction("MyBlogList","Blog",new{Area="Writer"});
            
        }
        return View();
    }
}