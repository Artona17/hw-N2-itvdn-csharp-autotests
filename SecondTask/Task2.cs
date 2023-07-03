using OpenQA.Selenium.Chrome;

namespace SecondTask
{
    [Author("Ludmila")]
    [TestFixture]
    public class Tests
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

        [TestCase ("")]

        public void LoginField_LoginFieldIsEmpty_LoginEmptyErrorMessageIsShowing(string username)
        {            

            string loginErrorMessage = "Epic sadface: Username is required";

            IWebElement loginTxt = driver.FindElement(By.Id("user-name"));

            loginTxt.SendKeys(username);
            loginTxt.SendKeys(Keys.Enter);

            IWebElement loginError = driver.FindElement(By.CssSelector("#login_button_container > div > form > div.error-message-container.error > h3"));

            Assert.That(loginError.Text == loginErrorMessage);

            driver.Close();
        }

        [TestCase("standard_user", "")]

        public void PasswordField_PasswordFieldIsEmpty_PasswordEmptyErrorMessageIsShowing(string username, string password)
        {

            string passwordErrorMessage = "Epic sadface: Password is required";

            IWebElement loginTxt = driver.FindElement(By.Id("user-name"));
            IWebElement passwordTxt = driver.FindElement(By.Id("password"));

            loginTxt.SendKeys(username);
            passwordTxt.SendKeys(password);
            loginTxt.SendKeys(Keys.Enter);

            IWebElement passwordError = driver.FindElement(By.CssSelector("#login_button_container > div > form > div.error-message-container.error > h3"));

            Assert.That(passwordError.Text == passwordErrorMessage);
        }

        [OneTimeTearDown]
        public void OnetimeTeardown()
        {
            driver.Quit();
        }
    }
}
