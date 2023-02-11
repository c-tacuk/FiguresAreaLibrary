namespace FiguresAreaTests
{
    public class TriangleTests
    {
        [Fact]
        public void GetArea_sides_3_4_5_returned_6()
        {
            // arrange
            var fSide = 3;
            var sSide = 4;
            var tSide = 5;
            var expected = 6;

            // act
            Triangle triangle = new Triangle(fSide, sSide, tSide);
            var actual = triangle.GetArea();

            // assert
            Assert.Equal(expected, actual);
        }
    }
}