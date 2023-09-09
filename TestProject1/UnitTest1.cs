using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
            driver.Url = "https://beta.jobarmer.com";
            driver.FindElement(By.Name("UserName")).SendKeys("Mathi");
            driver.FindElement(By.Name("Password")).SendKeys("12345678");
            driver.FindElement(By.XPath("//button[.='Login']")).Click();
            string actualText = driver.FindElement(By.CssSelector("a[href = '/dashboard']")).Text;
            string expectedText = "Dashboard";
            Assert.AreEqual(expectedText, actualText);
        }
    }
}