using OpenQA.Selenium.Chrome;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var driver = new ChromeDriver("Drivers"))
            {
                driver.Url = @"http://www.google.com";

                var query = driver.FindElementByName("q");
                
                query.SendKeys("Cheese");
                query.Submit();
            }
        }
    }
}
