using _4_1.Data;
using _4_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace _4_1.Controllers
{
    public class UserController : Controller
    {
        //先前注入了db context，所以在這邊宣告一下我們要使用它，用以藉由context操作EF
        private readonly MyDbContext _myDbContext;
        public UserController(MyDbContext myDbContext) {
            this._myDbContext=myDbContext;
        }

        //Page: 註冊
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //Page: 登入
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        //Page: 登入成功
        [HttpGet]
        public IActionResult SignInSuccess()
        {
            return View();
        }

        //註冊
        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserRequest) 
        {
            //比對是否註冊過
            if (_myDbContext.Users.SingleOrDefault(u => u.Email == addUserRequest.Email) != null)
            {
                TempData["Message"] = "此email已註冊過!";
                return RedirectToAction("Add");
            }
            //沒註冊過就new一個user，然後存到表裡面
            else
            {
                var user = new User()
                {
                    Email = addUserRequest.Email,
                    Password = addUserRequest.Password
                };
                _myDbContext.Users.Add(user);
                _myDbContext.SaveChanges();
                TempData["Message"] = "註冊成功!";
                return RedirectToAction("SignInSuccess");
            }
        }

        //登入
        [HttpPost]
        public IActionResult SignIn(SignInViewModel signInRequest)
        {
            //比對帳密是否匹配
            var user=_myDbContext.Users.SingleOrDefault(u => u.Email == signInRequest.Email);
            if (user!=null && user.Password == signInRequest.Password)
            {
                TempData["Message"] = "登入成功!!";
                return RedirectToAction("SignInSuccess");
            }
            else
            {
                TempData["Message"] = "帳號或密碼錯誤!";
                return RedirectToAction("SignIn");
            }
        }
    }
}
