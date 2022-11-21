using DragAndDrop.Driver;
using DragAndDrop.Page;

namespace DragAndDrop
{
    public class Tests
    {
        DragAndDropPage _dragAndDrop;
        [SetUp]
        public void Setup()
        {
            WebDriver.Initialize();
            _dragAndDrop = new DragAndDropPage();
        }

        [Test]
        public void Test1()
        {
            _dragAndDrop.MoveObject();
        }
    }
}