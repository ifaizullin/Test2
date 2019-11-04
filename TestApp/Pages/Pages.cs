using System;


namespace TestApp.Pages
{
    class Pages
    {
        protected string p_address;
        public void OpenPage()
        {
            try
            {
                Browser.Instance.driver.Navigate().GoToUrl(p_address);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
        public void Maximize()
        {
            Browser.Instance.driver.Manage().Window.Maximize();
        }
    }
}
