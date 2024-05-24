using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace Selenium_Man_Nguyet_24_30
{
    [TestClass]
    public class SubscribeTest_Man_Nguyet_24_30
    {
        IWebDriver driver;
        
        [TestInitialize]
        public void Init()
        {
            //b1:tạo một instance cho WebDriver
            driver = new ChromeDriver();
            //Khởi động trình duyệt và điều hướng đến địa chỉ trang web
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Manage().Window.Maximize();

        }
        [TestMethod]
        public void TestMethod1()
        {
            String email = "nguyet03@gmail.com";
            //nhap mail vao newsletter-email voi dinh dang xxx@gmail.com
            driver.FindElement(By.Id("newsletter-email")).SendKeys(email);
            //nhay vao nut subscribe
            driver.FindElement(By.Id("newsletter-subscribe-button")).Click();
            //ktra xem co thanh cong khong
            //Thank you for signing up! A verification email has been sent. We appreciate your interest.
            System.Threading.Thread.Sleep(3000);
            string success = "Thank you for signing up! A verification email has been sent. We appreciate your interest.";
            driver.FindElement(By.ClassName("newsletter-result-block")).Text.Contains(success);
        }
    }
}
//newsletter-email