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
    public class BankAccountController : Controller
    {
        //public BankAccountController(BankAccountList bankAccountList)
        //{
        //    this.bankAccountList = bankAccountList;
        //}

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

        [Route("")]
        public IActionResult BankAccount()
        {
            return View(BankAccountList.bankAccountList);
        }

        [HttpPost]
        [Route("/IncreaseBalance")]
        public IActionResult IncreaseBalance(BankAccount bankAccount)
        {
            var bankaccounttemp = 
            BankAccountList.bankAccountList.Where(x => x.Id == bankAccount.Id);
            bankaccounttemp.First().Increase();
            return RedirectToAction("BankAccount");
        }
    }
}
