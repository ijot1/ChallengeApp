namespace ChallengeApp
{
    using System.Net.WebSockets;

    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public List<float> grades = new();

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
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
            int linesCount = 0;
            if (File.Exists(fileName))
            {                
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();

                    while (line is object)
                    {
                        if (line.Trim() != "")
                        {
                            linesCount++;
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            return linesCount;
        }

        public override void AddGrade(float grade)
        {
            if (grade >= lowestGrade && grade <= highestGrade)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
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
            string? line = "";
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

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

                        if (grade >= 0)
                        {
                            statistics.Max = Math.Max(statistics.Max, grade);
                            statistics.Min = Math.Min(statistics.Min, grade);
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
                }
            }
            return statistics;
        }
    }
}

