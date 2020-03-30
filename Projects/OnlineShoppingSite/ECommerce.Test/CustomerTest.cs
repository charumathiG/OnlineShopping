using EcommerceDAL;
using EcommerceDAL.ProductsDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECommerce.Test
{
    [TestClass]
    public class CustomerTest
    {
        public RegistrationModel registration;
       
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            RegistrationModel customer = new RegistrationModel()
            {
                FirstName = "teena",
                LastName="mintu"

            };
            string Expected = "mintu, teena";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // -- Arrange
            RegistrationModel customer = new RegistrationModel
            {
                LastName = "teena",
                CustomerEmail = "teena@gmail.com"
            };
            bool Expected = true;

            // -- Act
            bool actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(Expected, actual);


        }
    }

        
    
}
