using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        public ProductTest()
        {

        }

        [TestMethod]
        public void Should_Return_True_When_Validating_Valid_Product()
        {
            // Arrange
            var product = new Product()
            {
                Description = "My valid description",
                ProductName = "My product name",
            };

            // Act
            var validationResult = product.Validate();

            // Assert
            Assert.AreEqual(true, validationResult);
        }

        [TestMethod]
        public void Should_Return_False_When_Validating_Product_With_Invalid_Description()
        {
            // Arrange
            var product = new Product()
            {
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae risus odio. Quisque vel est ornare turpis laoreet commodo a sit amet sem. Nulla bibendum tempus ante. Morbi et lacus mollis massa tempor sagittis ut non felis. Integer nibh felis, laoreet non leo a, feugiat dictum nunc. Nam condimentum turpis tellus, lacinia sagittis felis rutrum vitae. Integer fringilla venenatis vehicula. Duis quis facilisis nisi, ac dictum purus. Quisque in dui quis urna interdum mollis nec non odio. Nullam interdum diam felis, pulvinar commodo est scelerisque a. ",
                ProductName = "My product name",
            };

            // Act
            var validationResult = product.Validate();

            // Assert
            Assert.AreEqual(false, validationResult);
        }

        [TestMethod]
        public void Should_Return_False_When_Validating_Product_With_Invalid_ProductName()
        {
            // Arrange
            var product = new Product()
            {
                Description = "My valid description",
            };

            // Act
            var validationResult = product.Validate();

            // Assert
            Assert.AreEqual(false, validationResult);
        }
    }
}
