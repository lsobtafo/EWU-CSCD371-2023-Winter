using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Logger.Tests
{
	public class ProductTests
	{
		public void ReadOnly_Propery_Set ()
		{
			Product product = new Product(
				Name: "AirJordan",
				Price: 1000.00,
				Description: "Really expensive shoes but they are just shoes.");
			Assert.AreEqual(1000, product Price);
		}
        public void Name_AssignmNullInInitializer_ThrowException()
        {
			Product product = new Product(
				Name: "Reebok",
				Price: 1000.00,
				Description: "Really expensive shoes but they are just shoes.")
			{ Description = "These are not quite as good as AirJordans" };
            Assert.AreEqual(1000, product Price);
			/*
			 * Positional parameter that are non-nullable should be 
			 * -> a. read-only with null check on declaration assignment
			 */
        }
		public void Equals_TwoReferences_True()
		{
			Product product1 = new Product(
				Id:42,Name: "AirJordan",
				Price: 1000.00,
				Description: "Really expensive shoes but they are just shoes.");
			Product product2 = product1 with {/*Name = "Something"*/Price=2000.00};
			Assert.IsFalse(ReferenceEquals(product1, product2));
			Assert.IsTrue(product1.Equals(product2));
            Assert.IsTrue(product1==product2);

        }
        public void Equals_TwoReferences_True()
        {
            Product product1 = new Product(
                Id: 42, Name: "AirJordan",
                Price: 1000.00,
                Description: "Really expensive shoes but they are just shoes.");
            Product product2 = product1 with {/*Name = "Something"*/Price = 2000.00 };
            Assert.IsFalse(ReferenceEquals(product1, product2));
            Assert.IsTrue(product1.Equals(product2));
            Assert.IsTrue(product1 == product2);

        }
    }
}

