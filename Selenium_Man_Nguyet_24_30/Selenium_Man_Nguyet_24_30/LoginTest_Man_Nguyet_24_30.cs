using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium_Man_Nguyet_24_30.Test

{
    [TestClass]
    public class LoginTest_Man_Nguyet_24_30
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
        public void TestLogin_Man_Nguyet_24_30()
        {
            //Xác minh chức năng đăng nhap với dữ liệu hợp lệ
            {
                try
                {
                    //b2:Xác minh tiêu đề của trang chính
                    string title = driver.Title;
                    Assert.AreEqual(title, "Demo Web Shop");
                    //b3:Nhấp vào liên kết đăng ký
                    driver.FindElement(By.ClassName("ico-login")).Click();
                    //b5:Nhập Email
                    driver.FindElement(By.Id("Email")).SendKeys("nguyet03@gmail.com");
                    //b6:Nhập password
                    driver.FindElement(By.Id("Password")).SendKeys("123456789");
                    //b7: nhaasp vao login
                    driver.FindElement(By.ClassName("login-button")).Click();
                    /*//b7:Nhập emailaddress
                    driver.FindElement(By.Id("Email")).SendKeys(email);
                    //b8:Nhập password
                    driver.FindElement(By.Name("Password")).SendKeys("123456789");
                    //b9:Nhập confirm password
                    driver.FindElement(By.Id("ConfirmPassword")).SendKeys("123456789");
                    //b10:Nhấp vào nút đăng ký
                    driver.FindElement(By.Id("register-button")).Click();
                    // B11: Xác minh thông báo đăng ký thành công
                    String message = driver.FindElement(By.ClassName("result")).Text;
                    Assert.AreEqual(message, "Your registration completed");
                    //b12: xac nhan email
                    IWebElement emailAccount = driver.FindElement(By.XPath("//*[text()='" + email + "']"));
                    Assert.IsTrue(emailAccount.Displayed);
                    //logout
                    driver.FindElement(By.ClassName("icon-logout")).Click();*/
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }
    }
}
