using Core.Aggregates;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Linq;
using Web.Controllers;
using Web.Models;

namespace WebTests
{
    public class ProjectControllerTests
    {
        private ProjectController sut;
        private Mock<IRepository<Project>> projectRepositoryMock = new();

        [SetUp]
        public void Setup()
        {
            projectRepositoryMock.Reset();
            this.sut = new ProjectController(projectRepositoryMock.Object);
        }

        [Test]
        public void ShouldReturnNotFoundIfRepositoryReturnNull()
        {
            // Arrange
            projectRepositoryMock.Setup(x => x.GetById(It.IsAny<int>()))
                .ReturnsAsync(() => null);

            // Act
            var ret = this.sut.Index().Result as NotFoundResult;

            // Assert
            Assert.AreEqual(404, ret.StatusCode);
        }

        [Test]
        public void ShouldReturnViewIfRepositoryReturnsValidProject()
        {
            // Arrange
            Project project = new Project("Foo") { Id = 1 };
            project.AddItem(new ToDoItem() { Id = 1, Title = "Bar", Description = "Empty" });

            projectRepositoryMock.Setup(x => x.GetById(It.IsAny<int>()))
                .ReturnsAsync(() => project);

            // Act
            var retView = this.sut.Index().Result as ViewResult;
            var retModel = (retView.Model as ProjectModel);

            // Assert
            Assert.AreEqual(1, retModel.Id);
            Assert.AreEqual("Foo", retModel.Name);
            Assert.AreEqual(1, retModel.Items.Count);
            var item = retModel.Items.First();
            Assert.AreEqual(1, item.Id);
            Assert.AreEqual("Bar", item.Title);
            Assert.AreEqual("Empty", item.Description);
        }

        [Test]
        public void ShouldCallRepositoryWithProjectIdOneIfArgumentNotSpecified()
        {
            // Arrange
            int capturedId = -1;
            projectRepositoryMock.Setup(x => x.GetById(It.IsAny<int>()))
                .Callback((int id) => capturedId = id);

            // Act
            _ = this.sut.Index();

            // Assert
            Assert.AreEqual(1, capturedId);
        }

        [Test]
        public void ShouldCallRepositoryExactlyOnce()
        {
            // Act
            _ = this.sut.Index();

            // Assert
            projectRepositoryMock.Verify(x => x.GetById(It.Is<int>(x => x == 1)), Times.Once());
        }
    }
}
