using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsercitazioneTelefonia
{
    class MinIllimitati : IOfferta
    {
        public string Nome { get; set ; }
        public int Minuti { get ; set; }
        public int NumSMS { get  ; set ; }
        public int GB { get; set; }
        public bool IsAttiva { get ; set; }

        public MinIllimitati(string nome)
        {
            Nome = nome;
        }
    }
}
