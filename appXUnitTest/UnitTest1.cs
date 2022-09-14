using xUnit.API.Service;
using Xunit;

namespace appXUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var test1 = new DummyService();

            //Act
            var boolValue = test1.IsTrue();

            //Assert
            Assert.True(boolValue == true);
        }

        [Fact]
        public void Test2()
        {

            //Arrange
            var test2 = new DummyService();

            //Act
            var name = test2.ReturnName("Ati");

            //Assert
            //Önce expected string sonra bize dönen
            Assert.Equal("Ati", name);
        }
    }
}