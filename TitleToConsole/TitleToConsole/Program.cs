using System;
using OpenQA.Selenium.Chrome;


namespace TitleToConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            var path = @"https://www.google.com/search?q=Hello+World&rlz=1C1SQJL_ruUZ876UZ876&ei=kb1vY63eMcqFrwTnuYPYDg&ved=0ahUKEwjt6uiy_Kj7AhXKwosKHefcAOsQ4dUDCA8&uact=5&oq=Hello+World&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCC4Q1AIQgAQQQzIECAAQQzIFCAAQgAQyCgguENQCEIAEEEMyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDoKCAAQRxDWBBCwAzoHCAAQsAMQQzoNCAAQ5AIQ1gQQsAMYAToPCC4Q1AIQyAMQsAMQQxgCOgwILhDIAxCwAxBDGAI6CAgAEAcQHhAKOgYIABAHEB46BwgAEIAEEApKBAhNGAFKBAhBGABKBAhGGAFQ7gVYoBhgnRpoAXABeACAAZ0BiAHIBZIBAzAuNZgBAKABAcgBEcABAdoBBggBEAEYCdoBBggCEAEYCA&sclient=gws-wiz-serp";
            
            driver.Navigate().GoToUrl(path);
            string title = driver.Title;
           
            Console.WriteLine(title);
            Console.Read();
        }
    }
}
