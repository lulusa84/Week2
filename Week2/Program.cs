using System;
using System.Collections.Generic;

namespace Week2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person();
            p.FirstName = "Pippo";

            Console.WriteLine(p);

            //Person p2 = p; // true
            Person p2 = new Person();
            p2.FirstName = "Pippo"; //false
            Console.WriteLine(p2.Equals(p));

            p.Document = new Document(123);
             Person p3 = p.ShallowCopy();
            Console.WriteLine(p + " " + p.Document);
            Console.WriteLine(p3 + " " + p3.Document);

            //MODIFICA di una CARATTERISTICA DI P
            p.Document.IdNumber = 456;
            Console.WriteLine(p + " " + p.Document);
            Console.WriteLine(p3 + " " + p3.Document);

            p3 = p.DeepClone();
            p.Document.IdNumber = 789;

            Console.WriteLine(p + " " + p.Document);
            Console.WriteLine(p3 + " " + p3.Document);

            Console.Clear();

            Console.WriteLine(p.Description());
            Console.WriteLine(p.Description("Miss"));

            p.PrintFamily("famiglia poco numerosa", p2, p3);
            Console.WriteLine("Persona: {0} - {1}", p.FirstName, p.Age);

            (bool success, string error, Person value) r = 
                p.CheckAgePersonTupla(new PersonRequest
                {
                    Age = 7,
                    Name = "Luca",
                    Surname = "Bianchi"
                });

           var chkResponseTupla = p.CheckAgePersonTupla(new PersonRequest

            {
                Age = -3,
                Name = "Mario",
                Surname = "Rossi"

            });

            if(!chkResponseTupla.Success)
            {
                Console.WriteLine(chkResponseTupla.Errore);
            }

            if (!r.success)
            {
                Console.WriteLine(r.error);
            }

            PersonRequest pr = new PersonRequest { Name = "Marco", Surname = "Gialli", Age = -5 };
            // bool result = p.CHeckAgePersonOut(pr, out errore, out value);
            string errore;
            Person value;
            bool result = p.CheckAgePersonOut(pr, out errore, out value);
            if(result)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine(errore);
            }

            //bool success = int.TryParse("1", out int numConvertito);
           

            MySortedList<int> msi = new MySortedList<int>();
            MySortedList<Person> msp = new MySortedList<Person>();
            var people = new List<Person>();
            MySortedList<Person>.Max<Person>(people);
          //  implementare interfaccia IComparable in class Person

            msi.Add(1);
            msp.Add(p);

            Console.Read();
        }
    }

}