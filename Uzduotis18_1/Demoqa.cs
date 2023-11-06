using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Uzduotis18_1
{
    public class Demoqa
    {
        [Test]

        public static void Main()
        {
            string expectedResult = "Name:Jonas Jonauskas\r\n\r\nEmail:jonas.jonauskas@gmail.com\r\n\r\nCurrent Address :Kernavės g. 20, Vilnius\r\n\r\nPermananet Address :Taikos g. 2, Neringa";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id=\"userName\"]"));
            inputFullName.SendKeys("Jonas Jonauskas");

            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
            inputEmail.SendKeys("jonas.jonauskas@gmail.com");

            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id=\"currentAddress\"]"));
            inputCurrentAddress.SendKeys("Kernavės g. 20, Vilnius");

            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id=\"permanentAddress\"]"));
            inputPermanentAddress.SendKeys("Taikos g. 2, Neringa");

            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id=\"submit\"]"));
            buttonSubmit.Click();

            string actualResult = driver.Title;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
