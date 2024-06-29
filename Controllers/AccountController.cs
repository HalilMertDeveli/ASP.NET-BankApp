using HMD.BankApp.Web.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace HMD.BankApp.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly BankContext _context;

        public AccountController(BankContext context)
        {
            _context = context;
        }

        public IActionResult Create(int id)
        {
            var userInfo = _context.ApplicationUserDbSet.SingleOrDefault(x => x.Id == id);

            return View(userInfo);
        }
    }
}
