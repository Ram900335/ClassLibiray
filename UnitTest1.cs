using System;
using Xunit;
using Classlibray;

namespace TestClassLibrary
{
    public class UnitTest1
    {
        [Fact (Skip = "This test is broken")]
        public void Test1()
        {
            var a = Class1.Add(1,3);
            Assert.Equal(4,a);
        }

        [Fact]
        public void Test2()
        {
        //Given
            int b = Class1.Add(20,30);        
        //When
            Assert.Equal(50,b);
        //Then
        }
    }
}
