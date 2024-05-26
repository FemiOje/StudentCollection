using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollection
{
    /// <summary>
    /// Result for a single course for a student
    /// </summary>
    class Result
    {
        /// <summary>
        /// Course code
        /// </summary>
        private string _courseCode { get; set; }

        /// <summary>
        /// Course title
        /// </summary>
        private string _courseTitle { get; set; }

        /// <summary>
        /// Grade attained
        /// </summary>
        private char _grade { get; set; }


        /// <summary>
        /// Number of units the course holds
        /// </summary>
        private int _numberOfUnits { get; set; }


        /// <summary>
        /// Initializes a result for a single course
        /// </summary>
        /// <param name="courseCode"></param>
        /// <param name="courseTitle"></param>
        /// <param name="grade"></param>
        /// <param name="numberOfUnits"></param>
        public Result(string courseCode, string courseTitle, char grade, int numberOfUnits)
        {
            _courseCode = courseCode;
            _courseTitle = courseTitle;
            _grade = grade;
            _numberOfUnits = numberOfUnits;
        }

    }
}
