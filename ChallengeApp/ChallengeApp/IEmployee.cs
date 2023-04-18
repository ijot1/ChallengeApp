namespace ChallengeApp
{

    public interface IEmployee
    {
        string FirstName { get; }

        string LastName { get; }

        string Position { get; }

        string GetName();

        float Result { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        public int GradesCount();

        Statistics GetStatistics();
    }
}
