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
        public Animaltype Animaltype { get; set; }
    }
}
