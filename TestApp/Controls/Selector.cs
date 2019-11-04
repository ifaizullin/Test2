using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;

namespace TestApp.Controls
{
    class Selector : BaseControl
    {
        public string Scroller;
        public Selector(string loc,string scroller) : base(loc)
        {
            Scroller = scroller;
        }


        public virtual void Select(string value)
        {
            try
            {
                IWebElement element = Browser.Instance.driver.FindElement(By.CssSelector(Location));
                Browser.Instance.Actions.MoveToElement
                    (element, element.Size.Width - 1, element.Size.Height - 1).Click().Build().Perform();
                FindElement(Browser.Instance.driver.FindElements
                    (By.CssSelector(Scroller)), value).Click();
            }
            catch { Console.WriteLine("Incorrect " + value); }
        }

        protected static IWebElement FindElement(ReadOnlyCollection<IWebElement> elements, string text)
        {
            foreach (var el in elements)
            {
                if (el.Text == text)
                {
                    return el;
                }
            }
            return null;
        }
    }
}
