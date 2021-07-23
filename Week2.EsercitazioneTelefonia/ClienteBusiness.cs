using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsercitazioneTelefonia
{
    class ClienteBusiness : Cliente
    {
      public string Iban { get; set; }

      public string PIva { get; set; }

        public ClienteBusiness(string iban, string pIva )
        {
            Iban = iban;
            PIva = PIva;
        }

        public ClienteBusiness(string nome, string cognome, DateTime birthDate, bool sesso, string iban)
        {
            Nome = nome;
            Cognome = cognome;
            BirthDate = birthDate;
            Sesso = sesso;
            Iban = iban;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("====Cliente====");
            //sb.AppendLine(//porperties)
            sb.AppendLine(base.ToString());

            return sb.ToString();

        }
    }
}
