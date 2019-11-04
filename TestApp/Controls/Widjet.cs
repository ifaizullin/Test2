using OpenQA.Selenium;
using System.Linq;
using TestApp.Verify;

namespace TestApp.Controls
{
    class Widjet : BaseControl
    {
        public Widjet(string loc) : base(loc)
        {

        }

        public VerifyValue Count()
        {

            return new VerifyValue(Browser.Instance.driver.FindElements
                (By.CssSelector(Location))
                .Count().ToString());            
            
        }

    }
}
