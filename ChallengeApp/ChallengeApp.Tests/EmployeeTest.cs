namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void CheckAddGrade_ShouldReturnGrade()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór");
            employee.AddGrade(1.0f);
            employee.AddGrade(1.1f);

            //act
            var result = employee.Result;


            //assert
            Assert.AreEqual(2.1, result, 0.01);
        }

        [Test]
        public void CheckMaxGrade_ShouldReturnMax()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór");
            employee.AddGrade(1.0f);
            employee.AddGrade(1.1f);

            //act
            var result = employee.GetStatistics().Max;


            //assert
            Assert.AreEqual(1.1, result, 0.01);
        }

        [Test]
        public void CheckMinGrade_ShouldReturnMin()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór");
            employee.AddGrade(1.0f);
            employee.AddGrade(1.1f);

            //act
            var result = employee.GetStatistics().Min;


            //assert
            Assert.AreEqual(1.0, result, 0.01);
        }

        [Test]
        public void CheckAverageGrade_ShouldReturnAverage()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór");
            employee.AddGrade(1.2f);
            employee.AddGrade(1.3f);

            //act
            var result = employee.GetStatistics().Average;


            //assert
            Assert.AreEqual(1.25, result, 0.01);
        }

        [Test]
        public void CheckAverageLetterA_ShouldReturnA()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór");
            employee.AddGrade(80);
            employee.AddGrade(80.1F);

            //act
            var result = employee.GetStatistics().AverageLetter;


            //assert
            Assert.AreEqual('A', result);
        }

        [Test]
        public void CheckAverageLetterB_ShouldReturnB()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór");
            employee.AddGrade(60);
            employee.AddGrade(60.1F);

            //act
            var result = employee.GetStatistics().AverageLetter;


            //assert
            Assert.AreEqual('B', result);
        }

        [Test]
        public void CheckAverageLetterC_ShouldReturnC()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór");
            employee.AddGrade(40);
            employee.AddGrade(40.1F);

            //act
            var result = employee.GetStatistics().AverageLetter;


            //assert
            Assert.AreEqual('C', result);
        }

        [Test]
        public void CheckAverageLetterD_ShouldReturnD()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór");
            employee.AddGrade(20);
            employee.AddGrade(20.1F);

            //act
            var result = employee.GetStatistics().AverageLetter;


            //assert
            Assert.AreEqual('D', result);
        }

        [Test]
        public void CheckAverageLetterE_ShouldReturnE()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór");
            employee.AddGrade(19);
            employee.AddGrade(19.1F);

            //act
            var result = employee.GetStatistics().AverageLetter;


            //assert
            Assert.AreEqual('E', result);
        }
    }
}