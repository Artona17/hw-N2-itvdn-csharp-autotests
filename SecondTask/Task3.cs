using OpenQA.Selenium.Chrome;

namespace SecondTask
{
    [Author("Ludmila")]
    [TestFixture]
    public class SuccessfulTests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver()
            {
                Url = "https://www.saucedemo.com/"
            };
        }

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

        [OneTimeTearDown]
        public void OnetimeTeardown()
        {
            driver.Quit();
        }
    }
}