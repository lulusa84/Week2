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
              32000,
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
                    _ = StAccount + cm;
                    StAccount.getMList();
                    break;

                case 2:
                    Console.WriteLine("hai scelto di creare prelevare");
                    CashMovement cm1 = createCashMovement();
                    _ = StAccount - cm1;
                    StAccount.getMList();

                    break;

                case 3:
                    Console.WriteLine("hai scelto di Fare un trasferimento");
                    TransferMovement tm = TransferMovementCreate();
                    _ = StAccount - tm;
                    StAccount.getMList();

                    break;

                case 4:
                    Console.WriteLine("hai scelto di operare con la tua carta di credito");
                    Console.WriteLine("cosa vuoi fare? caricare/pagere");
                    string operazione = Console.ReadLine();

                    CreditCardMovement ccm = CreditCardMovementCreate();

                    if (operazione.Equals("caricare"))
                    {
                        _ = StAccount + ccm;
                        StAccount.getMList();

                    }
                    else if (operazione.Equals("pagare"))
                    {
                        _ = StAccount - ccm;
                        StAccount.getMList();

                    }
                    else

                    {
                        Console.WriteLine("formato operazioen non corretto");
                        
                    }

                   
                    Console.WriteLine(StAccount.CurrentAmount);
                    break;

               case 5:

                 StAccount.getMList();
 
                  break;
            
       

            }

            while (Console.Read() != 'q') ;

            //Console.Read();
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

       


        

  
  
