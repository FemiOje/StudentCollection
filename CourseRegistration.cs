using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollection
{
    class CourseRegistration
    {
        public string CourseTitle { get; set; }
        public string CourseCode { get; set; }
        public string Semester { get; set; }
        public DateTime RegistrationYear { get; set; }

        public CourseRegistration(string courseName, string semester, DateTime registrationYear)
        {
            CourseTitle = courseName;
            Semester = semester;
            RegistrationYear = registrationYear;
        }

        public void DisplayCourseRegistration()
        {
            Console.WriteLine($"Course Name: {CourseTitle}, Semester: {Semester}, Registration Date: {RegistrationYear.ToShortDateString()}");
        }
    }
}
