using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SysManage;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WkMvcCore.Controllers
{
    public class HelloWordController : Controller
    {
     
        public IUserManage UserManager { get; set; }
        
        public HelloWordController(IUserManage _userNanager)
        {
            UserManager = _userNanager;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
          ;
            ViewData["test"] = UserManager.Test();
            return View();
        }
    }
}
