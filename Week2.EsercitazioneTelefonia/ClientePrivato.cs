using System;
using System.Text;

namespace Week2.EsercitazioneTelefonia
{
    class ClientePrivato : Cliente
    {
        //private int Age { get{ return(DateTime.Today.Year - BirthDate.Year); } }
        //public bool isYoug() => Age > 30 ? true : false
        public ClientePrivato()
        {
        }

        public ClientePrivato(string nome, string cognome, DateTime birthDate, bool sesso)
        {
            Nome = nome;
            Cognome = cognome;
            BirthDate = birthDate;
            Sesso = sesso;
            
        }

        public bool isYoung()
        {
            int Age = DateTime.Today.Year - BirthDate.Year;
            //int.TryParse(DateTime.Today.Year.ToString(), out int currentYear);
            //int.TryParse(BirthDate.Year.ToString(), out int birthYear);
            //int CurrentYear = currentYear;
            //int BirthYear = birthYear;

            if (Age > 30)
            {
                return true;
            }
            return false;
             }

        public static explicit operator ClientePrivato(ClienteBusiness cb)
        {
            
                return new ClientePrivato(cb.Nome, cb.Cognome, cb.BirthDate, cb.Sesso);
           
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("====Cliente Privato====");
           // sb.AppendLine(//properties);
            sb.AppendLine(base.ToString());

            return sb.ToString();
                
        }
    }
    }

