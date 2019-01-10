using System;
using System.Text;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace TodoListWebApp.Tests.UnitTests {

    [TestClass]
    public class TodoListPageTests {
        
        private IWebDriver driver;
        private string appURL;

        public TodoListPageTests () { }

        [TestMethod]
        [TestCategory ("Chrome")]
        public void TestAddTodoItem () {
            driver.Navigate ().GoToUrl (appURL + "/Todo");
            driver.FindElement (By.Name ("item")).SendKeys ("Todo Item 1");
            driver.FindElement (By.Id ("submit")).Click ();
            ReadOnlyCollection<IWebElement> elements = driver.FindElements (By.XPath ("//td"));
            Assert.IsTrue (elements != null);
            Assert.IsTrue (elements.Count >= 1);

            bool found = false;
            foreach (IWebElement element in elements) {
                if (element.Text == "Todo Item 1") {
                    found = true;
                    break;
                }
            }
            Assert.IsTrue(found, "Verified add item");
        }

        [TestInitialize ()]
        public void SetupTest () {
            appURL = "https://mcw-todo-app.azurewebsites.net";

            string browser = "Chrome";
            switch (browser) {
                case "Firefox":
                    driver = new FirefoxDriver ();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver ();
                    break;
                default:
                    driver = new ChromeDriver ();
                    break;
            }

        }

        [TestCleanup ()]
        public void CleanupTests () {
            if (driver != null) {
                driver.Quit ();
            }
        }
    }
}