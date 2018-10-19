using iPodInventoryProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace iPodInventoryProblemTest
{
    [TestClass]
    public class iPodInventoryProblemTest
    {
        [TestMethod]
        public void GetOptimisedPrice_Brazil_5()
        {
            var calculateOptimisedPrice = new CalculateOptimisedPrice();

            var actualOutput = calculateOptimisedPrice.GetOptimisedPrice("Brazil : 5");
            var expectedOutput = "500 : 95 : 100";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void GetOptimisedPrice_Brazil_50()
        {
            var calculateOptimisedPrice = new CalculateOptimisedPrice();

            var actualOutput = calculateOptimisedPrice.GetOptimisedPrice("Brazil : 50");
            var expectedOutput = "4500 : 100 : 50";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void GetOptimisedPrice_Argentina_120()
        {
            var calculateOptimisedPrice = new CalculateOptimisedPrice();

            var actualOutput = calculateOptimisedPrice.GetOptimisedPrice("Argentina : 120");
            var expectedOutput = "7800 : 80 : 0";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void GetOptimisedPrice_Argentina_250()
        {
            var calculateOptimisedPrice = new CalculateOptimisedPrice();

            var actualOutput = calculateOptimisedPrice.GetOptimisedPrice("Argentina : 250");
            var expectedOutput = "Out of stock";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void GetOptimisedPrice_Argentina_200()
        {
            var calculateOptimisedPrice = new CalculateOptimisedPrice();

            var actualOutput = calculateOptimisedPrice.GetOptimisedPrice("Argentina : 200");
            var expectedOutput = "19000 : 0 : 0";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
