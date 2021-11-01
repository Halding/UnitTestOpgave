using System;
using UnitTestOpgave;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0,0,130)]
        public void Below100(int p, double km, double price)
        {
            Price pris = new Price();
            
            //act 
            double realPrice = pris.TotalPrice(p, km);
            
            //assert
            Assert.Equal(realPrice,price);

        }

        [Fact]
        public void TestException()
        {
            Price pris = new Price();

            Assert.Throws<Exception>(() => pris.TotalPrice(-1, -1));
        }
        
        
        
        
    }
}