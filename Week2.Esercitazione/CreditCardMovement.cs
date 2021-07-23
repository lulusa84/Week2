using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Esercitazione
{
    public enum Tipo
    {
        AMEX,
        VISA,
        MASTERCARD,
        OTHER
    }
    public class CreditCardMovement : IMovement
    {
        public double MAmount { get; set; }
        public DateTime MovementDate { get; set; }
        public Tipo Tipo { get; set; }

        public string CCNumber { get; set; }
        public CreditCardMovement(double mAmount, DateTime movementDate, Tipo tipo, string ccNumber)
        {
            MAmount = mAmount;
            MovementDate = movementDate;
            Tipo = tipo;
            CCNumber = ccNumber;
        }

        public override string ToString()
        {
            return $"{MAmount} + {MovementDate} + {Tipo} + {CCNumber}";
        }
    }
}
