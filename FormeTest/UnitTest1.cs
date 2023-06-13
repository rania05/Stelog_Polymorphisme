using System.Drawing;

namespace FormeTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CalculerSurface_Triangle_Succes()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 7);
            double expectedSurface = 17.5;

            // Act
            double actualSurface = triangle.CalculSurface();

            // Assert
            Assert.AreEqual(expectedSurface, actualSurface);
        }

        [Test]
        public void CalculerSurface_Cercle_Succes()
        {
            // Arrange
            Cercle cercle = new Cercle(3);
            double expectedSurface = 28.274333882308138;

            // Act
            double actualSurface = cercle.CalculSurface();

            // Assert
            Assert.AreEqual(expectedSurface, actualSurface);
        }

        [Test]
        public void CalculerSurface_Rectangle_Succes()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(4, 6);
            double expectedSurface = 24;

            // Act
            double actualSurface = rectangle.CalculSurface();

            // Assert
            Assert.AreEqual(expectedSurface, actualSurface);
        }
    }
}