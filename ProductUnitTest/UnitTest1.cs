using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabOppgave1.Controllers;
using LabOppgave1.Models;
using LabOppgave1.Models.Entities;
using System.Collections;
using LabOppgave1.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;

namespace ProductUnitTest
{
    [TestClass]
    public class ProductControllerTest
    {

        private Mock<IProductRepository> _repository;

        private Product simpleProduct = new Product
        {
            ProductId = 6, Name = "BMW 1-serie", Price = 300000m, CategoryId = 2, ManufacturerId = 2
        };

        private List<Product> productList = new List<Product>
        {
            new Product { ProductId = 6, Name = "BMW 1-serie", Price = 300000m, CategoryId = 2, ManufacturerId = 2 },
            new Product { ProductId = 7, Name = "BMW 2-serie", Price = 400000m, CategoryId = 2, ManufacturerId = 2 },
            new Product { ProductId = 8, Name = "BMW 3-serie", Price = 500000m, CategoryId = 2, ManufacturerId = 2 },
            new Product { ProductId = 9, Name = "BMW 4-serie", Price = 600000m, CategoryId = 2, ManufacturerId = 2 },
            new Product { ProductId = 10, Name = "BMW 5-serie", Price = 700000m, CategoryId = 2, ManufacturerId = 2 },
        };
        
        private List<Category> categoryList  = new List<Category>
        {
            new Category
            {
                CategoryId = 1,
                Name = "Elektronikk",
                Description =
                    "Elektronikk er en samlebetegnelse for alle produkter som er basert på elektriske komponenter",
            },
            new Category
            {
                CategoryId = 2,
                Name = "Kjøretøy",
                Description = "Kjøretøy er et fremkomstmiddel som kan transportere mennesker eller gods",

            },
            new Category
            {
                CategoryId = 3,
                Name = "Hvitevarer",
                Description = "Hvitevarer er en fellesbetegnelse på elektriske husholdningsapparater",

            }
        };

        private List<Manufacturer> manufacturerList = new List<Manufacturer>
        {
            new Manufacturer
            {
                ManufacturerId = 1,
                Name = "Apple",
                Description = "Apple er en stor produsent av elektronikk",
                Address = "20863 Stevens Creek Blvd., (Building 3, Suite C) in Cupertino, California",
            },
            new Manufacturer
            {
                ManufacturerId = 2,
                Name = "BMW",
                Description = "BMW er en stor produsent av biler",
                Address = "Petuelring 130, 80809 München, Tyskland",
            },
            new Manufacturer
            {
                ManufacturerId = 3,
                Name = "Siemens",
                Description = "Siemens er en stor produsent av hvitevarer",
                Address = "Werner-von-Siemens-Straße 1, 80333 München, Tyskland",
            }
        };

        private ProductEditViewModel simpleViewModel = new ProductEditViewModel
        {
            ProductId = 1,
            Name = "test",
            Description = "test",
            Price = 1,
            ManufacturerId = 1,
            CategoryId = 1,
            Categories = new List<Category>()
            {
                new Category
                {
                    CategoryId = 1,
                    Name = "Elektronikk",
                    Description =
                        "Elektronikk er en samlebetegnelse for alle produkter som er basert på elektriske komponenter",
                }
            },
            Manufacturers = new List<Manufacturer>()
            {
                new Manufacturer
                {
                    ManufacturerId = 1,
                    Name = "Apple",
                    Description = "Apple er en stor produsent av elektronikk",
                    Address = "20863 Stevens Creek Blvd., (Building 3, Suite C) in Cupertino, California",
                }
            }

        };
            




        [TestMethod]
        public void IndexReturnsNotNullResult()
        {
            // Arrange

            _repository = new Mock<IProductRepository>();

            

            _repository.Setup(x => x.GetAll()).Returns(productList);

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



            _repository.Setup(x => x.GetAll()).Returns(productList);

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
            // Arange 
            _repository = new Mock<IProductRepository>();
            
            
            // Expectations

            _repository
                .Setup(c => c.Save(simpleProduct))
                .Verifiable();


        }

        [TestMethod]
        public void CreateReturnsNotNullResult()
        {
            // Arange 
            _repository = new Mock<IProductRepository>();
            
            

            var fakeViewModel = new ProductEditViewModel
            {
                Categories = categoryList,
                Manufacturers = manufacturerList
            };
            
            // Expectations

            _repository.Setup(c => c.GetProductEditViewModel())
                .Returns(fakeViewModel)
                .Verifiable();
            
            var controller = new ProductController(_repository.Object);
            
            // Act
            
            var result = controller.Create() as ViewResult;
            Assert.AreEqual(fakeViewModel,result.Model as ProductEditViewModel);
        }

