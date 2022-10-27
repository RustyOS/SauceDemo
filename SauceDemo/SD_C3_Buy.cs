using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace SauceDemo
{
    internal class SD_C3_Buy
    {
        //Postavke za Chrome/Driver

        IWebDriver driver = new ChromeDriver();
        [SetUp]


        public void Initialize()
        {


            //Funkcija koja otvara facebook stranicu  
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Console.Write("WebPage is working!! \n");


            //Postavljamo preglednik u punu rezoluciju 
            driver.Manage().Window.Maximize();

            //Pauza
            Thread.Sleep(2000);



        }
        [Test]
        public void ExecuteTest3()
        {
            //----------------------------------------------------------------------//

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
            Console.Write("Login is Valid and Working! \n");
            Thread.Sleep(3000);


            //----------------------------------------------------------------------//

            //Odabir filtera najjeftinijeg proizovda
            string option = "lohi";
            By css = By.CssSelector("Select>option[value='" + option + "']");
            driver.FindElement(css).Click();
            Thread.Sleep(1000);

            //Kupovina prvog najjeftinijeg proizovda
            driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Console.Write("Add to cart is Valid! \n");
            Thread.Sleep(1000);

            //Kupovina drugog najjeftinijeg proizovda
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Console.Write("Add to cart is Valid! \n");
            Thread.Sleep(1000);


            //Kupovina treceg najjeftinijeg proizovda
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Console.Write("Add to cart is Valid! \n");
            Thread.Sleep(1000);


            //Kupovina cetvrtog najjeftinijeg proizovda
            driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Console.Write("Add to cart is Valid! \n");
            Thread.Sleep(1000);

            //Kupovina petog najjeftinijeg proizovda
            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Console.Write("Add to cart is Valid! \n");
            Thread.Sleep(1000);

            //Kupovina sestog najjeftinijeg proizovda
            driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Console.Write("Add to cart is Valid! \n");
            Thread.Sleep(1000);






            


            //Navigacija
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);


            //Navigacija
            driver.FindElement(By.Id("checkout")).Click();

            //----------------------------------------------------------------------//

            //Unos Imena
            IWebElement user = driver.FindElement(By.Id("first-name"));
            user.SendKeys("Rusty");
            Thread.Sleep(2000);
            Console.Write("Firstname value is entered! \n");

            //Unos Prezimena
            IWebElement prez = driver.FindElement(By.Id("last-name"));
            prez.SendKeys("Brown");
            Thread.Sleep(2000);
            Console.Write("Password is entered! \n");

            //Unos PostalCode
            IWebElement post = driver.FindElement(By.Id("postal-code"));
            post.SendKeys("31000");
            Thread.Sleep(2000);
            Console.Write("Postal code is entered! \n");

            //Navigacija
            driver.FindElement(By.Id("continue")).Click();
            Thread.Sleep(2000);

            //Navigacija
            driver.FindElement(By.Id("finish")).Click();
            Thread.Sleep(2000);

            driver.Navigate().Refresh();


            //----------------------------------------------------------------------//




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