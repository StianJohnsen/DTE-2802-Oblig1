using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabOppgave1.Controllers;
using LabOppgave1.Models;
using LabOppgave1.Models.Entities;
using System.Collections;
using Moq;

namespace ProductUnitTest
{
    [TestClass]
    public class ProductControllerTest
    {

        private Mock<IProductRepository> _repository;


        [TestMethod]
        public void IndexReturnsNotNullResult()
        {
            // Arrange

            _repository = new Mock<IProductRepository>();

            List<Product> fakeProducts = new List<Product>
            {
                new Product { ProductId = 6, Name = "BMW 1-serie", Price = 300000m, CategoryId = 2, ManufacturerId = 2 },
                new Product { ProductId = 7, Name = "BMW 2-serie", Price = 400000m, CategoryId = 2, ManufacturerId = 2 },
                new Product { ProductId = 8, Name = "BMW 3-serie", Price = 500000m, CategoryId = 2, ManufacturerId = 2 },
                new Product { ProductId = 9, Name = "BMW 4-serie", Price = 600000m, CategoryId = 2, ManufacturerId = 2 },
                new Product { ProductId = 10, Name = "BMW 5-serie", Price = 700000m, CategoryId = 2, ManufacturerId = 2 },
            };

            _repository.Setup(x => x.GetAll()).Returns(fakeProducts);

            var controller = new ProductController(_repository.Object);

            // Act

            var result = (ViewResult)controller.Index();

            // Assert

            Assert.IsNotNull(result, "View Result is null");
        }


        [TestMethod]
        public void IndexReturnsAllProducts()
        {
            // Arrange
            _repository = new Mock<IProductRepository>();

            List<Product> fakeProducts = new List<Product>
            {
                new Product { ProductId = 6, Name = "BMW 1-serie", Price = 300000m, CategoryId = 2, ManufacturerId = 2 },
                new Product { ProductId = 7, Name = "BMW 2-serie", Price = 400000m, CategoryId = 2, ManufacturerId = 2 },
                new Product { ProductId = 8, Name = "BMW 3-serie", Price = 500000m, CategoryId = 2, ManufacturerId = 2 },
                new Product { ProductId = 9, Name = "BMW 4-serie", Price = 600000m, CategoryId = 2, ManufacturerId = 2 },
                new Product { ProductId = 10, Name = "BMW 5-serie", Price = 700000m, CategoryId = 2, ManufacturerId = 2 },
            };

            _repository.Setup(x => x.GetAll()).Returns(fakeProducts);

            var controller = new ProductController(_repository.Object);

            // Act
            var result = (ViewResult)controller.Index();
            

            // Assert
            CollectionAssert.AllItemsAreInstancesOfType((ICollection)result.ViewData.Model, typeof(Product));
            Assert.IsNotNull(result,"View Result is null");
            var products = result.ViewData.Model as List<Product>;
            Assert.AreEqual(5, products.Count, "Got wrong number of products");
        }


        [TestMethod]
        public void SaveIsCalledWhenProductIsCreated()
        {
            // Arrange
            _repository = new Mock<IProductRepository>();
            _repository.Setup(x => x.Save(It.IsAny<Product>()));
            var controller = new ProductController(_repository.Object);


            // Act
            var result = controller.Create(new LabOppgave1.Models.ViewModels.ProductEditViewModel());

            // Assert 
            _repository.VerifyAll();
        }
    }



}