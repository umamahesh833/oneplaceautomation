using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.ebay.co.uk/");

            Driver.Manage().Window.Maximize();

            //Default load time
            Thread.Sleep(5000);

            //page load time
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            //Implicit wait
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);




            IWebElement link = Driver.FindElement(By.XPath("(//a[text()='Electronics'])[2]"));
            IWebElement Link2 = Driver.FindElement(By.XPath("//a[text()='News']"));


            //Explicit wait
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(link));

            Actions Act = new Actions(Driver);
            //Hover mouse cursor
            Act.MoveToElement(link).Build().Perform();
            //DragAndDrop
            Act.DragAndDrop(link, Link2).Build().Perform();



            
            // 
            // Driver.FindElement(By.XPath("//a[text()='REGISTER']")).Click();

            //IWebElement SelectDropdown = Driver.FindElement(By.XPath("//select[@name='country']"));


            // SelectElement d = new SelectElement(SelectDropdown);
            // d.SelectByText("FRANCE ");


            System.Threading.Thread.Sleep(15000);

        }
    }
}
