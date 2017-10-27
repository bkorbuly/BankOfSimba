using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class BankAccountController : Controller
    {
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
    }
}
