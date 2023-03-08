using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LanguageService
    {
        private LanguageService() { }

        private static LanguageService _instance;

        private ILanguage language;

        private List<string> keys = new List<string>()
        {
            "WYBIERZ_FUNKCJE",
            "WYBRANA_FUNKCJA",
            "PODAJ_DOLNA_GRANICE",
            "PODAJ_GORNA_GRANICE",
            "WYBIERZ_KALKULATOR",
            "KALKULATOR_PROSTOKATOW",
            "KALKULATOR_TRAPEZOW",
            "WYBRANY_KALKULATOR",
            "WYNIK"
        };

        private Dictionary<int, List<string>> allTranslations = new Dictionary<int, List<string>>()
        {
            { 1, new List<string>()
                {
                    "Choose function",
                    "Choosed function",
                    "Specify the lower limit of the calculation",
                    "Specify the upper limit of the calculation",
                    "Choose a calculator to calculate the integral",
                    "Rectangle calculator",
                    "Trapezium calculator",
                    "Choosed calculator",
                    "Result: "
                }
            },

            { 2, new List<string>()
                {
                    "Wybierz funkcje",
                    "Wybrana funkcja",
                    "Podaj dolna granice calkowania",
                    "Podaj gorna granice calkowania",
                    "Wybierz kalkulator do obliczenia calki",
                    "Kalkulator prostokatow",
                    "Kalkulator trapezow",
                    "Wybrany kalkulator",
                    "Wynik: "
                }
            }
        };

        public static LanguageService getInstance()
        {
            if(_instance == null)
            {
                _instance = new LanguageService();
            }

            return _instance;
        }

        public ILanguage getLanguage()
        {
            return language;
        }

        public void setLanguage(ILanguage value)
        {
            language = value;
        }

        public string translate(string key)
        {
            List<string> translations = allTranslations[language.Id];
           
            for(int i = 0; i < keys.Count; i++)
            {
                if(keys[i] == key)
                {
                    return translations[i];
                }
            }
                
            return null;
        }
    }
}
