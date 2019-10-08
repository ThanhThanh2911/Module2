using System;
using System.Collections.Generic;

namespace Country
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "E:/Module2/Baitap/country.csv";
            CsvReader reader = new CsvReader(filePath);
            Country[] countries = reader.ReadFisrtNCountries(10);

            foreach (Country item in countries)
            {
                Console.WriteLine(item.Name + ":" + item.Population +"," + item.Region+","+ item.Code);
            }

            Console.WriteLine("listCountries");
            List<Country> listCountries = reader.ReadAllCountries();

            foreach(Country item in listCountries)
            {
                Console.WriteLine(item.Name + ":" + item.Population + "," + item.Region + "," + item.Code);
            }

            Console.WriteLine("dictionaryCountries");
            Dictionary<string, Country> dictionaryCountries = reader.ReadAllCountries1();
            foreach (var item in dictionaryCountries.Values)
            {
                Console.WriteLine(item.Name + ":" + item.Population + "," + item.Region + "," + item.Code);
            }
        }
    }
}
