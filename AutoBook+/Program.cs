// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

Console.WriteLine("Hello, World!");

//Create driver reference for the chrome
IWebDriver driver = new ChromeDriver();

//Navigate to url
driver.Navigate().GoToUrl("https://www.google.ca");

//Identify google search box
IWebElement element = driver.FindElement(By.Name("q"));

//Enter value into search box
element.SendKeys("overwatch");

Thread.Sleep(1000);

//Find search button
element = driver.FindElement(By.Name("btnK"));

//Click button
element.Click();
Thread.Sleep(3000);

//close browser
driver.Close();
Console.WriteLine("Test case ended");
