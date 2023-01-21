using Microsoft.AspNetCore.Mvc;
using LoginPage.Models;
namespace LoginPage.Controllers
{
    public class LoginController1 : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public List<UserModel> Putvalue()
        {
            var user = new List<UserModel>()
            {
             new UserModel(1,"xyz","okay"),
             new UserModel(2,"lmn","okay1"),
             new UserModel(3,"opq","1234")

            };
        return user;
        }
        int attempt = 0;
        public IActionResult Verify(UserModel usr)
        {
            
            var u= Putvalue();
            var ui=u.Where(u=>u.Id.Equals(usr.Id));
            var up=u.Where(u=>u.Password.Equals(usr.Password));
            var un=u.Where(u=>u.UserName.Equals(usr.UserName));

            if (u.Count == 1)
            {
                ViewBag.message("Logged in Sucessfully");
                return View(usr);
            }

            else
            {
                ViewBag.message("Login failed");
                attempt++;
                if (attempt > 2)
                {
                    ViewBag.message("Your account has been deactivated please constact administrator");
                }
                
                return View();
               
            }

            
  
        }
        
    }
}
