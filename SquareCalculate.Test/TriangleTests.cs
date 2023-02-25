using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculateNUnitTests
{
    public class TriangleTests
    {
        [Test]
        public void WhenCallTriangleSquare_ThenReturnSquareOfThisTriangle()
        {

            var triangle = new Triangle(4, 5, 6);

            Assert.That(triangle.Square, Is.EqualTo(9.921567));
        }

        [Test]
        public void WhenCallTriangleIsRight_ThenReturnAskIsItRight()
        {
            var triangle = new Triangle(4, 5, 6);

            Assert.That(triangle.IsRight, Is.EqualTo(false));
        }

        [Test]
        public void WhenCallTriangleWithInvalidArgument_ThenReturnThrowInvalidArgument()
        {
            var exeption = Assert.Throws<ArgumentException>(() => new Triangle(0,2,3));

            Assert.That(exeption.Message, Is.EqualTo("Invalid argument"));
        }

        [Test]
        public void WhenCallTriangleIsTriangle_ThenReturnAskIsItTriangle()
        {
            var exeption = Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));

            Assert.That(exeption.Message, Is.EqualTo("Not triangle"));
        }
    }
}
