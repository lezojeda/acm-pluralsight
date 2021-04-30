using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameValid()
        {
            // Arrange
            var customer = new Customer()
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
            };

            // Act
            string expected = customer.FullName;

            // Assert
            Assert.AreEqual("Baggins, Bilbo", expected);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Baggins",
            };

            // Act
            string expected = customer.FullName;

            // Assert
            Assert.AreEqual("Baggins", expected);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            var customer = new Customer()
            {
                FirstName = "Bilbo",
            };

            // Act
            string expected = customer.FullName;

            // Assert
            Assert.AreEqual("Bilbo", expected);
        }

        [TestMethod]
        public void Should_Return_True_When_Validating_Valid_Customer()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Baggins",
                EmailAddress = "some@email.com",
            };

            // Act
            var validationResult = customer.Validate();

            // Assert
            Assert.AreEqual(true, validationResult);
        }

        [TestMethod]
        public void Should_Return_False_When_Validating_Invalid_Customer()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Baggins",
            };

            // Act
            var validationResult = customer.Validate();

            // Assert
            Assert.AreEqual(false, validationResult);
        }
    }
}
