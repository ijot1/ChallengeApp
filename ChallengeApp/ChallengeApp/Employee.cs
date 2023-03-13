using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
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

        public void AddGrade(float grade)
        {
            if(grade >= 0 && grade <= 100)
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
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine($"entered data is not of float type: {grade}");
            }  
        }

        public void AddGrade(char grade)
        {
            {
                var value = (float)grade;
                this.AddGrade(value);
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }

            statistics.Average = Result / grades.Count;


            return statistics;
        }
    }
}
