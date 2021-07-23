using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Essercitazione.LoanerCard
{
   
     public enum UserCat
    {
        Regular,
        Supporter,
        Premium,
    }

    public class LoanerCard<T> : ILoanItem<T>
    {
        private List<T> items = new List<T>();
        public int Id { get; set; }
        public Stato Stato { get; set; }

        public string NomeUtente { get; set; }
        public string Cognome { get; set; }
        public DateTime DataIscizione { get; set; }

        public UserCat UserCat { get; set; }

       //setta stato prestato
        public void Presta(T  item)
        {

        }
        //setta stato reso
        public void Restituisci(T item)
        {

        }

    }
}
