using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExecutarDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Windows.Forms;

namespace Uteis
{
    public class FuncUteis
    {
        //Variaveis compartilhadas
        public static IWebDriver _driver;
                

        public static void IniciaNavegador(string Navegador, bool ExecBackground)
        {
            _driver = ExecDriver.CreateWebDriver(Navegador, ExecBackground);
        }

        public static void AdicionarURL(string URL)
        {
            _driver.Url = URL;
        }

        public static string PegaTituloDaPagina()
        {
              return _driver.Title;
        }

        public static bool ClicarEmUmLink(String NomeDoLink)
        {
            try {
                _driver.FindElement(By.LinkText(NomeDoLink)).Click();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ClicarUsandoCssSelector(String NomeDoLink)
        {
            try
            {
                _driver.FindElement(By.LinkText(NomeDoLink)).Click();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ClicarUsandoXpath(String NomeDoLink)
        {
            WebDriverWait _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            try
            {
                _wait.Until(c => c.FindElement(By.XPath(NomeDoLink)));
                _driver.FindElement(By.XPath(NomeDoLink)).Click();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public static void EncerrarExecucaoSelenium()
        {
            _driver.Close();
            _driver.Quit();
            
        }
        
    }
}
