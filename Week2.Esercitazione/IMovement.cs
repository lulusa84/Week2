using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Esercitazione
{
    public interface IMovement
    {
        public double MAmount { get; set; }
        public DateTime MovementDate { get; set; }
    }
}
