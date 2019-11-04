using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace TestApp
{
    class Browser
    {
        public IWebDriver driver;
        private static Browser _instance;
        private Actions _action;
        public Actions Actions
        {
            get
            {
                if (_action == null)
                {
                    _action = new Actions(_instance.driver);
                }
                return _action;
            }

        }

        public static Browser Instance
        {
            get {
                if (_instance == null)
                    {
                        _instance = new Browser();
                    }
                return _instance;
                }        
        }

        

        public void ChooseDriver(string driv)
        {
            if (driv == "Chrome")
            {
                driver = new ChromeDriver();
            }
            if (driv == "Firefox")
            {
                driver = new FirefoxDriver();
            }
        }
    }
}
