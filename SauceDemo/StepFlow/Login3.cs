using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SauceDemo
{
    [Binding]
    public class Login3
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"\[I have navigated to SauceDemo Website Third Time]")]
        public void GivenIHaveNavigatedToSauceDemoWebsiteThirdTime()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Thread.Sleep(1000);
            //Postavljamo preglednik u punu rezoluciju 
            driver.Manage().Window.Maximize();
        }

        [Given(@"\[I have enterd valid Username and Corected Password Login Detail]")]
        public void GivenIHaveEnterdValidUsernameAndCorectedPasswordLoginDetail()
        {

            Thread.Sleep(1000);
            IWebElement ele = driver.FindElement(By.Id("user-name"));
            ele.SendKeys("problem_user");
            Thread.Sleep(1000);
            IWebElement ele1 = driver.FindElement(By.Id("password"));
            ele1.SendKeys("secret_sauce");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
        }

        [Then(@"\[Closing WebSite Third Time]")]
        public void ThenClosingWebSiteThirdTime()
        {
            Thread.Sleep(9000);
            driver.Dispose();
        }
    }
}
