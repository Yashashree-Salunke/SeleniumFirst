using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driverGC;
        [AssemblyInitialize ]
        public static void Setup(TestContext context )
        {
            driverGC = new ChromeDriver(@"C:\Users\admin\Downloads\chromedriver_win32");
        }

        [TestMethod ]
        public void TestChromeDriver()
        {
            driverGC.Navigate().GoToUrl("https://github.com");
            driverGC.FindElement(By.LinkText("Sign in")).Click ();
            driverGC.FindElement(By.Id("login_field")).SendKeys("Yashashree-Salunke");
            driverGC.FindElement(By.Id("password")).SendKeys("yash@1994");
            driverGC.FindElement(By.Name("commit")).Click ();
            driverGC.FindElement(By.ClassName ("$0")).Click();
            var dropdown= driverGC.FindElement(By.LinkText("Signed in as"));
            var selectelement = new SelectElement(dropdown);
            selectelement.SelectByText("Sign out");
            //driverGC.FindElement(By.XPath (".//*[@class=dropdown-item dropdown-signout']/a")).Click ();
            driverGC.Quit();
        }
    }
}
