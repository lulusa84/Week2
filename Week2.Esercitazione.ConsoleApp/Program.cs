using System;
using System.Collections.Generic;

namespace Week2.Esercitazione.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Benvenuto nel nostro gestionale");
            Console.WriteLine("Cosa vuoi fare?");
            Account StAccount = new Account(
                1234,
                "BNL",
                0,
                DateTime.Now

                );

            CashMovement InitCm = new CashMovement
                (
              320000,
               DateTime.Now,
               "Sarah Tarantino"

            );
            _ = StAccount + InitCm;
            

            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 0:

                    Console.WriteLine("hai scelto di crare un conto");
                    // CreateAccount();
                    CreateAccount().Statement();
                    break;

                case 1:

                    Console.WriteLine("hai scelto di versare");
                    CashMovement cm = createCashMovement();
                    _=StAccount + cm;
                    cm.ToString();
                    break;

                case 2:
                    Console.WriteLine("hai scelto di creare prelevare");
                    CashMovement cm1 = createCashMovement();
                    _ = StAccount - cm1;
                    cm1.ToString();

                    break;

                case 3:
                    Console.WriteLine("hai scelto di Fare un trasferimento");
                    TransferMovement tm = TransferMovementCreate();
                    _ = StAccount - tm;
                    tm.ToString();

                    break;

                case 4:
                    Console.WriteLine("hai scelto di oerare con la tua carta di credito");
                    Console.WriteLine("cosa vuoi fare? caricare/pagere");
                    string operazione = Console.ReadLine();

                    CreditCardMovement ccm = CreditCardMovementCreate();                

                    if (operazione.Equals("caricare"))
                    {
                        _ = StAccount + ccm;
                        ccm.ToString();
                    }
                    else if (operazione.Equals("pagare"))
                    {
                        _ = StAccount - ccm;
                        ccm.ToString();
                    }
                    else
                    {
                        Console.WriteLine("formato operazioen non corretto");

                    }
                   
                    break;

            }


            Console.Read();
        }

        public static Account CreateAccount() {
            Console.WriteLine("Ho bisogno dei tui dati");


            Account BankAccount = new Account
                (
                Convert.ToInt32(Console.ReadLine()),
                   Console.ReadLine(),
                    0,
                    DateTime.Now


                );



            CashMovement cm = new CashMovement
                (
              Convert.ToInt32(Console.ReadLine()),
               DateTime.Now,
               "Sarah Tarantino"

            );

            _ = BankAccount + cm;
            return BankAccount;
        }


        public static CashMovement createCashMovement() {


            CashMovement cm = new CashMovement
                (
                Convert.ToInt32(Console.ReadLine()),
                 DateTime.Now,
               "Sarah Tarantino"

               );
            return cm;

            }

        public static TransferMovement TransferMovementCreate()
        {


            TransferMovement tm = new TransferMovement
                (
                Convert.ToInt32(Console.ReadLine()),
                 DateTime.Now,
                 Console.ReadLine(),
                 Console.ReadLine()

               );
            return tm;

        }

        public static CreditCardMovement CreditCardMovementCreate()
        {
          

            CreditCardMovement ccm = new CreditCardMovement
                (
                 Convert.ToInt32(Console.ReadLine()),
                 DateTime.Now,
                 (Tipo)int.Parse(Console.ReadLine()),
                 Console.ReadLine()

               );
            return ccm;

        }


    }
}

       


        

  
  
