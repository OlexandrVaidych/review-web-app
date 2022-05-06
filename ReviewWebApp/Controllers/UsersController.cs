using Microsoft.AspNetCore.Mvc;
using ReviewWebApp.Data;
using ReviewWebApp.Models;

namespace ReviewWebApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly ReviewWebAppContext _context;

        public UsersController(ReviewWebAppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([Bind("Id, Name, Email, Password, ConfirmPassword")] User user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return Redirect("~/Home");
        }
    }
}
