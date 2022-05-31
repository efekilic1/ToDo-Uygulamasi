using System;
using System.Collections.Generic;

namespace ToDoApp
{

    public class directory
    {


        List<contactCard> todo = new List<contactCard>();
        List<contactCard> inProgress = new List<contactCard>();
        List<contactCard> done = new List<contactCard>();



        public directory()
        {
            todo.Add(new contactCard("Web", "HTML", 101, CardSizeEnum.L.ToString()));
            todo.Add(new contactCard("Mobil", "Swift", 102, CardSizeEnum.M.ToString()));
            todo.Add(new contactCard("Web", "CSS", 103, CardSizeEnum.XL.ToString()));

            TeamUsersList.TeamList.Add(new TeamUserModel("Esra", 101));
            TeamUsersList.TeamList.Add(new TeamUserModel("Harika", 102));
            TeamUsersList.TeamList.Add(new TeamUserModel("Ahsen", 103));




        }

        public static string PeopleIdName(int id)
        {
            foreach (var item in TeamUsersList.TeamList)
            {
                if (item.İd == id)
                {
                    return item.Username;
                }
            }
            return null;
        }



        public static string EnumToSize(int number)
        {
            if (number == 1)
            {
                return CardSizeEnum.XS.ToString();
            }
            else if (number == 2)
            {
                return CardSizeEnum.S.ToString();
            }
            else if (number == 3)
            {
                return CardSizeEnum.M.ToString();
            }
            else if (number == 4)
            {
                return CardSizeEnum.L.ToString();
            }
            else
            {
                return CardSizeEnum.XL.ToString();
            }
        }






        public void addNumber()
        {
            contactCard member = new contactCard();
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("Lütfen Başlık Giriniz            : ");
            member.tittle = Console.ReadLine();
            Console.WriteLine("Lütfen İçerik giriniz           :");
            member.content = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
            int sizeNum = int.Parse(Console.ReadLine());
            member.size = EnumToSize(sizeNum);


            Console.WriteLine("Lütfen Kişi Seçiniz :");
            member.personId = int.Parse(Console.ReadLine());
            todo.Add(member);




            Console.WriteLine("Yeni Kart eklendi    :");
            Console.WriteLine("Başlık : {0}", member.tittle);
            Console.WriteLine("İçerik : {0}", member.content);
            Console.WriteLine("Atanan Kişi : {0}", PeopleIdName(member.personId));
            Console.WriteLine("Büyüklük : {0}", member.size);

        }


        public void deleteCard()
        {
        again:
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız:");
            string InputTittle = Console.ReadLine();

            int cnt = 0;
            foreach (var card in todo)
            {
                if (InputTittle.ToLower() == card.tittle.ToLower())
                {
                    cnt++;
                    Console.WriteLine("Bu kartı silmek istediğinizden emin misiniz  Başlık : " + card.tittle + ", İçerik: " + card.content + ", Sahibi : " + PeopleIdName(card.personId) + " (y/n) ");
                    if (Console.ReadLine() == "y")
                    {
                        todo.RemoveAt(todo.IndexOf(card));
                        Console.WriteLine("Silindi");
                        break;
                    }

                }



            }
            if (cnt == 0)
            {
                Console.WriteLine("Böyle bir kişi yok");
            flag:
                Console.WriteLine("Silmeyi sonlandırmak için: (1)");
                Console.WriteLine("Yeniden denemek için: (2)");
                int num = int.Parse(Console.ReadLine());

                if (num == 2)
                {
                    goto again;
                }
                else if (num == 1)
                {

                }
                else
                {
                    Console.WriteLine("Lütfen 1 veya 2 tuşlayınız");
                    goto flag;
                }

            }



        }


        /*

        public void update()
        {
            again:
            Console.WriteLine("Lütfen bilgilerini güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string nameOrSurname = Console.ReadLine();

            int cnt = 0;
            foreach (var card in contactCard)
            {
                if (nameOrSurname.ToLower() == card.name.ToLower() || nameOrSurname.ToLower() == card.surname.ToLower())
                {
                    cnt++;
                    Console.WriteLine("Lütfen yeni ismi giriniz");
                    card.name = Console.ReadLine();
                    Console.WriteLine("Lütfen yeni soyismi giriniz");
                    card.surname = Console.ReadLine();
                    Console.WriteLine("Lütfen yeni numarayı giriniz");
                    card.number = Console.ReadLine();

                    Console.WriteLine("Başarıyla güncellendi İsim: " + card.name + ", Soyisim: " + card.surname + ", Numara: " + card.number);
                    break;

                }



            }
            if  (cnt == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                flag:
                Console.WriteLine("Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine("Yeniden denemek için              : (2)");
             
                int num = int.Parse(Console.ReadLine());

                if (num == 2)
                {
                    goto again;
                }
                else if (num == 1)
                {

                }
                else
                {
                    Console.WriteLine("Lütfen 1 veya 2 tuşlayınız");
                    goto flag;
                }



            }





        }

        */

        public void SortDictionary()
        {





            Console.WriteLine("TODO Line");
            Console.WriteLine("****************");

            foreach (var card in todo)
            {
                Console.WriteLine("Başlık: {0}", card.tittle);
                Console.WriteLine("İçerik: {0}", card.content);
                Console.WriteLine("Atanan Kişi : {0}, Id : {1}", PeopleIdName(card.personId), card.personId);
                Console.WriteLine("Büyüklük : {0}", card.size);
                Console.WriteLine("-");
            }
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("****************");

            foreach (var card in inProgress)
            {
                Console.WriteLine("Başlık: {0}", card.tittle);
                Console.WriteLine("İçerik: {0}", card.content);
                Console.WriteLine("Atanan Kişi : {0}", PeopleIdName(card.personId));
                Console.WriteLine("Büyüklük : {0}", card.size);
                Console.WriteLine("-");
            }

            Console.WriteLine("DONE Line");
            Console.WriteLine("****************");
            foreach (var card in done)
            {
                Console.WriteLine("Başlık: {0}", card.tittle);
                Console.WriteLine("İçerik: {0}", card.content);
                Console.WriteLine("Atanan Kişi : {0}, Id : {1}", PeopleIdName(card.personId), card.personId);
                Console.WriteLine("Büyüklük : {0}", card.size);
                Console.WriteLine("-");
            }



        }





    }



}
