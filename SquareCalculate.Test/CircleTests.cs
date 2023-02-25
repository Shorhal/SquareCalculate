
namespace SquareCalculateNUnitTests
{
    public class SquareCalculateTests
    {
        
        [Test]
        public void WhenCallCircleSquare_ThenReturnSquareOfThisCircle()
        {
            var circle = new Circle(4);

            Assert.That(circle.Square, Is.EqualTo(12.56));
        }
        
    }
}