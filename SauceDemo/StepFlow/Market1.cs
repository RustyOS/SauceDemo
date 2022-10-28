using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SauceDemo
{
    [Binding]
    public class Market1
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"\[I have navigated to SauceDemo website]")]
        public void GivenIHaveNavigatedToSauceDemoWebsite()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Thread.Sleep(1000);
            //Postavljamo preglednik u punu rezoluciju 
            driver.Manage().Window.Maximize();
        }

        [Given(@"\[I have entered Login Detail]")]
        public void GivenIHaveEnteredLoginDetail()
        {
            IWebElement ele = driver.FindElement(By.Id("user-name"));
            ele.SendKeys("standard_user");
            Thread.Sleep(2000);
            IWebElement ele1 = driver.FindElement(By.Id("password"));
            ele1.SendKeys("secret_sauce");
            Thread.Sleep(2000);
            //Click on the Login button 
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(2000);
        }

        [Given(@"\[I buy one item from the store]")]
        public void GivenIBuyOneItemFromTheStore()
        {
            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
        }

        [Then(@"\[I add to cart and finish shopping]")]
        public void ThenIAddToCartAndFinishShopping()
        {
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("checkout")).Click();
            IWebElement user = driver.FindElement(By.Id("first-name"));
            user.SendKeys("Rusty");
            Thread.Sleep(2000);
            IWebElement prez = driver.FindElement(By.Id("last-name"));
            prez.SendKeys("Brown");
            Thread.Sleep(2000);
            IWebElement post = driver.FindElement(By.Id("postal-code"));
            post.SendKeys("31000");
            driver.FindElement(By.Id("continue")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("finish")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
        }

        [Then(@"\[Close WebSite]")]
        public void ThenCloseWebSite()
        {
            Thread.Sleep(9000);
            driver.Dispose();
        }
    }
}
