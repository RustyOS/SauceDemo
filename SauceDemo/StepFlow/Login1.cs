using Docker.DotNet.Models;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SauceDemo
{
    [Binding]
    public class Login1
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"\[I have navigated to SauceDemo Website]")]
        public void GivenIHaveNavigatedToSauceDemoWebsite()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Thread.Sleep(1000);
            //Postavljamo preglednik u punu rezoluciju 
            driver.Manage().Window.Maximize();
        }

        [Given(@"\[I have enterd valid Username and Password Login Detail]")]
        public void GivenIHaveEnterdValidUsernameAndPasswordLoginDetail()
        {
            
            Thread.Sleep(1000);
            IWebElement ele = driver.FindElement(By.Id("user-name"));
            ele.SendKeys("standard_user");
            Thread.Sleep(1000);
            IWebElement ele1 = driver.FindElement(By.Id("password"));
            ele1.SendKeys("secret_sauce");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
        }

        [Then(@"\[Closing WebSite]")]
        public void ThenClosingWebSite()
        {
            Thread.Sleep(9000);
            driver.Dispose();
        }
    }
}
