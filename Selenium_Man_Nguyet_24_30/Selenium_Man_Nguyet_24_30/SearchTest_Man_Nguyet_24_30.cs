using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Drawing;

namespace Selenium_Man_Nguyet_24_30
{
    [TestClass]
    public class SearchTest_Man_Nguyet_24_30
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
        public void TestSearch_Man_Nguyet_24_30()
        {
            // nhap thong tin "laptop" vao id la small-searchterms
            string txtgt = "laptop";
            IWebElement element = driver.FindElement(By.Id("small-searchterms"));
            element.SendKeys(txtgt);
            //nhan vao btn search
            driver.FindElement(By.ClassName("search-box-button")).Click();
            //check o id=q co gia tri nhu tren khong
            driver.FindElement(By.Id("Q")).Text.Contains(txtgt);
        }
    }
    }

