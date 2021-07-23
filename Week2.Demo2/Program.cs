using System;
using System.IO;

namespace Week2.Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();

            BaseClass bc2 = new BaseClass
            {
                Value = 1,
                Stringa = "CIAO"
            };

            BaseClass bc3 = new BaseClass();

            ConcreteClass cc = new ConcreteClass();

            using (FileStream writer = File.Create(@"C:\Users\sarah.tarantino\Desktop\Week1")) ;

            DisposableClass dc = new DisposableClass(); //RISORSA COSTOSA
            //operaizoni su risorsa c 

            dc.Dispose();
        }

        
    }
}
