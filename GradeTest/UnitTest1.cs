using System;
using System.Runtime.InteropServices;
using GradeOpgave;
using Xunit;

namespace GradeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0,-3)]
        [InlineData(4,-3)]
        [InlineData(5,-3)]
        [InlineData(6,0)]
        [InlineData(30,0)]
        [InlineData(49,0)]
        [InlineData(50,2)]
        [InlineData(55,2)]
        [InlineData(59,2)]
        [InlineData(60,4)]
        [InlineData(70,4)]
        [InlineData(79,4)]
        [InlineData(80,7)]
        [InlineData(83,7)]
        [InlineData(84,7)]
        [InlineData(85,10)]
        [InlineData(90,10)]
        [InlineData(94,10)]
        [InlineData(95,12)]
        [InlineData(98,12)]
        [InlineData(100,12)]



        public void GradeTest(int procent, int gra)
        {
            Grade grade = new Grade();

            int realGrade = grade.ToGrade(procent);
            
            Assert.Equal(gra,realGrade);
        }

        [Fact]
        public void ExceptionTest()
        {
            Grade grade = new Grade();

            Assert.Throws<Exception>(() => grade.ToGrade(-1));
        }
        
    }
}