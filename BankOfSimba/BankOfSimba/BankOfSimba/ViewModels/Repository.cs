using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.ViewModels
{
    public class Repository
    {
        public BankAccountList bankAccountList;
        public Repository(BankAccountList bankAccountList)
        {
            this.bankAccountList = bankAccountList;
        }
    }
}
