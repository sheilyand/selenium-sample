using NUnit.Framework;
using SeleniumSample.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace SeleniumSample.TestSuites
{
    public class Suit1
    {
        ChromeDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl(Utilities.URL+ "auth/login-page");
        }

        [Test]
        [Description("Этот тест проверяет авторизацию")]
        [Order(1)]
        public void IsLoginSuccesfull()
        {
            var loginField = driver.FindElement(By.Id("username"));
            loginField.SendKeys(Utilities.login);
            var passField = driver.FindElement(By.Id("password"));
            
            passField.SendKeys(Utilities.pass);
            passField.SendKeys(Keys.Enter);
            //var loginBtn =
            //driver.FindElement(By.XPath("//button[text()='ВОЙТИ']")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            //wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='popup']/div[1]/input")));

            var el = driver.FindElement(By.XPath("//div[contains(text(), 'Выдача и сдача книг')]"));

            Assert.That(el.Displayed);
            Assert.True(true, "тест пройден успешно");
            
            
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }
}
