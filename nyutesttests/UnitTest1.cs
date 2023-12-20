namespace nyutesttests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        //This test is designed to fail to show the CI/CD pipeline working.
        [Theory]
        [InlineData("https://www.google.com")]
        public void TestMalformedURI(string uri) {
            new Uri(uri);
        }
    }
}