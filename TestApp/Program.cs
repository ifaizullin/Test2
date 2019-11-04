using System;
using System.Linq;
using TestApp.Tests;

namespace TestApp
{    
    class Program
    {
        private static string browser = "Chrome";
        private static string country = "Romania";
        private static string language = "English";
        private static string vac;

        static void Main(string[] args)
        {
            if(!TryParse(args)) return;
            Browser.Instance.ChooseDriver(browser);
            Vac100.StartTest(country, language, vac);                    
            Browser.Instance.driver.Quit();
            Console.WriteLine("Click enter to close programm");
            Console.ReadLine();
        }

        private static bool TryParse(string[] args)
        {
            if (args.Length == 4)
            {
                try
                {                    
                    if (args[0] != "Firefox" && args[0] != "Chrome") return Error();
                    browser = args[0];
                    if (args[1].Count() > 20 || args[2].Count() > 20) return Error();
                    country = args[1];
                    language = args[2];
                    if (Int32.Parse(args[3]) > 100) return Error();
                    vac = args[3];
                    return true;
                }
                catch
                {
                    return Error();
                }

            }
            else if (args.Length == 1)
            {
                try
                {
                    if (Int32.Parse(args[0]) > 100) return Error();
                    vac = args[0];
                    return true;
                }
                catch
                {
                    return Error();
                }
            }
            else return Error();
        }

        private static bool Error()
        {
            Console.WriteLine("Please enter Browser(Firefox or Chrome), Country, Language, number of vacancies");
            Console.WriteLine("Example: TestApp.exe Firefox Romania English 31");
            Console.WriteLine("Please enter number of vacancies");
            Console.WriteLine("Example: TestApp.exe 31");
            return false;
        }
    }      


    

}
