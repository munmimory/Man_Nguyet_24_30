using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace Selenium_Man_Nguyet_24_30
{
    [TestClass]

    public class MenuTest_Man_Nguyet_24_30
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
        public void TestMenu_Man_Nguyet_24_30()
        {
            driver.FindElement(By.XPath("//a[contains(@href, '/books')]")).Click();

            // Tìm phần tử có class "current-item"
            driver.FindElement(By.ClassName("page-title")).Text.Contains("Books");


        }
    }
}
