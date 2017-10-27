using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LionKing.Models
{
    public class BankAccountList
    {
        public BankAccountList()
        {
            FillList();
        }
        public BankAccount bankAccountOne = new BankAccount()
        {
            Name = "Simba",
            Balance = 2000,
            Animaltypes = Animaltypes.Lion
        };
        public BankAccount bankAccountTwo = new BankAccount()
        {
            Name = "Zordon",
            Balance = -2000,
            Animaltypes = Animaltypes.Lion,
            GoodGuy = false
        };
        public BankAccount bankAccountThree = new BankAccount()
        {
            Name = "Mufasa",
            Balance = 2000000,
            Animaltypes = Animaltypes.Lion,
            IsKingOrNot = true
        };
        public BankAccount bankAccountFour = new BankAccount()
        {
            Name = "Timon",
            Balance = 200000000000,
            Animaltypes = Animaltypes.Meerkat
        };
        public BankAccount bankAccountFive = new BankAccount()
        {
            Name = "Pumba",
            Balance = 200000000000,
            Animaltypes = Animaltypes.Warthog
        };
        public BankAccount bankAccountSix = new BankAccount()
        {
            Name = "Monkey",
            Balance = 0,
            Animaltypes = Animaltypes.Monkey
        };

        public List<BankAccount> bankAccountList = new List<BankAccount>();

        public List<BankAccount> FillList()
        {
            bankAccountList.Add(bankAccountOne);
            bankAccountList.Add(bankAccountTwo);
            bankAccountList.Add(bankAccountThree);
            bankAccountList.Add(bankAccountFour);
            bankAccountList.Add(bankAccountFive);
            bankAccountList.Add(bankAccountSix);
            return bankAccountList;
        }     
       
    }
}
