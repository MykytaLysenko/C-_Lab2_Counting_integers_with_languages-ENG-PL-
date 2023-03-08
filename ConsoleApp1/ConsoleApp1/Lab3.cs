using ConsoleApp1.language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lab3
    {

        List<IFunction> funkcje = new List<IFunction>()
        {
            new Function1(),
            new Function2(),
            new Function3(),
            new Function4()
        };

        List<ICalculator> kalkulatory = new List<ICalculator>()
        {
            new RectangleCalculator(),
            new TrapeziumCalculator()
        };

        List<ILanguage> dostepneJezyki = new List<ILanguage>()
        {
            new Language1(),
            new Language2()
        };

        IFunction wybranaFunkcja;
        ICalculator wybranyCalculator;

        double rangeFrom;
        double rangeTo;

        LanguageService langService;

        public void init()
        {
            

            try
            {
                Console.WriteLine("Wybierz jezyk: ");

                foreach(var jezyk in dostepneJezyki)
                {
                    Console.WriteLine(jezyk.Id + "." + jezyk.Name);
                }

                int idJezyka = Convert.ToInt32(Console.ReadLine());
                ILanguage wybranyJezyk = new LanguageFactory().getLanguage(idJezyka);

                langService = LanguageService.getInstance();
                langService.setLanguage(wybranyJezyk);

                Console.WriteLine(langService.translate("WYBIERZ_FUNKCJE"));

                foreach (IFunction funkcja in funkcje)
                {
                    Console.WriteLine(funkcja.Id + "." + funkcja.Name);
                }
    
                int idFunkcji = Convert.ToInt32(Console.ReadLine());

                wybranaFunkcja = new FunctionFactory().getFunction(idFunkcji);
                Console.WriteLine(langService.translate("WYBRANA_FUNKCJA") + ": " + wybranaFunkcja.Name);

                Console.WriteLine(langService.translate("PODAJ_DOLNA_GRANICE"));
                rangeFrom = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(langService.translate("PODAJ_GORNA_GRANICE"));
                rangeTo = Convert.ToDouble(Console.ReadLine());

                

                Console.WriteLine(langService.translate("WYBIERZ_KALKULATOR"));

                foreach (ICalculator kalk in kalkulatory)
                {
                    Console.WriteLine(kalk.Id + "." + kalk.Name);
                }

                int idKalkulatora = Convert.ToInt32(Console.ReadLine());
                wybranyCalculator = new CalculatorFactory().getCalculator(idKalkulatora);
                Console.WriteLine(langService.translate("WYBRANY_KALKULATOR") + ": " + wybranyCalculator.Name);

                double wynik = wybranyCalculator.getIntegralValue(wybranaFunkcja, rangeFrom, rangeTo);
                Console.WriteLine(langService.translate("WYNIK") + wynik.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine(langService.translate("MUSISZ_PODAC_LICZBE"));
                return;
            }
        }
    }
}
