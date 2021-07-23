using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Esercitazione
{
    public class CashMovement : IMovement
    {
        public double MAmount { get; set; }
        public DateTime MovementDate { get; set; }

        public string Esecutore { get; set; }

        public CashMovement(double mAmount, DateTime movementDate, string esecutore)
        {
            MAmount = mAmount;
            MovementDate = movementDate;
            Esecutore = esecutore;
        }

        public override string ToString()
        {
            return $"{MAmount} + {MovementDate} + {Esecutore}";
        }
    }
}
