using NUnit.Framework;

namespace MatrixTrace.Tests
{
    [TestFixture]
    public class MatrixTest
    {
        int[,] nums = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };

        [Test]
        public void Test_FindTraceOfMatrix_With_Valid_Integers()
        {
            var matrix = new Matrix(nums);
            Assert.AreEqual(12, matrix.FindTraceOfMatrix());
        }

        [Ignore("Ignore test")]
        public void Test_To_Ignore()
        {

        }
    }
}