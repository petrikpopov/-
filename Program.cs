using System;

namespace _08._02._2023Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Card C = new Card();
            C.Enter_date();
            /////////////////
            try
            {
                string a = Console.ReadLine();
                if (a.Length < 14)
                {
                    throw new Exception("Длина пароля карты минимум 14 символов!!!!");
                }
                


            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);

            }
            //////////////////
            try
            {
                int b = Convert.ToInt32(Console.ReadLine());
                if (b > 3)
                {
                    throw new Exception("Длина CVC кода должна быть больше 3 символов !!!!");
                }
            }
            catch (Exception b)
            {
                Console.WriteLine(b.Message);
            }
            ////////////////////
            try
            {
                double l = Convert.ToDouble(Console.ReadLine());
                double s = Convert.ToDouble(Console.ReadLine());
                if (l > s)
                {
                    throw new Exception("Срок годности карты истек !!!!");
                }
                else
                {
                    throw new Exception("Карта годна!!!!");
                }
            }
            catch (Exception с)
            {
                Console.WriteLine(с.Message);
            }
            //C.Print();







           

        }
    }
}
