using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumCSharpExample.Tests
{
    
    public class BaseTests
    {

        public static IWebDriver Driver { get; private set; }

        
        public static IWebDriver GetDriver()
        {
         //   Driver = new FirefoxDriver();
            Driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            return Driver;
        }

    
    }
}