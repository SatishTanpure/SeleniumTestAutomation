using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomationProject
{
    public class Tests
    {

        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Users\Admin\Downloads\chromedriver_win32");

            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
        }

        [Test]
        public void Test1()
        {
            LoginPage LP = new LoginPage(driver);

            LP.EnterLoginDetails("dfsf", "sfs");

            Thread.Sleep(5000);

            LP.ValidateData("Wrong credentials");
            
        }
        [Test]
        public void Test2()
        { }
        [Test]
        public void Test3()
        { }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }

    }
}