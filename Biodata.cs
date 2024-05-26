using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollection
{
    class Biodata
    {
        /// <summary>
        /// Student's full name(Surname first)
        /// </summary>
        private string _fullName { get; set; }

        /// <summary>
        /// Student ID/Matriculation number
        /// </summary>
        private string _studentID { get; set; }

        /// <summary>
        /// Student's faculty
        /// </summary>
        private string _faculty { get; set; }
        
        
        /// <summary>
        /// Student's department
        /// </summary>
        private string _department { get; set; }
        
        
        /// <summary>
        /// Student's email address
        /// </summary>
        private string _emailAddress { get; set; }
        
        
        /// <summary>
        /// Student's date of birth
        /// </summary>
        private DateTime _dateOfBirth { get; set; }
        
        
        /// <summary>
        /// Student's gender
        /// </summary>
        private string _gender { get; set; }
        
        
        /// <summary>
        /// Student's nationality
        /// </summary>
        private string _nationality { get; set; }
        
        
        /// <summary>
        /// Student's phone number
        /// </summary>
        private string _phoneNumber { get; set; }
        
        
        /// <summary>
        /// Student's home address
        /// </summary>
        private string _homeAddress { get; set; }

        /// <summary>
        /// Creates biodata for a student
        /// </summary>
        /// <param name="_fullName">Student's full name(Surname first)</param>
        /// <param name="_studentID">Student ID/Matriculation number</param>
        /// <param name="_faculty">Faculty</param>
        /// <param name="_department">Department</param>
        /// <param name="_emailAddress">Student's email address</param>
        /// <param name="_dateOfBirth">Student's date of birth</param>
        /// <param name="_gender">Student's gender</param>
        /// <param name="_nationality">Student's nationality</param>
        /// <param name="_phoneNumber">Student's phone number</param>
        /// <param name="_homeAddress">Student's home address</param>
        public Biodata(string fullName, string studentID, string faculty, string department, string emailAddress, DateTime dateOfBirth, string gender, string nationality, string phoneNumber, string homeAddress)
        {
            _fullName = fullName;
            _studentID = studentID;
            _faculty = faculty;
            _department = department;
            _emailAddress = emailAddress;
            _dateOfBirth = dateOfBirth;
            _gender = gender;
            _nationality = nationality;
            _phoneNumber = phoneNumber;
            _homeAddress = homeAddress;
        }
    }
}
