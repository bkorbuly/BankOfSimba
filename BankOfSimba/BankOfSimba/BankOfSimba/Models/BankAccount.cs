using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string currency = "Zebra";

        public string Name { get; set; }
        public double Balance { get; set; }
        public Animaltype Animaltype;
        public bool Isking = false;
        public bool IsGood = true;

        public void Increase()
        {
           if(Isking)
               Balance += 100;
           else
               Balance += 10;
           
        }
    }
}
