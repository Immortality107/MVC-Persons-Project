using CrudTests;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange 
            MyMath myMath = new MyMath();
            int Num1 = 5, Num2 = 10;
            int expected = 15;

            //act
             int actual=myMath.Add(Num1, Num2);

            //assert
            Assert.Equal(expected, actual);
            
        }
    }
}