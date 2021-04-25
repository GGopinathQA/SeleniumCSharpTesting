using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace SeleniumPractise
{
    public class Tests:WebdriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new FirefoxDriver("C:\\Selenium\\");
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
        }

        [Test]
        public void Test1()
        {
            Driver.FindElement(By.Id("")).Click();
            Assert.Pass();
        }
    }
}