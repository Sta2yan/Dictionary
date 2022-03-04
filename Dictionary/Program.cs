using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countryDictionary = GetCountryDictionary();
            string country;
            string exitCommand = "exit";
            bool isOpen = true;

            while (isOpen == true)
            {
                Console.WriteLine("Введите название страны, чтобы получить ее столицу:");
                country = Console.ReadLine();
                Console.Clear();

                if (countryDictionary.ContainsKey(country))
                    Console.WriteLine($"Страна - {country} | Столица - {countryDictionary[country]}");
                else if(country.Equals(exitCommand))
                    isOpen = ExitProgram();
                else
                    Console.WriteLine($"Я не нашел {country} в словаре");

                Console.ReadKey();
                Console.Clear();
            }
        }

        static Dictionary<string, string> GetCountryDictionary()
        {
            Dictionary<string, string> countryDictionary = new Dictionary<string, string>();
            countryDictionary.Add("Россия", "Москва");
            countryDictionary.Add("Нидерланды", "Амстердам");
            countryDictionary.Add("Украина", "Киев");
            countryDictionary.Add("Венгрия", "Будапешт");
            countryDictionary.Add("Польша", "Варшава");
            countryDictionary.Add("Ватикан", "Ватикан");
            countryDictionary.Add("Литва", "Вильнюс");
            countryDictionary.Add("Великобритания", "Лондон");
            countryDictionary.Add("Дания", "Копенгаген");
            countryDictionary.Add("Испания", "Мадрид");
            countryDictionary.Add("Белоруссия", "Минск");
            countryDictionary.Add("Монако", "Монако");
            countryDictionary.Add("Франция", "Париж");
            countryDictionary.Add("Чехия", "Прага");
            countryDictionary.Add("Латвия", "Рига");
            countryDictionary.Add("Италия", "Рим");
            return countryDictionary;
        }

        static bool ExitProgram()
        {
            Console.WriteLine("Выход ...");
            return false;
        }
    }
}