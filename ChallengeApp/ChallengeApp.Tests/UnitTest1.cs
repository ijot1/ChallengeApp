namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void CheckAddGrade_ShouldReturnResult()
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
        public void CheckMaxGrade_ShouldReturnResult()
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
        public void CheckMinGrade_ShouldReturnResult()
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
        public void CheckAverageGrade_ShouldReturnResult()
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
    }
}