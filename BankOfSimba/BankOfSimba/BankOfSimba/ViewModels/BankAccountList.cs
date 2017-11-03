using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.ViewModels
{
    public class BankAccountList
    {
        public List<BankAccount> bankAccountList = new List<BankAccount>();

        public BankAccountList()
        {
            FillList();
        }

        public BankAccount bankAccountOne = new BankAccount()
        {
            Name = "Simba",
            Balance = 2000,
            Animaltype = Animaltype.Lion
        };
        public BankAccount bankAccountTwo = new BankAccount()
        {
            Name = "Zordon",
            Balance = -2000,
            Animaltype = Animaltype.Lion
        };
        public BankAccount bankAccountThree = new BankAccount()
        {
            Name = "Mufasa",
            Balance = 2000000,
            Animaltype = Animaltype.Lion
        };
        public BankAccount bankAccountFour = new BankAccount()
        {
            Name = "Pumba",
            Balance = 200000000000,
            Animaltype = Animaltype.Warthog
        };
        public BankAccount bankAccountFive = new BankAccount()
        {
            Name = "Timon",
            Balance = 200000000000,
            Animaltype = Animaltype.Meerkat
        };

        public List<BankAccount> FillList()
        {
            bankAccountList.Add(bankAccountOne);
            bankAccountList.Add(bankAccountTwo);
            bankAccountList.Add(bankAccountThree);
            bankAccountList.Add(bankAccountFour);
            bankAccountList.Add(bankAccountFive);
            return bankAccountList;
        }

    }
}