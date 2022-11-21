using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using WebDriver = DragAndDrop.Driver.WebDriver;

namespace DragAndDrop.Page
{
    public class DragAndDropPage
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement Drag => driver.FindElement(By.Id("draggable"));

        public IWebElement Drop => driver.FindElement(By.Id("droppable"));

        public void MoveObject()
        {
            var builder = new Actions(driver);
            var DragAndDrop = builder.ClickAndHold(Drag).MoveToElement(Drop).Release(Drag).Build();
            DragAndDrop.Perform();
        }
    }
}
