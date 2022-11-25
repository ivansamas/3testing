using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {


            var options = new ChromeOptions();
            options.AddArguments(@"user-data-dir=c:\Users\СМЕХ\AppData\Local\Google\Chrome\User Data\");
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver = new ChromeDriver(Directory.GetCurrentDirectory(), options);
            driver.Url = "https://www.youtube.com/";
            IWebElement firstvideo = driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/ytd-page-manager/ytd-browse/ytd-two-column-browse-results-renderer/div[1]/ytd-rich-grid-renderer/div[6]/ytd-rich-grid-row[1]/div/ytd-rich-item-renderer[1]/div/ytd-rich-grid-media/div[1]/ytd-thumbnail/a/yt-image/img"));
            firstvideo.Click();
            Thread.Sleep(300);
            IWebElement like = driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[2]/ytd-watch-metadata/div/div[2]/div[2]/div/div"));
            Actions action = new Actions(driver);
            action.MoveToElement(like);
            Thread.Sleep(300);
            IWebElement like3 = driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[2]/ytd-watch-metadata/div/div[2]/div[2]/div/div/ytd-menu-renderer/div[1]/ytd-segmented-like-dislike-button-renderer/div[1]/ytd-toggle-button-renderer/yt-button-shape"));
            like3.Click();
        }
    }
   
}
