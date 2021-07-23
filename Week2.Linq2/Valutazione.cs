using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Linq2
{
    public enum Materia
    {
        Italiano,
        Matematica,
        Storia,
        Geografia

    }
   public  class Valutazione
    {
        public string NomeStudente { get; set; }
        public DateTime DataValutazione { get; set; }

        public int Voto { get; set; }
        public Materia Materia;

        public override string ToString()
        {
            return (NomeStudente + " " + Voto);
        }
    }
}

