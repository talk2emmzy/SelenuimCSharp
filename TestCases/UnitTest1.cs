using NUnit.Framework;
using OmsSeleniumFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace OmsSeleniumFramework.TestCases
{
    public class Tests : BaseSetUp
    {

        [Test]
        public void EndTOEndTest()
        {
            driver.FindElement(By.XPath("//input[@placeholder='hello@gmail.com']")).SendKeys("07087832012");
            driver.FindElement(By.XPath("//input[@placeholder='password']")).SendKeys("omnibiz@123");
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]")).Click();

        }
    }
}