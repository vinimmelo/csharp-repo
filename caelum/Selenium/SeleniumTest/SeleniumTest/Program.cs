using System;
using OpenQA.Selenium;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WebDriver web = new WebDriver();
            IWebElement el = web.GetElement("q", "Name");
            el.SendKeys("Caelum Website");
            el.Submit();
            web.Sleep(3000);
            web.Quit();

        }
    }
}
