namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetTextLength_LeadWhiteSpacedText_ReturnsLenght()
        {
            //Arrange
            string input = " Hello ";
            int expected = 5;

            //Act
            int actual = Methods.GetTextLength(input);

            //Assert
            Assert.AreEqual(expected, actual, "message");
        }
    }
}