using System;
using System.Collections.Generic;
using System.Linq;

namespace Week2.Linq2
{
    public class Program
    {
        #region DATI DI PROVA
        static List<Valutazione> voti = new List<Valutazione>
        {
        new Valutazione
        {

            NomeStudente = "Franco",
            DataValutazione = new DateTime(2021,7,15),
            Materia = Materia.Geografia,
            Voto = 7


        },
        new Valutazione
        {

            NomeStudente = "Franco",
            DataValutazione = new DateTime(2021, 7, 10),
            Materia = Materia.Italiano,
            Voto = 8


        },
        new Valutazione
        {

            NomeStudente = "Anna",
            DataValutazione = new DateTime(2021, 7, 11),
            Materia = Materia.Matematica,
            Voto = 4


        },
        new Valutazione
        {

            NomeStudente = "Alice",
            DataValutazione = new DateTime(2021, 7, 12),
            Materia = Materia.Storia,
            Voto = 6


        },
        new Valutazione
        {

            NomeStudente = "Luigi",
            DataValutazione = new DateTime(2021, 7, 12),
            Materia = Materia.Storia,
            Voto = 8,

        },
        new Valutazione
        {

            NomeStudente = "Tiziana",
            DataValutazione = new DateTime(2021, 7, 14),
            Materia = Materia.Matematica,
            Voto = 9,

        },
        new Valutazione
        {

            NomeStudente = "Tiziana",
            DataValutazione = new DateTime(2021, 7, 15),
            Materia = Materia.Italiano,
            Voto = 5,

        }

        };

        #endregion;
        static void Main(string[] args)
        {
            var soloVotiItaliano = voti
                            .Where(voti => voti.Materia == Materia.Italiano)
                            .Select(voto => new { Studente = voto.NomeStudente, Voto = voto.Voto });


            foreach (var v in soloVotiItaliano)
            {
                Console.WriteLine(v.Studente + " " + v.Voto);

            }

            var soloVotiItalianoQE =
                from v in voti
                where v.Materia == Materia.Italiano
                select new { Studente = v.NomeStudente, Voto = v.Voto };

            var studente = new { Nome = "Sarah", Age = 24, Materia = Materia.Geografia };
            var dipendente = new { Nome = "ABCD", Age = 15, Materia = Materia.Matematica };
            var studente1 = new { Nome = "Pippo", Age = 25 };
            studente = dipendente;


            var val = voti.GetValutazioniStudentiA();
            foreach (var item in val)
            {
                Console.WriteLine(item);

            }
            if (val.AnyValutazione(val.Count()))
            {
                Console.WriteLine("Lista vuota");
            }

            //ESERCIZIO
            //LAMBDA          
            var mediaVotiPerStudente = voti
                    .GroupBy(
                     v => new { v.NomeStudente, v.Materia },
                    (key, grp) => new

                    {
                        NomeStudente = key,
                        Materia = key.Materia,
                        MediaVoti = grp.Average(v => v.Voto)
                    }
                       ).Where(m => m.MediaVoti < 6.0);



            //QUERY
            var studentiMeidaVotiInsQE =
                 from v in voti
                 group v by new { v.NomeStudente, v.Materia } into grp
                 where grp.Average(v => v.Voto) < 6.0
                 select new
                 {
                     Studente = grp.Key.NomeStudente,
                     Materia = grp.Key,
                     MediaVoti = grp.Average(v => v.Voto)

                 };

            //voto medio minimo e max per materia

            //LAMBDA
            var mediaMaxMinVoti = voti
                 .GroupBy(
                v => v.Materia,
                (key, grp) => new
                {
                    Materia = key,
                    MediaVoti = grp.Average(v => v.Voto),
                    Massimo = grp.Max(v => v.Voto),
                    Minimo = grp.Min(v => v.Voto)
                });

            //QUERY
            var mediaMaxMinVotiQE = 
            from v in voti
            group v by v.Materia into grp           
            select new
            {
                
                Materia = grp.Key,
                MediaVoti = grp.Average(v => v.Voto),
                Massimo = grp.Max(v => v.Voto),
                Minimo = grp.Min(v => v.Voto)
            };

            //numro di voti per mese SQL COUNT

            //LAMBDA
            var nVotiMese = voti
                .GroupBy(
                v => v.DataValutazione.Month,
                    (key, grp) => new {
                        Mese = key,
                        NumeroVoti = grp.Count()
                });
            

        //QUERY
            var nVotiMesQE =
                from v in voti 
                group v by v.DataValutazione.Month into grp
                select new
                {
                    Mese = grp.Key,
                    NumeroVoti = grp.Count()
                };
        }
    }
}
    