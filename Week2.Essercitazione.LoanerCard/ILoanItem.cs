using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Essercitazione.LoanerCard
{
    public enum Stato
    {
        inPresto,
        Reso
    }
    public interface ILoanItem<T>
    {
        public int Id { get; set; }
        public Stato Stato { get; set; }
    }
}
