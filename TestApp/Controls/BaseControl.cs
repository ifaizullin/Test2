using OpenQA.Selenium;
using System;
using System.Threading;

namespace TestApp.Controls
{
    class BaseControl
    {
        public string Location { get; set; }
        public BaseControl(string loc)
        {
            Location = loc;
        }
        public void VerifyEquals(string value)
        {

        }
        public void Click()
        {
            try
            {
                Browser.Instance.driver.FindElement(By.CssSelector(Location)).Click();
                Thread.Sleep(3000);
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
    }
}
