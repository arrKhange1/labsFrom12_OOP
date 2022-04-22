﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab14;
using lab11;
using System.Linq;

namespace lab14.UnitTests
{
    [TestClass]
    public class MaxWorkersLINQTests
    {
        [TestMethod]
        public void CollCount5()
        {
            // Arrange
            int expected = 5;

            // Act
            Factory coll = new Factory();
            FillerForTest.Fill(coll, 5);

            int result = MaxCehWorkersLINQ.Max(coll);

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}

