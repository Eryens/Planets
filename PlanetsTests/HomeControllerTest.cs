using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Planets.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsTests
{
    [Category("Controller Test")]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    [Parallelizable(ParallelScope.Self)]
    internal class HomeControllerTest
    {
        ILogger<HomeController> logger;

        [SetUp] 
        public void SetUp() 
        {
            var mock = new Mock<ILogger<HomeController>>();
            logger = mock.Object;
        }

        [Test]
        public void Index_ReturnsPage()
        {
            // Arrange
            HomeController controller = new HomeController(logger);

            // Act
            ViewResult result = (ViewResult)controller.Index();

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void Index_ReturnsContainsModel()
        {
            // Arrange
            HomeController controller = new HomeController(logger);

            // Act
            ViewResult result = (ViewResult)controller.Index();

            // Assert
            Assert.IsNotNull(result.Model);
        }
    }
}
