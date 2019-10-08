using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Country
{
    class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public Country[] ReadFisrtNCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];

            using(StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();
                for (int i = 0; i < nCountries; i++)
                {
                    string CsvLine = sr.ReadLine();
                    countries[i] = ReadCountryFromCsvLine(CsvLine);
                }
            }

            return countries;
        }

        

        public Country ReadCountryFromCsvLine(string CsvLine)
        {
            string[] parts = CsvLine.Split(new char[] { ',' });

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = Int32.Parse(parts[3]);

            return new Country(name, code, region, population);
        }

        public List<Country> ReadAllCountries()
        {
            List<Country> countries = new List<Country>();

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();
                string csvLine = string.Empty;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromAllCsvLine(csvLine));
                }               
            }
            return countries;
        }

        public Country ReadCountryFromAllCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ',' });

            string name;
            string code;
            string region;
            int population;

            switch (parts.Length)
            {
                case 4:
                    name = parts[0];
                    code = parts[1];
                    region = parts[2];                    
                    try
                    {
                        population = Int32.Parse(parts[3]);
                    }
                    catch
                    {
                        population = 00;
                    }
                    return new Country(name, code, region, population);
                case 5:
                    name = parts[0] + parts[1];
                    name = name.Replace("\"", null).Trim();
                    name = name.Replace(".", null).Trim();
                    code = parts[2];
                    region = parts[3];
                    try
                    {
                        population = Int32.Parse(parts[4]);
                    }
                    catch
                    {
                        population = 00;
                    }
                    return new Country(name, code, region, population);
                default:
                    break;
            }
            return null;
        }

        public Dictionary<string, Country> ReadAllCountries1()
        {
            Dictionary<string, Country> countries = new Dictionary<string, Country>();
            using(StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();
                string csvLine = string.Empty;

                while ((csvLine = sr.ReadLine()) != null)
                {
                    Country country = ReadCountryFromAllCsvLine2(csvLine);
                    countries.Add(country.Code, country);
                }
            }
            return null;
        }

        public Country ReadCountryFromAllCsvLine2(string csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ',' });

            string name;
            string code;
            string region;
            int population;

            switch (parts.Length)
            {
                case 4:
                    name = parts[0];
                    code = parts[1];
                    region = parts[2];
                    try
                    {
                        population = Int32.Parse(parts[3]);
                    }
                    catch
                    {
                        population = 00;
                    }
                    return new Country(name, code, region, population);
                case 5:
                    name = parts[0] + "," + parts[1];
                    name = name.Replace("\"", null).Trim();
                    code = parts[2];
                    region = parts[3];
                    try
                    {
                        population = Int32.Parse(parts[4]);
                    }
                    catch
                    {
                        population = 00;
                    }
                    return new Country(name, code, region, population);
                default:
                    break;
            }
            return null;
        }
    }
}
