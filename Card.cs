using System;
namespace _08._02._2023Exception
{
    public class Card
    {
        public string Name_Banc { set; get; }
        public string Name_Owner { set; get; }
        public string Number_Card { set; get; }
        public int CVC_Conde { set; get; }
        public double Login_Card { set; get; }// типо оформление карты 
        public double Shutdown_Card { set; get; }// тиоп строк истечения карты

        public Card() { }
        public Card(string NB, string NO, string NC, int CVC,double LC, double SC)
        {
            Name_Banc = NB;
            Name_Owner = NO;
            Number_Card = NC;
            CVC_Conde = CVC;
            Login_Card = LC;
            Shutdown_Card = SC;
        }
        public void Enter_date()
        {
            Console.Write("Введите название банка:");
            Name_Banc = Convert.ToString(Console.ReadLine());
            Console.Write("Введите имя владельца:");
            Name_Owner = Convert.ToString(Console.ReadLine());
            Console.Write("Введите номер катры:");
            Number_Card = Convert.ToString(Console.ReadLine());
            Console.Write("Введите CVC код карты:");
            CVC_Conde = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату оформления карты Месяц/Год:");
            Login_Card = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите срок истечения карты Месяц/Год:");
            Shutdown_Card = Convert.ToDouble(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Название банка:{Name_Banc}\nИмя владельца:{Name_Owner}\nНомер карты:{Number_Card}\nCVC код карты:{CVC_Conde}\nДатa офoрмления карты:{Login_Card}\nСрок истечения карты:{Shutdown_Card }\n");
        }
        public override string ToString()
        {
            return "Название банка:{Name_Banc}\nИмя владельца:{Name_Owner}\nНомер карты:{Number_Card}\nCVC код карты:{CVC_Conde}\nДатa офoрмления карты:{Login_Card}\nСрок истечения карты:{Shutdown_Card }\n";
        }
    }
}
