using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsercitazioneTelefonia
{
   public abstract class Cliente
    { 
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Sesso { get; set; }
        
       
        public override string ToString()
        {
            var s = $"{ Sesso }".Equals( true) ? "M":"F";
            return $"{Nome}  +  {Cognome}  + {BirthDate} + {s}";
        }

        
    }
}
    
