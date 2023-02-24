using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        private List<int> evaluations = new List<int>();
        
        public Employee(string firstName, string lastName) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Result 
        { 
            get
            {
                return evaluations.Sum();
            }
        }

        public void AddEvaluation(int evaluation)
        {
            this.evaluations.Add(evaluation);
        }
    }
}
