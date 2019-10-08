using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Country
{
    class DictionaryList
    {
        private string _csvFilePath;

        public DictionaryList(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        
        public Dictionary<string, List<Country>> ReadAllCountries()
        {
            Dictionary<string, List<Country>> dicCountries = new Dictionary<string, List<Country>>();
            //using (StreamReader sr = new StreamReader(_csvFilePath))
            //{
            //    sr.ReadLine();
            //    string csvLine = string.Empty;
            //    while ((csvLine = sr.ReadLine()) != null)
            //    {
            //        if (dicCountries.ContainsKey(country.Region))
            //        {
            //            Console.WriteLine(country.Region);
            //        }
            //        else
            //        {
            //            List<Country> 
            //        }
            //    }
            //}
            return null;
        }
    }
}
