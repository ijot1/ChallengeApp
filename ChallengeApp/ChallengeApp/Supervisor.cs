namespace ChallengeApp
{

    internal class Supervisor : IEmployee
    {
        public static float grade6 = 100;
        public static float grade6Minus = 95;
        public static float grade5Minus = 75;
        public static float grade5 = 80;
        public static float grade5Plus = 85;
        public static float grade4Minus = 55;
        public static float grade4 = 60;
        public static float grade4Plus = 65;
        public static float grade3Minus = 35;
        public static float grade3 = 40;
        public static float grade3Plus = 45;
        public static float grade2Minus = 15;
        public static float grade2 = 20;
        public static float grade2Plus = 25;
        public static float grade1 = 0;
        public static float grade1Plus = 5;

        public const string mark1 = "1";
        public const string mark1Plus = "1+";
        public const string markPlus1 = "+1";
        public const string mark2Minus = "2-";
        public const string markMinus2 = "-2";
        public const string mark2 = "2";
        public const string mark2Plus = "2+";
        public const string markPlus2 = "+2";
        public const string mark3Minus = "3-";
        public const string markMinus3 = "-3";
        public const string mark3 = "3";
        public const string mark3Plus = "3+";
        public const string markPlus3 = "+3";
        public const string mark4Minus = "4-";
        public const string markMinus4 = "-4";
        public const string mark4 = "4";
        public const string mark4Plus = "4+";
        public const string markPlus4 = "+4";
        public const string mark5Minus = "5-";
        public const string markMinus5 = "-5";
        public const string mark5 = "5";
        public const string mark5Plus = "5+";
        public const string markPlus5 = "+5";
        public const string mark6Minus = "6-";
        public const string markMinus6 = "-6";
        public const string mark6 = "6";

        public static readonly string[] inValue = {                         mark1, mark1Plus, markPlus1,
                                                    mark2Minus, markMinus2, mark2, mark2Plus, markPlus2,
                                                    mark3Minus, markMinus3, mark3, mark3Plus, markPlus3,
                                                    mark4Minus, markMinus4, mark4, mark4Plus, markPlus4, 
                                                    mark5Minus, markMinus5, mark5, mark5Plus, markPlus5,
                                                    mark6Minus, markMinus6, mark6 };

        private List<float> grades = new();

        public Supervisor(string firstName, string lastName, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Position { get; private set; }

        public float Result
        {
            get
            {
                    return grades.Sum();
            }
        }

        public void AddGrade(float grade)
        {
            if (grade >= grade1 && grade <= grade6)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception($"grade value out of scope: {grade:F2}");
            }
        }

        public void AddGrade(string grade)
        {
            
            if (inValue.Contains(grade))
            {
                switch (grade)
                {
                    case mark1 :
                        this.grades.Add(grade1);
                        break;

                    case mark1Plus or markPlus1:
                        this.grades.Add(grade1Plus);
                        break;

                    case mark2Minus or markMinus2 :
                        this.grades.Add(grade2Minus);
                        break;

                    case mark2 :
                        this.grades.Add(grade2);
                        break;

                    case mark2Plus or markPlus2:
                        this.grades.Add(grade2Plus);
                        break;

                    case mark3Minus or markMinus3:
                        this.grades.Add(grade3Minus);
                        break;

                    case mark3:
                        this.grades.Add(grade3);
                        break;

                    case mark3Plus or markPlus3:
                        this.grades.Add(grade3Plus);
                        break;

                    case mark4Minus or markMinus4:
                        this.grades.Add(grade4Minus);
                        break;

                    case mark4:
                        this.grades.Add(grade4);
                        break;

                    case mark4Plus or markPlus4:
                        this.grades.Add(grade4Plus);
                        break;

                    case mark5Minus or markMinus5:
                        this.grades.Add(grade5Minus);
                        break;

                    case mark5:
                        this.grades.Add(grade5);
                        break;

                    case mark5Plus or markPlus5:
                        this.grades.Add(grade5Plus);
                        break;

                    case mark6Minus or markMinus6:
                        this.grades.Add(grade6Minus);
                        break;

                    case mark6:
                        this.grades.Add(grade6);
                        break;

                    default:
                        throw new Exception($"grade out of scope: {grade}");
                }
            }
            else 
            {
                char sign = grade.ToCharArray()[0];
                if(float.TryParse(grade, out float result) && sign != '+')
                {   
                    AddGrade(result);
                }
                else
                {    
                    throw new Exception($"illeagal argument entered: {grade}");
                }
            }
        }   
            
        

        public string GetName()
        {
            return $"{FirstName} {LastName}\n{Position}";
        }

        public Statistics GetStatistics()
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
                case var average when average >= grade5:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= grade4:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= grade3:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= grade2:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }

        public int GradesCount()
        {
            return grades.Count;
        }
    }
}
