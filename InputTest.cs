using System;

namespace Input_Ouput._03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;
            try
            {
                Console.WriteLine("Введіть число: ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ви ввели число " + number);
            }
            catch(FormatException)
            {
                Console.WriteLine("Помилка введення! Введіть число!");
            }
            Console.ReadKey(true);

        }
    }
}
