namespace ChallengeApp
{
 internal class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
            
        }

        public override string GetName()
        {
            return $"{Name} {Surname}";
        }

        public override void AddGrade(float grade)
        {
            if (grade >= lowestGrade && grade <= highestGrade)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception($"grade value out of scope: {grade:F2}");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            
            return statistics;
        }
    }
}

