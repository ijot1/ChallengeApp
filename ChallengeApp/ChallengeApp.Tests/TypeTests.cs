
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void namesTest()
        {
            Employee e1 = GetEmployee("Jan", "Kowalski");            
            Employee e2 = GetEmployee("Jan", "Kowalski");
            string str1 = e1.FirstName;
            string str2 = e2.FirstName;
            Assert.AreNotEqual(str1, str2);
        }

        public void objectsTest()
        {
            Employee e1 = GetEmployee("Jan", "Kowalski");
            Employee e2 = GetEmployee("Jan", "Kowalski");
            Assert.AreNotEqual(e1, e2);
        }

        public void numbersTest1()
        {
            int i1 = 2;
            int i2 = 2;
            Assert.AreEqual(i1, i2);
        }

        public void numbersTest2()
        {
            double d1 = 5.75D;
            double d2 = 5.75D;
            Assert.AreEqual(d1, d2);
        }

        public void numbersTest3()
        {
            float f1 = 3.12345F;
            float f2 = 3.12345F;
        }

        private Employee GetEmployee(string firstName, string lastNane)
        {
            return new Employee(firstName, lastNane);
        }
    }
}
