using BankOfSimba.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string currency = "Zebra";

        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public Animaltype Animaltype;
        public bool Isking = false;
        public bool IsGood = true;

        public void Increase()
        {
           if(this.Isking)
               this.Balance += 100;
           else
                this.Balance += 10;
        }

        public void AddElement(BankAccount bankAccount)
        {
            BankAccountList.bankAccountList.Add(bankAccount);
        }
    }
}
