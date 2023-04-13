namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void CheckAddGrade_ShouldReturnGrade()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade(1.0f);
            employee.AddGrade(1.1f);

            //act
            var result = employee.Result;


            //assert
            //Assert.AreEqual(2.1, result, 0.01);
            Assert.That(result, Is.EqualTo(2.1).Within(0.01));
        }

        [Test]
        public void CheckAddGradeAsLetterZero_ShouldReturnLowestGrade()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade(0);

            //act
            var result = employee.Result;


            //assert
            Assert.That(result, Is.EqualTo(Employee.lowestGrade));
        }

        [Test]
        public void CheckAddGradeAsLetterA_ShouldReturnLevelA()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade("A");
            employee.AddGrade("a");

            //act
            var result = employee.Result;


            //assert
            Assert.That(result, Is.EqualTo(160));
        }

        [Test]
        public void CheckAddGradeAsLetterB_ShouldReturnLevelB()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade("B");
            employee.AddGrade("b");

            //act
            var result = employee.Result;


            //assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void CheckAddGradeAsLetterC_ShouldReturnLevelC()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade("C");
            employee.AddGrade("c");

            //act
            var result = employee.Result;


            //assert
            Assert.That(result, Is.EqualTo(80));
        }
        [Test]
        public void CheckAddGradeAsLetterD_ShouldReturnLevelD()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade("D");
            employee.AddGrade("d");

            //act
            var result = employee.Result;


            //assert
            Assert.That(result, Is.EqualTo(40));
        }

        public void CheckAddGradeAsLetterE_ShouldReturnLevelE()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade("E");
            employee.AddGrade("e");

            //act
            var result = employee.Result;


            //assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CheckMaxGrade_ShouldReturnMax()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade(1.0f);
            employee.AddGrade(1.1f);

            //act
            var result = employee.GetStatistics().Max;


            //assert
            Assert.That(result, Is.EqualTo(1.1).Within(0.01));
        }

        [Test]
        public void CheckMinGrade_ShouldReturnMin()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade(1.0f);
            employee.AddGrade(1.1f);

            //act
            var result = employee.GetStatistics().Min;


            //assert
            Assert.That(result, Is.EqualTo(1.0).Within(0.01));
        }

        [Test]
        public void CheckAverageGrade_ShouldReturnAverage()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade(1.2f);
            employee.AddGrade(1.3f);

            //act
            var result = employee.GetStatistics().Average;


            //assert
            Assert.That(result, Is.EqualTo(1.25).Within(0.01));
        }

        [Test]
        public void CheckAverageLetterA_ShouldReturnA()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade(80);
            employee.AddGrade(80.1F);

            //act
            var result = employee.GetStatistics().AverageLetter;


            //assert;
            Assert.That(result, Is.EqualTo('A'));
        }

        [Test]
        public void CheckAverageLetterB_ShouldReturnB()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade(60);
            employee.AddGrade(60.1F);

            //act
            var result = employee.GetStatistics().AverageLetter;


            //assert
            Assert.That(result, Is.EqualTo('B'));
        }

        [Test]
        public void CheckAverageLetterC_ShouldReturnC()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade(40);
            employee.AddGrade(40.1F);

            //act
            var result = employee.GetStatistics().AverageLetter;


            //assert
            Assert.That(result, Is.EqualTo('C'));
        }

        [Test]
        public void CheckAverageLetterD_ShouldReturnD()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade(20);
            employee.AddGrade(20.1F);

            //act
            var result = employee.GetStatistics().AverageLetter;


            //assert
            Assert.That(result, Is.EqualTo('D'));
        }

        [Test]
        public void CheckAverageLetterE_ShouldReturnE()
        {
            //arrange
            var employee = new Employee("Xymena", "Zapiór", 'K');
            employee.AddGrade(19);
            employee.AddGrade(19.1F);

            //act
            var result = employee.GetStatistics().AverageLetter;


            //assert
            Assert.That(result, Is.EqualTo('E'));
        }
    }
}