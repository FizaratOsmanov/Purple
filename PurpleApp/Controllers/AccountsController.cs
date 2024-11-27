using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PurpleApp.DAL;
using PurpleApp.DTOs.UserDTOs;
using PurpleApp.Models;

namespace PurpleApp.Controllers
{
    public class AccountsController : Controller
    {

        private readonly AppDbContext _appDbContext;
        private readonly UserManager<AppUser> _userManager;
        public AccountsController(AppDbContext appDbContext, UserManager<AppUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;

        }


        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterAsync(CreateUserDto createUserDto)
        {

            if (!ModelState.IsValid)
            {
                return View(createUserDto);
            }

            AppUser user=new AppUser();
            user.FirstName= createUserDto.FirstName;
            user.LastName= createUserDto.LastName;
            user.Email= createUserDto.Email;
            user.UserName = createUserDto.Username;
            var result= await _userManager.CreateAsync(user,createUserDto.Password);
            if (result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    Console.WriteLine(item.Description);
                }
            JsonResult jsonResult = new JsonResult("User not created");
            return Json(jsonResult);

            }
            return RedirectToAction(nameof(Index),"Home");

;
        }
    }
}
