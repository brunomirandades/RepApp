using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepApp.Models;

namespace RepApp.Test
{
    [TestClass]
    public class CalculationsTest
    {
        [TestMethod]
        public void CalculateLadderTest()
        {
            int[] testTotals = Calculations.CalculateLadder(8);
            int[] comparisonTotals = new int[2];
            int comparisonReps = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8;
            int comparisonSets = 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1;

            comparisonTotals[0] = comparisonReps;
            comparisonTotals[1] = comparisonSets;

            Assert.AreEqual(testTotals[0], comparisonTotals[0]);
            Assert.AreEqual(testTotals[1], comparisonTotals[1]);
        }

        [TestMethod]
        public void CalculatePyramidTest()
        {
            int[] testTotals = Calculations.CalculatePyramid(5);
            int[] comparisonTotals = new int[2];
            int comparisonReps = 1 + 2 + 3 + 4 + 5 + 4 + 3 + 2 + 1;
            int comparisonSets = 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1;

            comparisonTotals[0] = comparisonReps;
            comparisonTotals[1] = comparisonSets;

            Assert.AreEqual(testTotals[0], comparisonTotals[0]);
            Assert.AreEqual(testTotals[1], comparisonTotals[1]);
        }

        [TestMethod]
        public void CalculateMTest()
        {
            int[] testTotals = Calculations.CalculateM(6);
            int[] comparisonTotals = new int[2];
            int comparisonReps = 1 + 2 + 3 + 4 + 5 + 6 + 5 + 4 + 3 + 2 + 1 + 2 + 3 + 4 + 5 + 6 + 5 + 4 + 3 + 2 + 1;
            int comparisonSets = 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1;

            comparisonTotals[0] = comparisonReps;
            comparisonTotals[1] = comparisonSets;

            Assert.AreEqual(testTotals[0], comparisonTotals[0]);
            Assert.AreEqual(testTotals[1], comparisonTotals[1]);
        }

        [TestMethod]
        public void CalculateVTest()
        {
            int[] testTotals = Calculations.CalculateV(5);
            int[] comparisonTotals = new int[2];
            int comparisonReps = 5 + 4 + 3 + 2 + 1 + 2 + 3 + 4 + 5;
            int comparisonSets = 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1;

            comparisonTotals[0] = comparisonReps;
            comparisonTotals[1] = comparisonSets;

            Assert.AreEqual(testTotals[0], comparisonTotals[0]);
            Assert.AreEqual(testTotals[1], comparisonTotals[1]);
        }

        [TestMethod]
        public void CalculateWTest()
        {
            int[] testTotals = Calculations.CalculateW(4);
            int[] comparisonTotals = new int[2];
            int comparisonReps = 4 + 3 + 2 + 1 + 2 + 3 + 4 + 3 + 2 + 1 + 2 + 3 + 4;
            int comparisonSets = 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1;

            comparisonTotals[0] = comparisonReps;
            comparisonTotals[1] = comparisonSets;

            Assert.AreEqual(testTotals[0], comparisonTotals[0]);
            Assert.AreEqual(testTotals[1], comparisonTotals[1]);
        }

    }
}