        [TestMethod]
        public void CreateProductEditViewModelReturnsNotNull()
        {
            
            // Arange
            _repository = new Mock<IProductRepository>();
            
            var productEditViewModel = new ProductEditViewModel
            {
                ProductId = 1,
                Name = "test",
                Description = "test",
                Price = 1,
                ManufacturerId = 1,
                CategoryId = 1,
                Categories = categoryList,
                Manufacturers = manufacturerList
            };
           
            
            // Expectations

            _repository.Setup(c => c.Save(simpleProduct))
                .Verifiable();
            
            var controller = new ProductController(_repository.Object);
            var tempData = new TempDataDictionary(new DefaultHttpContext(),
                Mock.Of<ITempDataProvider>());
            controller.TempData = tempData;
            
            // Act
            
            var result = controller.Create(productEditViewModel) as RedirectToActionResult;
            Assert.IsNotNull(result,"result != null");
            Assert.AreEqual("Index",result.ActionName);
            // Assert.AreEqual(fakeViewModel,result.Model as ProductEditViewModel);
            
            controller.ModelState.AddModelError("Name","Name is required");
            
             var result2 = controller.Create(productEditViewModel) as ViewResult ;
             Assert.IsNotNull(result2,"result2 != null");
        }

        [TestMethod]
        public void CreateExceptions()
        {
            _repository = new Mock<IProductRepository>();
            
            _repository.Setup(c=>c.Save(simpleProduct))
                .Throws(new Exception())
                .Verifiable();
            var controller = new ProductController(_repository.Object);
            var result = controller.Create(simpleViewModel) as ViewResult;
            Assert.IsNotNull(result,"result != null");
        }

        [TestMethod]
        public void EditExceptions()
        {
            _repository = new Mock<IProductRepository>();
            
            _repository.Setup(c => c.Edit(simpleProduct))
                .Throws(new Exception())
                .Verifiable();
            var controller = new ProductController(_repository.Object);
            var result = controller.Edit(1,simpleViewModel) as ViewResult;
            Assert.IsNotNull(result,"result != null");
        }
        
        [TestMethod]
        public void EditProductsByIdReturnsNotNull()
        {
            // Arange
            _repository = new Mock<IProductRepository>();

            _repository.Setup(c => c.GetProductEditViewModelById(1))
                .Returns(simpleViewModel)
                .Verifiable();
            
            var controller = new ProductController(_repository.Object);
            
            // Act

            var result = controller.Edit(1) as ViewResult;
            Assert.IsNotNull(result,"result != null");
            
            
        }

        [TestMethod]
        public void EditProductsReturnsNotNull()
        {
            // Arange
            _repository = new Mock<IProductRepository>();
            
            _repository.Setup(c => c.Edit(simpleProduct))
                .Verifiable();
            
            var controller = new ProductController(_repository.Object);
            var tempData = new TempDataDictionary(new DefaultHttpContext(),
                Mock.Of<ITempDataProvider>());
            controller.TempData = tempData;
            
            var result = controller.Edit(1,simpleViewModel) as RedirectToActionResult;
            
            Assert.IsNotNull(result,"result != null");
            
            controller.ModelState.AddModelError("Name","Name is required");
            
            var result2 = controller.Edit(1,simpleViewModel) as ViewResult ;
            Assert.IsNotNull(result2,"result2 != null");
        }

        [TestMethod]
        public void DetailsProductsReturnsNotNull()
        {
            // Arange
            _repository = new Mock<IProductRepository>();
            
            _repository.Setup(c => c.GetProductEditViewModelById(1))
                .Returns(simpleViewModel)
                .Verifiable();

            var controller = new ProductController(_repository.Object);
            
            // Act
            
            var result = controller.Details(1) as ViewResult;
            Assert.IsNotNull(result,"result != null");
        }

        [TestMethod]
        public void DeleteProductsReturnsNotNull()
        {
            // Arange
            
            _repository = new Mock<IProductRepository>();
            
            _repository.Setup(c => c.GetProductById(1))
                .Returns(simpleProduct)
                .Verifiable();
            
            var controller = new ProductController(_repository.Object);

            var result = controller.Delete(1) as RedirectToActionResult;
            Assert.IsNotNull(result,"result != null");
        }
        
    }



}