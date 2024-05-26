using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollection
{
    class Student
    {
        /// <summary>
        /// Student name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Student's matric number
        /// </summary>
        public long MatriculationNumber { get; set; }

        /// <summary>
        /// Current semester the student is on
        /// </summary>
        public int Semester { get; set; }

        /// <summary>
        /// Dictionary containing the student's score for each course offered
        /// </summary>
        public Dictionary<string, double> Scores { get; }

        public Student(string name, long matriculationNumber, int semester)
        {
            this.Name = name;
            this.MatriculationNumber = matriculationNumber;
            this.Semester = semester;
            this.Scores = new Dictionary<string, double>();
        }


    }
}
