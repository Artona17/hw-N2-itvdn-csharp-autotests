using OpenQA.Selenium.Chrome;

namespace SecondTask
{
    public class GoogleTests
    {
        /// <summary>
        /// A simple test that checks that we really are at google.com.
        /// </summary>

        [Test]
        public void GoogleTitle()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";

            string title = driver.Title;
            Console.WriteLine(title);

            Assert.Pass();

            driver.Close();
        }
    }
}