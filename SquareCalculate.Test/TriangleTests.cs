using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculateNUnitTests
{
    public class TriangleTests
    {
        // Тестироование расчета треугольника круга по трем сторонам
        [Test]
        public void WhenCallTriangleSquare_ThenReturnSquareOfThisTriangle()
        {

            var triangle = new Triangle(4, 5, 6);

            Assert.That(triangle.Square, Is.EqualTo(9.921567));
        }

        // Тестирование проверки прямой ли треугольник
        [Test]
        public void WhenCallTriangleIsRight_ThenReturnAskIsItRight()
        {
            var triangle = new Triangle(4, 5, 6);

            Assert.That(triangle.IsRight, Is.EqualTo(false));
        }

        // Тестироование проверки может ли существовать треугольник с переданнимим длинами сторон в качеситве аргумента функции
        [Test]
        public void WhenCallTriangleWithInvalidArgument_ThenReturnThrowInvalidArgument()
        {
            var exeption = Assert.Throws<ArgumentException>(() => new Triangle(0,2,3));

            Assert.That(exeption.Message, Is.EqualTo("Invalid argument"));
        }

        // Тестирование правильный ли треугольник
        [Test]
        public void WhenCallTriangleIsTriangle_ThenReturnAskIsItTriangle()
        {
            var exeption = Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));

            Assert.That(exeption.Message, Is.EqualTo("Not triangle"));
        }
    }
}
