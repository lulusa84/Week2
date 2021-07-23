using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.EsercitazioneTelefonia.Factory;


namespace Week2.EsercitazioneTelefonia
{
    public class Sim
    {
        // public strin gnumero {
        // get { return numero;}
        // set { if value.length >10 {
        // Numero  = value.SubString(0,10)
        // }
        // Numero = value
        //}
        // }

        public string TelNum { get; set; }

        public double ResidualAmount { get; set; }

        public IOfferta Offerta { get; set; }
        //pubic Offerta OffertaSIm 

        public double TariffaBaseMin { get; set; } = 0.19;
        public bool IsTariffaBaseAttiva { get; set; }

        public Cliente Cliente { get; set; }

        public Sim(string telNum, double residualAmount, string nomeOfferta, Cliente cliente)
        {
            OffertaFactory offac = new OffertaFactory();

            TelNum = telNum;
            ResidualAmount = residualAmount;
            Offerta = offac.AttivaOfferta(nomeOfferta);
            Cliente = cliente;

        }


        public Sim(string telNum, double residualAmount, double tariffaBaseMin, Cliente cliente)
        {
            TelNum = telNum;
            ResidualAmount = residualAmount;
            TariffaBaseMin = tariffaBaseMin;
            IsTariffaBaseAttiva = true;
            Cliente = cliente;

        }

        // ALternative classe statica che fa operazione su sim/extension method class o
        /* public static void EseguiChiamata(this sim sim, int minuti)
        {
            Console.Writeline("Chiamata in corso")
            if(SIm.Offerta != null)
            {
             var minutiDOpoChiamata = sim.OffertaSIm.Minuti - minuti;
               if(minutiDOpoChiamata <0){

               sim.OffertSim.Minuti = 0;
               sim.CreditoResiduo -= (0.19 *Math.Abs(minutiDopoChiamata))

               }
             }
             
            else
            {
            sim.CreditoResiduo -= (0.19 * minuti)
          }
        Console.WriteLine("chiamta terminta")
        }  
        }

        publuc static string verificaCredito(this Sim  sim)
        {
        return $"il tuo credito residuo è: {sim.Credito residuo} euro
        }

         publuc static string verificaOfferta(this Sim  sim)
        {
        if(sim.OffertaSim != null) {

        return $"la tua Offerta prevede: {sim.Offerta.Minuti}minuit +
        {sim.Offerta.NSms) nSms + {sim.Offerta.GB) gb";

        }else{
       return  "nessuna offerta attiva"
        }
        }
        */

        //public double public GetChiamata(int minutiConv)
        //Chain  con tupla(credito e numero minuti)
        //Verifica Credito residuo sim
        //Verifica residuo offerta


       /* COATRUTTORE SIM ANTONIA
         * public Sim(Strign numero, double creditoResiduo) 
         * {
         *   if(numero.Lenght > 10) 
         *   {
         *      Numero = numero.SUbstring(0,10);
         *   };
         *   CreditoResiduo = CreditoResiduo
         * }
         * 
         */

       /* public static bool operato +(Sim sim, double importo)
         {
          if(inporto > 0)
          {
          sim.CreditoResiduo += importo;
          return true;
          }
          return false;

         }

          public staticSim operator +(Sim sim, double importo)
          sim.Credito Residuo += imposr 
          return sim
        */

       // CLASSE INNESTRATA OFFERTA
        /* 
         * public string Nome 
         * public int GB
         * public int  Minuti
         * public  int NSMS
         * 
         * Costrutture
         * 
         * public Offerta(string noem, int min, int gb, int nSMS)
         * {
         *  Nome = nome
         *  min = min
         *  GB = gb
         *  NSMS = nSMS
         * }
         * 
         */

    }
}
