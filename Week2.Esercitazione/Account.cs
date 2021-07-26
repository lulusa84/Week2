using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Esercitazione
{
    public class Account
    {

        public int AccountN { get; set; }
        public string NomeBanca { get; set; }
        public double CurrentAmount { get; set; }
        public DateTime LastMovementDate { get; set; }

        private List<IMovement> MList { get; set; } = new List<IMovement>() { };

        public Account(int accountN, string nomeBanca, double currentAmount,
            DateTime lastMovementDate)
        {
            AccountN = accountN;
            NomeBanca = nomeBanca;
            CurrentAmount = currentAmount;
            LastMovementDate = lastMovementDate;
            
        }

        public static List<IMovement> operator +(Account a, IMovement m)
        {
            a.MList.Add(m);
            a.CurrentAmount += m.MAmount;
            a.LastMovementDate = m.MovementDate;
            return a.MList;
        }

        public static List<IMovement> operator -(Account a, IMovement m)
        {
            a.MList.Add(m);
            a.CurrentAmount -= m.MAmount;
            a.LastMovementDate = m.MovementDate;
            return a.MList;

        }

        public override string ToString()
        {
            return base.ToString() + $"{AccountN} + {NomeBanca} + {CurrentAmount} + {LastMovementDate}";
        }

        public void Statement()
        {
            Console.WriteLine(ToString());
            foreach (var item in MList)
            {
                Console.WriteLine(item.ToString());
            }


        }

        public void getMList()
        {
            foreach(IMovement m in MList)
            {
                Console.WriteLine(m.ToString());
            }
        }

    }
}
