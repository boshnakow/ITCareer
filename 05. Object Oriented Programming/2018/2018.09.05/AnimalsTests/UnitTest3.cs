﻿using System;
using Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalsTests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void AnimalEat()
        {
            // Arrange
            Type animal = typeof(Animal); // Get type pointer
            // Act
            var method = animal.GetMethod("Eat");
            // Assert
            Assert.IsTrue(method.ReturnType == typeof(void));
        }

        [TestMethod]
        public void DogTest()
        {
            // Arrange
            Type animal = typeof(Dog); // Get type pointer
            // Act
            var method = animal.GetMethod("Bark");
            // Assert
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void TestMethod()
        {
            // Arrange
            Type animal = typeof(Cat); // Get type pointer
            // Act
            var method = animal.GetMethod("Meow");
            // Assert
            Assert.IsTrue(method.ReturnType == typeof(void));
        }

        [TestMethod]
        public void EatParameters()
        {
            // Arrange
            Type animal = typeof(Dog); // Get type pointer
            // Act
            var method = animal.GetMethod("Bark");
            // Assert
            Assert.IsTrue(method.GetParameters().Length == 0);
        }

        [TestMethod]
        public void EatReturnType()
        {
            // Arrange
            Type animal = typeof(Cat); // Get type pointer
            // Act
            var method = animal.GetMethod("Meow");
            // Assert
            Assert.IsTrue(method.ReturnType == typeof(void));
        }

        [TestMethod]
        public void BarkParameters()
        {
            // Arrange
            Type animal = typeof(Dog); // Get type pointer
            // Act
            var method = animal.GetMethod("Bark");
            // Assert
            Assert.IsTrue(method.GetParameters().Length == 0);
        }

        [TestMethod]
        public void InheritanceCat()
        {
            // Arrange
            Type animal = typeof(Cat); // Get type pointer
            // Act & Assert
            Assert.IsTrue(animal.BaseType == typeof(Animal));
        }

        [TestMethod]
        public void InheritanceDog()
        {
            Type animal = typeof(Dog); // Get type pointer

            Assert.IsTrue(animal.BaseType == typeof(Animal));
        }
    }
}
