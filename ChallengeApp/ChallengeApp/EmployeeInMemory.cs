namespace ChallengeApp
{
 internal class EmployeeInMemory : EmployeeBase
    {
        public event GradeAddedDelegate GradeAdded;

        private List<float> grades = new();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
            
        }

        public override string GetName()
        {
            return $"{Name} {Surname}";
        }

        public float Result
        {
            get
            {
                return grades.Sum();
            }
        }

        public int GradesCount()
        {
            
            return grades.Count;
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
            var statistics = new Statistics(); ;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                }
            }

            statistics.Average = this.Result / this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= levelA:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= levelB:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= levelC:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= levelD:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}

