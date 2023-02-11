namespace FiguresAreaTests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_radius_2_returned_12_566()
        {
            // arrange
            var radius = 2;
            var expected = 12.566;

            // act
            Circle circle = new Circle(radius);
            var actual = circle.GetArea();

            // assert
            Assert.Equal(expected, actual);
        }
    }
}