using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matrix.Tests
{
    [TestClass]
    public class TestTraversibleMatrix
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestFillMatrix_WithRowColOutsideRange()
        {
            int[,] matrix = new int[3, 3];
            int posX = 3, posY = 2;

            TraversableMatrix.FillMatrix(matrix, ref posX, ref posY);
        }

        [TestMethod]        
        public void TestAdjacentCellNotTraversable_AtDeadEnd()
        {
            int[,] matrix = new int[,]{
                                       {1, 2, 3},
                                       {0, 5, 6},
                                       {7, 8, 9}
                                    };
            int posX = 0, posY = 2;

            var result = TraversableMatrix.AdjacentCellsNotTraversable(matrix, posX, posY);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAdjacentCellNotTraversable_WithOnePosFree()
        {
            int[,] matrix = new int[,]{
                                       {1, 2, 3},
                                       {4, 0, 6},
                                       {7, 8, 9}
                                    };
            int posX = 0, posY = 2;

            var result = TraversableMatrix.AdjacentCellsNotTraversable(matrix, posX, posY);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestFindFreeCell_WithTwoPosFree()
        {
            int[,] matrix = new int[,]{
                                       {1, 2, 0},
                                       {4, 0, 6},
                                       {7, 8, 9}
                                    };
            int posX = 0, posY = 0;

            TraversableMatrix.FindFreeCell(matrix, out posX, out posY);
            Assert.AreEqual(0, posX);
            Assert.AreEqual(2, posY);
        }

        [TestMethod]
        public void TestFindFreeCell_WithNoPosFree()
        {
            int[,] matrix = new int[,]{
                                       {1, 2, 3},
                                       {4, 5, 6},
                                       {7, 8, 9}
                                    };
            int posX = 2, posY = 2;

            TraversableMatrix.FindFreeCell(matrix, out posX, out posY);
            Assert.AreEqual(0, posX);
            Assert.AreEqual(0, posY);
        }

        [TestMethod]
        public void TestPrintMatrix_Dimensions3by3()
        {
            int[,] matrix = new int[,]{
                                       {1, 2, 3},
                                       {4, 5, 6},
                                       {7, 8, 9}
                                    };

            var result = TraversableMatrix.OutputMatrixToString(matrix);
            string expected = "1 2 3\r\n4 5 6\r\n7 8 9\r\n";
            Assert.AreEqual(expected, result);
        }
    }
}
