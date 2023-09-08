// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        // Initialize the ChromeDriver
        IWebDriver driver = new ChromeDriver();

        // Navigate to the webpage
        driver.Navigate().GoToUrl("http://app.cloudqa.io/home/AutomationPracticeForm");

        try
        {
            Thread.Sleep(2000);
            // Locate and interact with the First Name field
            IWebElement firstNameField = driver.FindElement(By.Id("fname"));
            firstNameField.SendKeys("Reena");

            Thread.Sleep(2000);

            // Locate and interact with the Last Name field
            IWebElement lastNameField = driver.FindElement(By.Id("lname"));
            lastNameField.SendKeys("Raj");

            Thread.Sleep(2000);

            // Locate and interact with the Date of Birth field
            IWebElement dobField = driver.FindElement(By.Id("dob"));
            dobField.SendKeys("2003-08-01");

            // Add any additional steps for testing the fields here

            // Pause to visually verify the changes (optional)
            System.Threading.Thread.Sleep(5000);
        }
        finally
        {
            // Close the browser window
           // driver.Quit();
           //Remove the comment of the above line to allow closing of window on its own
        }
    }
}







