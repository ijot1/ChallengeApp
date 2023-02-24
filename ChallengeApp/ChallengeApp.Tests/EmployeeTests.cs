

namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void CheckAddEvaluation_ShouldReturnResult()
        {
            //arrange
            var employee = new Employee(
                "Xymena", "Zapiór");
            employee.AddEvaluation(4);
            employee.AddEvaluation(9);

            //act
            var result = employee.Result;
            

            //assert
            Assert.AreEqual(13, result);
        }

        [Test]
        public void CheckNegativEvaluation_ShouldReturnResult()
        {
            //arrange
            var employee = new Employee(
                "Xymena", "Zapiór");
            employee.AddEvaluation(4);
            employee.AddEvaluation(-9);

            //act
            var result = employee.Result;


            //assert
            Assert.AreEqual(-5, result);
        }

        [Test]
        public void CheckCreateEmployee_ShouldReturnName()
        {
            //arrange
            var employee = new Employee(
                "Xymena", "Zapiór");
            
            //act
            var fName = employee.FirstName;
            var lName = employee.LastName;


            //assert
            Assert.AreEqual("Xymena Zapiór", fName + " " + lName);
        }
    }
}