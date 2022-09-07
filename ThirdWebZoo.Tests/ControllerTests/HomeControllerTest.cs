using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdWebZoo.Controllers;
using ThirdWebZoo.Models;
using ThirdWebZoo.Repositories;

namespace ThirdWebZoo.Tests.ControllerTests
{
    public class HomeControllerTest
    {
        private HomeController _homecontroller;
        private IGeneralRepository _generalrepository;
        public HomeControllerTest()
        {
            _generalrepository = A.Fake<IGeneralRepository>();
            _homecontroller = new HomeController(_generalrepository);
        }
        [Fact]
        public void HomeController_Index_ReturnsSuccess()
        {
            var allAnimals = A.Fake<IEnumerable<Animal>>();
            A.CallTo(() => _generalrepository.GetTwoHighestComments()).Returns(allAnimals);
            var result = _homecontroller.Index();
            result.Should().NotBeNull();
            result.Should().BeOfType<ViewResult>();
        }
    }
}
