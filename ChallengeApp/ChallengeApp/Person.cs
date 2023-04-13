namespace ChallengeApp
{
    using System.Xml.Linq;

    public abstract class Person
    {
        public Person(string firstName, string lastName, char sex)
        {
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
        }

        public virtual string FirstName { get; protected set; }
        public virtual string LastName { get; protected set; }
        public virtual char Sex { get; protected set; }

        public abstract string GetName();
    }
}

