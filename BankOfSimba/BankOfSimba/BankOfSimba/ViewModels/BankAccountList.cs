using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.ViewModels
{
    public class BankAccountList
    {
        public static List<BankAccount> bankAccountList = new List<BankAccount>()
        {
            new BankAccount()
            {
                Id = 1,
                Name = "Simba",
                Balance = 2000,
                Animaltype = Animaltype.Lion
            },
            new BankAccount()
            {
                Id = 2,
                Name = "Zordon",
                Balance = -2000,
                Animaltype = Animaltype.Lion
            },
            new BankAccount()
            {
                Id = 3,
                Name = "Mufasa",
                Balance = 2000000,
                Animaltype = Animaltype.Lion,
                Isking = true
            },
            new BankAccount()
            {
                Id = 4,
                Name = "Pumba",
                Balance = 200000000000,
                Animaltype = Animaltype.Warthog
            },
            new BankAccount()
            {
                Id = 5,
                Name = "Timon",
                Balance = 200000000000,
                Animaltype = Animaltype.Meerkat
            }
        };    
    }
}