using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testWebApp;
using testWebApp.Controllers;

namespace testWebApp.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void IndexHasResult()
        {
            // Arrange
            UserController controller = new UserController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexPostTest()
        {
            // Arrange
            UserController controller = new UserController();
            Models.UserModel model = new Models.UserModel { FirstName = "", LastName = "", Email = "test@email.com", Password = "password", ConnectionString =
                "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True" };

            // Act
                ViewResult result = controller.Index(model) as ViewResult;
            
            // Assert
            Assert.IsNotNull(result.ViewData);
        }

        [TestMethod]
        public void IndexPostTestWhenHaveNameValues()
        {
            // Arrange
            UserController controller = new UserController();
            Models.UserModel model = new Models.UserModel
            {
                FirstName = "Liam",
                LastName = "Butler",
                Email = "test@email2.com",
                Password = "password",
                ConnectionString =
                "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True"
            };

            // Act
            ViewResult result = controller.Index(model) as ViewResult;

            // Assert
            Assert.IsNotNull(result.ViewData);
        }
    }
}
