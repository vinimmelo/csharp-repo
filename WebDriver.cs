using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;

namespace BackOffice_Cockpit_Resolution
{
    class WebDriver
    {
        //TODO: PropertyType and SelectElement
        IWebDriver driver;

        //Constructor
        public WebDriver ()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(1500);
        }

        //Destructor
        ~WebDriver () {
            Console.WriteLine("Encerrando o site!");
            try { driver.Quit(); }
            catch { Console.WriteLine("Chrome já encerrado!"); }
        }

        //GoTo url
        public void GoTo (string site)
        {
            Console.WriteLine("Iniciando o site!");
            driver.Navigate().GoToUrl(site);
        }

        //Text box control
        public void EnterText(string element, string value, string elementtype)
        {
            Console.WriteLine("Enter text: " + value);
            if (elementtype == "Id")
                this.driver.FindElement(By.Id(element)).SendKeys(value);
            else if (elementtype == "Name")
                this.driver.FindElement(By.Name(element)).SendKeys(value);
            else if (elementtype == "Link")
                this.driver.FindElement(By.LinkText(element)).SendKeys(value);
            else if (elementtype == "Tag")
                this.driver.FindElement(By.TagName(element)).SendKeys(value);
            else
                MissElement();
        }

        //Click into a button, Checkbox, option etc
        public void Click(string element, string elementtype)
        {
            Console.WriteLine("Click on an element: " + element);
            if (elementtype == "Id")
                this.driver.FindElement(By.Id(element)).Click();
            else if (elementtype == "Name")
                this.driver.FindElement(By.Name(element)).Click();
            else if (elementtype == "Link")
                this.driver.FindElement(By.LinkText(element)).Click();
            else if (elementtype == "Tag")
                this.driver.FindElement(By.TagName(element)).Click();
            else
                MissElement();
        }
        
        public string GetText (string element, string elementtype)
        {
            Console.WriteLine("Get Text of an element: " + element);
            if (elementtype == "Id")
                return driver.FindElement(By.Id(element)).Text;
            else if (elementtype == "Name")
                return driver.FindElement(By.Name(element)).Text;
            else if (elementtype == "Link")
                return driver.FindElement(By.LinkText(element)).Text;
            else if (elementtype == "Tag")
                return driver.FindElement(By.TagName(element)).Text;
            else
            {
                MissElement();
                return "";
            }
        }

        public IWebElement GetElement (string element, string elementtype)
        {
            Console.WriteLine("Return IWebElement: " + element);
            if (elementtype == "Id")
                return driver.FindElement(By.Id(element));
            else if (elementtype == "Name")
                return driver.FindElement(By.Name(element));
            else if (elementtype == "Link")
                return driver.FindElement(By.LinkText(element));
            else if (elementtype == "Tag")
                return driver.FindElement(By.TagName(element));
            else
            {
                MissElement();
                return null;
            }
        }

        public void Quit()
        {
            driver.Quit();
        }

        private void MissElement()
        {
            MessageBox.Show("Favor selecionar o elemento correto!");
        }

        public void Sleep(int time)
        {
            Thread.Sleep(time);
        }
    }
}
