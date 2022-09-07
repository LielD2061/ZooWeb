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
    public class AnimalControllerTests
    {
        private AnimalsController _animalController;
        private IGeneralRepository _generalRepository;
        private IAdminRepository _adminRepository;
        public AnimalControllerTests()
        {
            _generalRepository = A.Fake<IGeneralRepository>();
            _adminRepository = A.Fake<IAdminRepository>();
            _animalController = new AnimalsController(_generalRepository, _adminRepository);
        }
        [Fact]
        public void AnimalsController_Index_ReturnsSuccess()
        {
            var animal = A.Fake<AllModel>();
            A.CallTo(() => _generalRepository.GetData()).Returns(animal);
            var result = _animalController.AllAnimals();
            result.Should().BeOfType<ViewResult>();
        }
        [Fact]
        public void AnimalsController_NewComment_ReturnsSuccess()
        {
            var comment = "hope";
            var animalId = 1;
            A.CallTo(() => _generalRepository.GetNewComment(comment, animalId)).Returns("Excepted");

            var result = _animalController.NewComment(comment, animalId);

            result.Should().BeOfType<RedirectToActionResult>();
        }
    }
}
