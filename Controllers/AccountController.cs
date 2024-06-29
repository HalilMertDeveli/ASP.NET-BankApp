using HMD.BankApp.Web.Data.Context;
using HMD.BankApp.Web.Models;
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
            //var userInfo =
                //_context.ApplicationUserDbSet.SingleOrDefault(x => x.Id == id);

            var userInfo =
                _context.ApplicationUserDbSet.Select(x => new UserListModel()
                { Id=x.Id,Name=x.Name,SurName = x.SurName,}).SingleOrDefault(x => x.Id == id);

            return View(userInfo);
        }

        [HttpPost]
        public IActionResult Create(AccountCreateModel accountCreateModel)
        {
            _context.AccountDbSet.Add(new Data.Entities.Account { AccountNumber = accountCreateModel.AccountNumber, ApplicationUserId = accountCreateModel.ApplicationUserId, Balance = accountCreateModel.Balance, });
            _context.SaveChanges();


            return RedirectToAction("Index","Home");
        }
    }
}
