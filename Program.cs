// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            // FirefoxBinary binary = new FirefoxBinary();
            FirefoxOptions options = new FirefoxOptions();//optional
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            IWebDriver driver = new FirefoxDriver(@"C:\tools\Webdrivers", options);

            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Id("W0wltc")).Click();
            driver.FindElement(By.Name("q")).SendKeys("Test Automation"+ Keys.Return);
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}