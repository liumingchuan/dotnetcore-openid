using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoListService.Controllers;
using TodoListService.Models;

namespace TodoListService.Tests.UnitTests
{
    [TestClass]
    public class TodoListServiceTests
    {

        [TestMethod]
        public void ReturnEnumerable()
        {
            TodoListController controller = new TodoListController();
            Assert.IsNotNull(controller);
            IEnumerable<TodoItem> result = controller.Get();
            Assert.IsNotNull(result);

            var collection = result as ICollection<TodoItem>;
            Assert.IsTrue(collection.Count == 0);
        }
    }
}