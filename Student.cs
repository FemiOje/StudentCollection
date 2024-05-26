using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollection
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public Biodata Biodata { get; set; }
        public List<Result> Results { get; set; }
        public List<CourseRegistration> CourseRegistrations { get; set; }


        /// <summary>
        /// Initializes a student object with the student's ID, name and biodata.
        /// </summary>
        /// <param name="studentID">Student ID</param>
        /// <param name="name">Student's name</param>
        /// <param name="biodata">Student's biodata</param>
        public Student(int studentID, string name, Biodata biodata)
        {
            StudentID = studentID;
            Name = name;
            Biodata = biodata;
            Results = new List<Result>();
        }

        /// <summary>
        /// Add a result to the list of results
        /// </summary>
        /// <param name="result">A result object</param>
        public void AddResult(Result result)
        {
            Results.Add(result);
        }


        /// <summary>
        /// Log student's ID, name, biodata and all results
        /// </summary>
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student ID: {StudentID}");
            Console.WriteLine($"Name: {Name}");
            // Biodata.DisplayBiodata();
            Console.WriteLine("Results:");
            // foreach (var result in Results)
            // {
            //     result.DisplayResult();
            // }
        }
    }
}
