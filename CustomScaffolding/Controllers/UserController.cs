using CustomScaffolding.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomScaffolding.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<UserModel> users = new List<UserModel>() { 
            new UserModel{ Id=1,Name="Mohammadreza",Family="Ahadian"},
            new UserModel{ Id=2,Name="AhmadReza",Family="Nasiri"},
            new UserModel{ Id=3,Name="AliReza",Family="Jafari"},
            };
            return View(users);
        }
        public IActionResult Index2()
        {
            List<UserModel> users = new List<UserModel>() {
            new UserModel{ Id=1,Name="Mohammadreza",Family="Ahadian"},
            new UserModel{ Id=2,Name="AhmadReza",Family="Nasiri"},
            new UserModel{ Id=3,Name="AliReza",Family="Jafari"},
            };
            return View(users);
        }
    }
}
