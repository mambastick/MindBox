using MindBoxLib;

namespace MindBox.Tests
{
    [TestClass]
    public class MindBoxTests
    {
        [TestClass]
        public class CircleTest
        {
            [TestMethod]
            public void Square_8_Return_201_06()
            {
                //arrange
                Circle circle = new Circle(8);
                double expected = 201.06;

                //act
                double result = circle.CalcSquare();

                //assert
                Assert.AreEqual(expected, result);
            }
        }

        [TestClass]
        public class TriangleTest
        {
            [TestMethod]
            public void Square_10_15_6_Return_20_1()
            {
                //arrange
                Triangle triangle = new Triangle(10, 15, 6);
                double expected = 20.1;

                //act
                double result = triangle.CalcSquare();

                //assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void isRectangle_NotRectangle_ReturnFalse()
            {
                //Arrange
                var triangle = new Triangle(2, 3, 4);

                //Act
                var result = triangle.IsRectangular();

                //Assert
                Assert.IsFalse(result);
            }
        }
    }
}