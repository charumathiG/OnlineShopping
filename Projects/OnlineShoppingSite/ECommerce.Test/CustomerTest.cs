// <copyright file="CustomerTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ECommerce.Test
{
     using EcommerceDAL;
     using EcommerceDAL.ProductsDAL;
     using Microsoft.VisualStudio.TestTools.UnitTesting;

        /// <summary>
        /// Test class for CustomerName.
        /// </summary>
     [TestClass]
     public class CustomerTest
     {
        private RegistrationModel registration;

        /// <summary>
        /// Test method for FullNameTestValid.
        /// </summary>
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            RegistrationModel customer = new RegistrationModel()
            {
                FirstName = "teena",
                LastName = "mintu",
            };
            string expected = "mintu, teena";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for ValidateValid.
        /// </summary>
        [TestMethod]
        public void ValidateValid()
        {
            // -- Arrange
            RegistrationModel customer = new RegistrationModel
            {
                LastName = "teena",
                EmailId = "teena@gmail.com",
            };
            bool expected = true;

            // -- Act
            bool actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
