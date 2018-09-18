using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SeleniumFirst
{
    [Binding]
    public class CreateUserSteps
    {
        static IWebDriver Chromedriver;

        [AssemblyInitialize]
        public static void Setup(TestContext context)
        {
            Chromedriver = new ChromeDriver(@"C:\Users\admin\Downloads\chromedriver_win32");

        }
        [Given(@"I am on the Index page")]
        public void GivenIAmOnTheIndexPage()
        {
            Chromedriver.Navigate().GoToUrl("http://localhost:50771");
        }
        
        [When(@"I click on Create new link")]
        public void WhenIClickOnCreateNewLink()
        {
            Chromedriver.FindElement(By.LinkText("Create New")).Click();
        }
        
        [When(@"I fill all the details on the Create user page")]
        public void WhenIFillAllTheDetailsOnTheCreateUserPage()
        {
            Chromedriver.FindElement(By.Id("UserName")).SendKeys("Yashashree");
            Chromedriver.FindElement(By.Id("UserAge")).SendKeys("23");
            Chromedriver.FindElement(By.Id("DepartmentId")).SendKeys("Admin");
        }
        
        [When(@"I Click on Create button")]
        public void WhenIClickOnCreateButton()
        {
            Chromedriver.FindElement(By.LinkText("Create")).Click();
        }
        
        [Then(@"I navigate to the Index page")]
        public void ThenINavigateToTheIndexPage()
        {
            Chromedriver.Close();
        }
    }
}
