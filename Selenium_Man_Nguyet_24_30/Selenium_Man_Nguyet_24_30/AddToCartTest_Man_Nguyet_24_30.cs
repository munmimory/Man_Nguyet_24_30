using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;

namespace Selenium_Man_Nguyet_24_30
{
    [TestClass]
    public class AddToCartTest_Man_Nguyet_24_30
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
            // Bước 1: Lấy số lượng hiện tại trong giỏ hàng
            IWebElement sl = driver.FindElement(By.ClassName("cart-qty"));
            string txtsl = sl.Text;
            int intsl = int.Parse(txtsl.Trim('(', ')'));

            // Tìm tất cả các nút "Add to cart" trên trang web
            ReadOnlyCollection<IWebElement> addToCartButtons = driver.FindElements(By.CssSelector("input.button-2.product-box-add-to-cart-button"));
            // click vao nut thu 2
            addToCartButtons[1].Click();
            System.Threading.Thread.Sleep(3000);
            // Bước 4: Kiểm tra số lượng sản phẩm trong giỏ hàng đã tăng lên
            IWebElement updatedCartQtyElement = driver.FindElement(By.ClassName("cart-qty"));
            string updatedQtyText = updatedCartQtyElement.Text;
            int updatedQty = int.Parse(updatedQtyText.Trim('(', ')'));
            Assert.AreEqual(intsl + 1, updatedQty, "Số lượng sản phẩm trong giỏ hàng không tăng lên đúng cách.");

        }
        }
}
