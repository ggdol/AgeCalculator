using AgeCalculatorKata;
using NUnit.Compatibility;
using NUnit.Framework;

namespace AgeCalculatorKataTests
{
    [TestFixture]
    public class AgeCalculatorTests
    {
        //3 stages of naming: Meaningless -> Specific -> Meaningful -> General


        [TestCase("1979/02/15", "2022/02/15", 43)]
        [TestCase("2000/03/21", "2015/03/21", 15)]
        [TestCase("2000/02/29", "2004/02/29", 4)] //leap year 
        public void ShouldReturnDifferenceInYears(DateTime birthDate, DateTime targetDate, int expected)
        {
            //Arrange
            var sut = new AgeCalculator();
            //Act
            var actual = sut.GetAge(birthDate, targetDate);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        public class AfterBirthday
        {
            [TestCase("1984/06/27", "2002/11/01", 18)]
            [TestCase("1982/09/30", "2001/10/05", 19)]
            [TestCase("2000/01/01", "2010/01/02", 10)]
            [TestCase("1979/02/15", "2022/02/15", 43)]
            [TestCase("2000/02/29", "2004/02/29", 4)] //leap year
            [TestCase("2000/02/29", "2004/03/01", 4)] //leap year

            public void ShouldReturnDiffrentInYears(DateTime birthDate, DateTime targetDate, int expected)
            {
                //Arrange
                var sut = new AgeCalculator();
                //Act
                var actual = sut.GetAge(birthDate, targetDate);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }

        public class BeforeBirthdayMonth
        {
            [TestCase("2000/06/30", "2020/03/21", 19)]
            [TestCase("2010/10/01", "2021/07/31", 10)]
            public void GivenAfterBirthDay_ShouldReturnDiffrentInYearsMinusOne(DateTime birthDate, DateTime targetDate, int expected)
            {
                //Arrange
                var sut = new AgeCalculator();
                //Act
                var actual = sut.GetAge(birthDate, targetDate);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }


        public class BeforeBirthdayDayInMonth
        {
            [TestCase("2001/06/30", "2020/06/21", 18)]
            [TestCase("2005/02/28", "2010/02/27", 4)]
            [TestCase("2000/02/29", "2005/02/28", 4)]//leap year
            public void GivenAfterBirthDayInMonth_ShouldReturnDiffrentInYearsMinusOne(DateTime birthDate, DateTime targetDate, int expected)
            {
                //Arrange
                var sut = new AgeCalculator();
                //Act
                var actual = sut.GetAge(birthDate, targetDate);
                //Assert
                Assert.AreEqual(expected, actual);
            }

        }




    }


}