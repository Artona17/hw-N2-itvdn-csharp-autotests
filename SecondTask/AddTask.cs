using OpenQA.Selenium.Chrome;

namespace SecondTask
{
    public class GoogleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GoogleTitle()
        {
            IWebDriver driver;
            driver = new ChromeDriver();

            driver.Url = "https://www.google.com/";
            string currentUrl = driver.Url;

            string title = driver.Title;
            Console.WriteLine(title);

            driver.Close();

            Assert.Pass();
        }
    }
}