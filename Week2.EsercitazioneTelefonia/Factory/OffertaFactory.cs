using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsercitazioneTelefonia.Factory
{
    public class OffertaFactory
    {


        public IOfferta AttivaOfferta(string Nome)
        {
            IOfferta offerta = null;
            switch (Nome)
            {
             
                case "MinutiIllimitati":
                    
                    offerta = new MinIllimitati(Nome);
                    break;
                case "30GB":
                    offerta = new _30GB(Nome);
                    break;
                case "50GB":
                    offerta = new _50GB(Nome);
                    break;
                
                default:
                    break;
            }

            return offerta;
        }
    }

       
}

