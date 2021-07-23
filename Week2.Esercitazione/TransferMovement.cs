using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Esercitazione
{
   public  class TransferMovement : IMovement
    {

        public double MAmount { get; set; }
        public DateTime MovementDate { get; set; }

        public string OBank { get; set; } 

        public string DBank { get; set; }

        public TransferMovement(double mAmount, DateTime movementDate, string oBank, string dBank)
        {
            MAmount = mAmount;
            MovementDate = movementDate;
            OBank = oBank;
            DBank = dBank;
        }

        public override string ToString()
        {
            return $"{MAmount} + {MovementDate} + {OBank} + {DBank}";
        }
    }
}
