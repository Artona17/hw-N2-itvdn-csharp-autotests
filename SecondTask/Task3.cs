using OpenQA.Selenium.Chrome;

namespace SecondTask
{
    [Author("Ludmila")]
    [TestFixture]
    public class SuccessfulTests
    {
        /// <summary>
        /// Setting up a Selenium Chrome WebDriver.
        /// </summary>
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver()
            {
                Url = "https://www.saucedemo.com/"
            };
        }

        /// <summary>
        /// Test that checks that if we are writing actual username and password we have successfully logged in.
        /// </summary>
        [Test]
        public void LoginForm_ExistingLoginAndPassword_ShowsShopPage()
        {
            string TitleOfNewPage = "Products";

            IWebElement loginTxt = driver.FindElement(By.Id("user-name"));
            IWebElement passwordTxt = driver.FindElement(By.Id("password"));

            loginTxt.SendKeys("standard_user");
            passwordTxt.SendKeys("secret_sauce");
            loginTxt.SendKeys(Keys.Enter);

            IWebElement newPageTitle = driver.FindElement(By.CssSelector("#header_container > div.header_secondary_container > span"));

            Assert.That(newPageTitle.Text == TitleOfNewPage);
        }

        /// <summary>
        /// Quitting our Chrome driver.
        /// </summary>
        [OneTimeTearDown]
        public void OnetimeTeardown()
        {
            driver.Quit();
        }
    }
}