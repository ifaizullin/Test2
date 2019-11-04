using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Adapters;

namespace TestApp.Tests
{
    class Vac100
    {
        public static void StartTest(string country, string language, string vac)
        {
            Vac Vac = new Vac();
            Vac.OpenPage();
            Vac.Maximize();
            Vac.Cookie_Message.Button.Click();
            Vac.Filter.Country.Select(country);
            Vac.Filter.Language.Select(language);
            Vac.Container.ShowAll.Click();
            Vac.Container.Widjets.Count().VerifyEquals(vac);
        }


    }
}
