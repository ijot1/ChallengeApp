namespace ChallengeApp
{
    using System.Net.WebSockets;

    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";

        public List<float> grades = new();

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }


        public override void AddGrade(float grade)
        {
            if (grade >= lowestGrade && grade <= highestGrade)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception($"grade value out of scope: {grade:F2}");
            }

        }

        public override string GetName()
        {
            return $"{this.Name} {this.Surname}";
        }

        public override Statistics GetStatistics()
        {
            Statistics statistics = new Statistics();
            string? line = "";
            
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    line = reader.ReadLine();
                    while (line is object && line is not null)
                    {
                        grades.Add(float.Parse(line));
                        if (line.Trim() != "")
                        {
                            line = reader.ReadLine();
                        }
                    }

                    foreach (var grade in this.grades)
                    {
                        if (grade >= 0)
                        {
                            statistics.AddGrade(grade);
                        }
                    }
                    
                }
            }
            return statistics;
        }
    }
}

