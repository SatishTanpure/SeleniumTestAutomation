using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationProject
{
    internal class LoginPage
    {

        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement username => driver.FindElement(By.Id("email")); 
        private IWebElement password => driver.FindElement(By.Id("pass"));
        private IWebElement loginButton => driver.FindElement(By.Name("login"));
        private IWebElement errorMSG => driver.FindElement(By.XPath("//div[contains(text(),'Wrong credentials')]"));

        public void EnterLoginDetails(String _username, string _password)
        {
            username.SendKeys(_username);
            password.SendKeys(_password);
            loginButton.Click();
        }

        public void ValidateData(String ExpectedErrorMessage)
        {
            string ExpectedMessage = ExpectedErrorMessage;
            string ActualMesssage = errorMSG.Text;

            if (ExpectedMessage.Equals(ActualMesssage))
            {
                Assert.Pass();
            }else
            {
                Assert.Fail();
            }

        }

    }
}
