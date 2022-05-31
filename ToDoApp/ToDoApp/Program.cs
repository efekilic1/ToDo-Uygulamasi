using System;

namespace ToDoApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            directory directory = new directory();

        flag:
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");


            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    directory.SortDictionary();
                    goto flag;
                // break;
                case "2":
                    directory.addNumber();
                    goto flag;
                //   break;
                case "3":
                    directory.deleteCard();
                    goto flag;
                case "4":
                    //     directory.SortDictionary();
                    goto flag;
                case "5":
                    //   directory.FindDictionary();
                    goto flag;



            }







        }
    }
}
