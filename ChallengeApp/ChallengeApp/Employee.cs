using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        public static float lowestGrade = 0;
        public static float highestGrade = 100;
        public static float levelA = 80;
        public static float levelB = 60;
        public static float levelC = 40;
        public static float levelD = 20;
        public static float levelE = 0;
        
        private List<float> grades = new List<float>();

        public Employee(string name, string surname) 
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

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

        public void AddGrade(float grade)
        {
            if(grade >= lowestGrade && grade <= highestGrade)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"grade value out of scope: {grade :F2}");
            }
        }

        public void AddGrade(string grade)
        {
            var inValue = grade.ToCharArray();
            if(inValue.Length == 1)
            {
                var inV = inValue[0];
                switch (inV)
                {
                    case var i when (inV is '0'):
                        this.grades.Add(lowestGrade);
                        break;

                    case var i when ((inV is 'a') || (inV is 'A')):
                        this.grades.Add(levelA);
                        break;

                    case var i when ((inV is 'b') || (inV is 'B')):
                        this.grades.Add(levelB);
                        break;

                    case var i when ((inV is 'c') || (inV is 'C')):
                        this.grades.Add(levelC);
                        break;

                    case var i when ((inV is 'd') || (inV is 'D')):
                        this.grades.Add(levelD);
                        break;

                    case var i when ((inV is 'e') || (inV is 'E')):
                        this.grades.Add(levelE);
                        break;
                    default: 
                        Console.WriteLine($"letter out of scope: {grade}");
                        break;
                    }
            }
            else
            {
                if (float.TryParse(grade, out float result))
                {
                    this.AddGrade(result);
                }
                else
                {
                    Console.WriteLine($"entered data is not of float type: {grade}");
                }
            }
        }
            

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                if(grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                }               
            }

            statistics.Average = this.Result / this.grades.Count;

            switch(statistics.Average)
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
