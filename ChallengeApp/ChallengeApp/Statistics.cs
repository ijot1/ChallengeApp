namespace ChallengeApp
{
    public class Statistics
    {
        public const float levelA = 80;
        public const float levelB = 60;
        public const float levelC = 40;
        public const float levelD = 20;
        public const float levelE = 0;

        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Sum { get; private set; }

        public int Count { get; private set; }

        public float Average {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public char AverageLetter {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= levelA:
                        return 'A';
                    case var average when average >= levelB:
                        return 'B';
                    case var average when average >= levelC:
                        return 'C';
                    case var average when average >= levelD:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
        }

        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(this.Min, grade);
            this.Max = Math.Max(this.Max, grade);
        }
    }
}
