using OpenQA.Selenium;
using System;

namespace TestApp.Controls
{
    class InputSelector : Selector
    {
        public string Button;
        public InputSelector(string loc,string scroller,string button) : base(loc, scroller)
        {
            Button = button;
        }
        public override void Select(string value)
        {
            try
            {
                IWebElement element = Browser.Instance.driver.FindElement(By.CssSelector(Location));
                Browser.Instance.Actions.MoveToElement
                    (element, element.Size.Width - 1, element.Size.Height - 1).Click().Build().Perform();
                FindElement(Browser.Instance.driver.FindElements
                    (By.CssSelector(Scroller)), value).FindElement(By.CssSelector("span")).Click();
                Browser.Instance.driver.FindElement(By.CssSelector(Button)).Click();
            }
            catch { Console.WriteLine("Incorrect " + value); }
        }
    }
}
