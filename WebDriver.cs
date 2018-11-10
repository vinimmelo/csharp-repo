using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BackOffice_Cockpit_Resolution
{
    class WebCockpit
    {
        //TODO: PropertyType and SelectElement
        IWebDriver driver;

        //Constructor
        public WebCockpit ()
        {
            driver = new ChromeDriver();
        }

        //Destructor
        ~WebCockpit () {
            Console.WriteLine("Encerrando o site!");
            driver.Close();
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
            if (elementtype == "Name")
                this.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click into a button, Checkbox, option etc
        public void Click(string element, string elementtype)
        {
            Console.WriteLine("Click on a element: " + element);
            if (elementtype == "Id")
                this.driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                this.driver.FindElement(By.Name(element)).Click();
        }
        
    }
}
