﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LionKing.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LionKing.Controllers
{
    public class BankAccountController : Controller
    {
        BankAccountList bankaccountList;

        public BankAccountController(BankAccountList bankaccountList)
        {
            this.bankaccountList = bankaccountList;
        }

        // GET: /<controller>/
        [Route("Simba")]
        public IActionResult Index()
        {
            var bankAccountOne = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                Animaltypes = Animaltypes.Lion,
                Currency = "Zebra"
            };
            return View(bankAccountOne);
        }

        [Route("/")]
        public IActionResult BankAccountList()
        {
            return View(bankaccountList);
        }

        [HttpPost]
        public IActionResult Add()
        {
            bankaccountList.
            return RedirectToAction("BankaccountList");
        }
    }
}
