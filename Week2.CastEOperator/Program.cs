using System;

namespace Week2.CastEOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rombo rombo = new Rombo(13, 10, 10);
            var quadrato = (Quadrato)rombo;

            Quadrato q1 = new Quadrato(10);
            Rombo romboConvertito = q1;

            if (q1 is Rombo)
            {
                Console.WriteLine("Questo quadrato è anche un rombo");
            }
            else
            {
                Console.WriteLine("Questo quadrato non è un rombo");
            }

            //CONVERSIONE SICURA
            if (q1 is Rettangolo)
            {
                Console.WriteLine("Ogni quadrato è anche un rettangolo");
            }

            //try { 

            IShape figuraGeometrica = new Rettangolo(4,3);
            Quadrato figuraQuadrato = new Quadrato(4);
            Rombo figuraRombo = new Rombo(4, 5, 5);

            //IShape figuraQuadrato = new Quadrato(4);


            //IShape figuraRombo = new Rombo(4,5,5);
            /*if (figuraRombo is Rombo)
            {
                Rombo romboConvertito2 = (Rombo)figurRombo;
                if (romboConvertito2.DiagonaleMaggiore == romboConvertito2.DiagonaleMinore)
                {
                   figuraGeometrica =   new Rettangolo(romboConvertito2.Lato, romboConvertito2.Lato);

                }

            }*/
            /*
             * catch (InvalidCastException ex)
             * {
             *    Console.WriteLine(ex.Message);
             * }
              */



            //CONVERSIONE 

            try
            {

                figuraGeometrica = (Rettangolo)figuraQuadrato;
                figuraGeometrica = (Rettangolo)figuraRombo;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }


            //ALTRO METODO DI CAST SICURO

            Rombo altroRombo = new Rombo(3, 4, 4);
            //var rettangolo = figuraGeometrica as Rettangolo;

            Rettangolo rettangolo = (Rettangolo)altroRombo;
            //rettangolo as Rettangolo;
            if (rettangolo == null)
            {
                Console.WriteLine("Cast non valido");

            }
            #region NULLABLE

            Frazione f = null;
            int num = f?.Numeratore ?? 0;

            //equivale a 
            if(f != null)
            {
                num = f.Numeratore;
            }
            else
            {
                num = 0;
            }

            //equivale a 
            num = (f != null) ? f.Numeratore : 0;

            Sample s = null;
            Sample s1 = new Sample { stringSample = null };
            Sample s2 = new Sample { stringSample = "prova" };

            var strignUp = s2?.stringSample?.ToUpper() ?? "STRNGA MAIUSCOLA";

            //equivale a 
            if (s2 != null)
            {
                if(s2.stringSample != null)
                     {

                    strignUp = s2.stringSample?.ToUpper();
                    }
                else
                    {
                        s2.stringSample = "STRINGA MAIUSCOLA";
                    }

                }
            }
 
            #endregion

        }

    }

