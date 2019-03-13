using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;

namespace ExecutarDriver
{
    public static class ExecDriver
    {
        public static IWebDriver CreateWebDriver(String browser, bool BackGround)
        {
            IWebDriver WebDriver = null;

            switch (browser)
            {
                case "chrome":
                    ChromeOptions chromeOption = new ChromeOptions();
                    if (BackGround)
                    {
                        chromeOption.AddArguments("--headless");
                    }

                    WebDriver = new ChromeDriver(chromeOption);

                    break;

                case "firefox":
                    FirefoxOptions firefoxOption = new FirefoxOptions();

                    
                    if (BackGround)
                    {
                        firefoxOption.AddArguments("--headless");
                    }

                    WebDriver = new FirefoxDriver(firefoxOption);

                    break;
            }


            return WebDriver;
        }
    }
}
