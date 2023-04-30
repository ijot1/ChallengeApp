namespace ChallengeApp
{
    public abstract class EmployeeBase  : IEmployee

    {
        public const float lowestGrade = 0;
        public const float highestGrade = 100;
        public const float levelA = 80;
        public const float levelB = 60;
        public const float levelC = 40;
        public const float levelD = 20;
        public const float levelE = 0;

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public virtual string Name { get; private set; }

        public virtual string Surname { get; private set; }

        public abstract string GetName();

        public abstract void AddGrade(float grade);

        public virtual void AddGrade(string grade)
        {
            var inValue = grade.ToCharArray();
            if (inValue.Length == 1 && inValue != null)
            {
                var inV = inValue[0];
                switch (inV)
                {
                    case var i when (inV is '0'):
                        this.AddGrade(lowestGrade);
                        break;

                    case var i when (inV is '1'):
                        this.AddGrade(1F);
                        break;

                    case var i when (inV is '2'):
                        this.AddGrade(2F);
                        break;

                    case var i when (inV is '3'):
                        this.AddGrade(3F);
                        break;

                    case var i when (inV is '4'):
                        this.AddGrade(4F);
                        break;

                    case var i when (inV is '5'):
                        this.AddGrade(5F);
                        break;

                    case var i when (inV is '6'):
                        this.AddGrade(6F);
                        break;

                    case var i when (inV is '7'):
                        this.AddGrade(7F);
                        break;

                    case var i when (inV is '8'):
                        this.AddGrade(8F);
                        break;

                    case var i when (inV is '9'):
                        this.AddGrade(9F);
                        break;

                    case var i when ((inV is 'a') || (inV is 'A')):
                        this.AddGrade(levelA);
                        break;

                    case var i when ((inV is 'b') || (inV is 'B')):
                        this.AddGrade(levelB);
                        break;

                    case var i when ((inV is 'c') || (inV is 'C')):
                        this.AddGrade(levelC);
                        break;

                    case var i when ((inV is 'd') || (inV is 'D')):
                        this.AddGrade(levelD);
                        break;

                    case var i when ((inV is 'e') || (inV is 'E')):
                        this.AddGrade(levelE);
                        break;
                    default:
                        throw new Exception($"letter out of scope: {grade}");
                }
            }
            else
            {
                if (float.TryParse(grade, out float result) || inValue == null)
                {
                    this.AddGrade(result);
                }
                else
                {
                    throw new Exception($"entered data is not of float type: {grade}");
                }
            }
        }

        public virtual void AddGrade(double grade)
        {
            float doubleValueAsFloat = (float)grade;
            AddGrade(doubleValueAsFloat);
        }

        public virtual void AddGrade(int grade)
        {
            float intValueAsFloat = (float)grade;
            AddGrade(intValueAsFloat);
        }

        public virtual void AddGrade(char grade)
        {
            float charValueAsFloat = (float)grade;
            AddGrade(charValueAsFloat);
        }

        public abstract Statistics GetStatistics();
    }
}
