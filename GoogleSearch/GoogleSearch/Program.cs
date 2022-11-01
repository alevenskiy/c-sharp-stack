using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoogleSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //необходимо чтобы в папке присутствовал chromedriver.exe
            IWebDriver driver = new ChromeDriver("C:\\Program Files\\Google\\Chrome\\Application"); 
            
            driver.Url = "https://www.google.com";

            //у поисковой строки имя "q"
            IWebElement input = driver.FindElement(By.Name("q"));

            input.SendKeys("Hello world!");
            input.SendKeys(Keys.Enter);

            using (StreamWriter sw = new StreamWriter("log.txt", false))
            {
                sw.WriteLine(driver.Title);
            }

            driver.Quit();
        }
    }
}
