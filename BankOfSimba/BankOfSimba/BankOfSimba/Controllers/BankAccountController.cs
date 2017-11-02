using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class BankAccountController : Controller
    {
        Repository repository;

        public BankAccountController(Repository repository)
        {
            this.repository = repository;
        }

        [Route("Simba")]
        public IActionResult Index()
        {
            var bankaccount = new BankOfSimba.Models.BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                Animaltype = Models.Animaltype.Lion
            };
            return View(bankaccount);
        }

        [Route("/list")]
        public IActionResult BankAccountList()
        {
            return View(repository);
        }

        [Route("/BankAccount/IncreaseBalance")]
        [HttpPost]
        public IActionResult IncreaseBalance(BankAccount bankAccount)
        {
            bankAccount.Increase();
            return RedirectToAction("BankAccountList");
        }
    }
}
