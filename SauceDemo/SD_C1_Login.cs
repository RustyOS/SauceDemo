using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SauceDemo_Login
{
    internal class SD_C1_Login
    {
        //Postavke za Chrome/Driver

        IWebDriver driver = new ChromeDriver();
        [SetUp]


        public void Initialize()
        {


            //Funkcija koja otvara facebook stranicu  
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");


            //Postavljamo preglednik u punu rezoluciju 
            driver.Manage().Window.Maximize();

            //Pauza
            Thread.Sleep(2000);



        }
        [Test]
        public void ExecuteTest()
        {

            //Pauza
            Thread.Sleep(3000);

            //Pronalazak forme za login (UserName)
            IWebElement ele = driver.FindElement(By.Id("user-name"));

            //Unos Username
            ele.SendKeys("standard_user");
            Thread.Sleep(2000);
            Console.Write("Username value is entered! \n");

            //Pronalazak forme za login (Password)
            IWebElement ele1 = driver.FindElement(By.Id("password"));

            //Unos Password
            ele1.SendKeys("secret_sauce");
            Console.Write("Password is entered! \n");


            Thread.Sleep(3000);
            //Click on the Login button 
            driver.FindElement(By.Id("login-button")).Click();
            Console.Write("login button is clicked \n");
            Thread.Sleep(3000);





        }
        [TearDown]
        public void EndTest()
        {
            //Pauza
            Thread.Sleep(9000);

            //Zatvaranje Chrome
            driver.Dispose();
        }
    }
}