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
    }
}
