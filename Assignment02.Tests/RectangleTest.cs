namespace Assignment02.Tests
{


    //Test class for 
    public class RectangleTest
    {

        private Rectangle _rectangle { get; set; }
        private int maxLength = 1100;
        private int maxWidth = 1100;

        [SetUp]
        public void Setup()
        {
            _rectangle = new Rectangle();
        }

        // Get Length
        [Test]
        public void ShouldGetCorrectLength()
        {
            // Arrange
            int actualLength = 7;

            // Act
             _rectangle.SetLength(actualLength);
            int expectedLength = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(expectedLength, actualLength);

        }

        [Test]
        public void ShouldGetCorrectDefaultLength()
        {
            // Arrange
            int actualLength = 1;

            // Act
            int expectedLength = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(expectedLength, actualLength);

        }

        [Test]
        public void ShouldGetCorrectLengthAsGiven()
        {
            // Arrange
            int actualLength = 11;

            // Act
            _rectangle.SetLength(11);
            int expectedLength = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        // Get Width
        [Test]
        public void ShouldGetCorrectWidth()
        {
            // Arrange
            int actualWidth = 6;

            // Act
            _rectangle.SetWidth(actualWidth);
            int expectedWidth = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);

        }

        [Test]
        public void ShouldGetCorrectDefaultWidth()
        {
            // Arrange
            int actualWidth = 1;

            // Act
            int expectedWidth= _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);

        }

        [Test]
        public void ShouldGetCorrectWidthAsGiven()
        {
            // Arrange
            int actualWidth = 1100;

            // Act
            _rectangle.SetWidth(maxWidth);
            int expectedWidth = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);

        }


        // Set Length
        [Test]
        public void ShouldSetCorrectLength()
        {
            // Arrange
            int actualLength = 7;

            // Act
            int expectedLength = _rectangle.SetLength(actualLength);

            // Assert
            Assert.AreEqual(expectedLength, actualLength);

        }

        [Test]
        public void ShouldSetCorrectMaximumLength()
        {
            // Arrange
            int actualLength = 1100;

            // Act
            int expectedLength = _rectangle.SetWidth(maxLength);

            // Assert
            Assert.AreEqual(expectedLength, actualLength);

        }

        [Test]
        public void ShouldSetCorrectLengthAsGiven()
        {
            // Arrange
            int actualLength = 5;

            // Act
            int expectedLength = _rectangle.SetWidth(5);

            // Assert
            Assert.AreEqual(expectedLength, actualLength);

        }

        // Set Width
        [Test]
        public void ShouldSetCorrectWidth()
        {
            // Arrange
            int actualWidth = 6;

            // Act
            int expectedWidth = _rectangle.SetLength(actualWidth);

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);

        }

        [Test]
        public void ShouldSetCorrectMaximumWidth()
        {
            // Arrange
            int actualWidth = 1100;

            // Act
            int expectedWidth = _rectangle.SetWidth(maxWidth);

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void ShouldSetCorrectWidthAsGiven()
        {
            // Arrange
            int actualWidth = 3;

            // Act
            int expectedWidth = _rectangle.SetWidth(3);

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);

        }


        // Get Perimeter

        [Test]
        public void ShouldGetCorrectPerimeter()
        {
            // Arrange
            int actualPerimeter = 30;
            _rectangle = new Rectangle(7,8);

            // Act
            int expectedPerimeter = _rectangle.GetPerimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void ShouldGetCorrectMaximumPerimeter()
        {
            // Arrange
            int actualPerimeter = 4400;
            _rectangle = new Rectangle(maxLength, maxWidth);

            // Act
            int expectedPerimeter = _rectangle.GetPerimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void ShouldGetPerimeter36()
        {
            // Arrange
            int actualPerimeter = 36;
            _rectangle = new Rectangle(10, 8);

            // Act
            int expectedPerimeter = _rectangle.GetPerimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        // Get Area

        [Test]
        public void ShouldGetCorrectArea()
        {
            // Arrange
            int actualArea = 56;
            _rectangle = new Rectangle(7, 8);

            // Act
            int expectedArea= _rectangle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void ShouldGetMaxArea()
        {
            // Arrange
            int actualArea = 1210000;
            _rectangle = new Rectangle(maxLength, maxWidth);

            // Act
            int expectedArea = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void ShouldGetCorrectArea63()
        {
            // Arrange
            int actualArea = 63;
            _rectangle = new Rectangle(9, 7);

            // Act
            int expectedArea = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }




    }
}