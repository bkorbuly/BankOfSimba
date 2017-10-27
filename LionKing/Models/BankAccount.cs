using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LionKing.Models
{
    public class BankAccount
    {
        public string Currency = "Zebra";

        public bool GoodGuy { get; set; } = true;
        public bool IsKingOrNot { get; set; } = false;
        public string Name { get; set; }
        public double Balance { get; set; }
        public Animaltypes Animaltypes { get; set; }
    }
}
