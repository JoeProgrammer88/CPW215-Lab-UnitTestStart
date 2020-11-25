using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {

        private string courseName;

        private string instructorName;

        private byte numberOfCredits;

        public Course(string courseName2)
        {
            // Deafault unless passed in
            InstructorName = "STAFF";

            CourseName = courseName2;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName {
            get {return instructorName; }
            set { instructorName = value; }
        }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName {
            get { return courseName; }
            set{
                if (value != null) {
                    courseName = value;
                } else {
                    throw new ArgumentNullException();
                }
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits {
            get { return numberOfCredits; }
            set { 
                if(value < 30 && value > 0){
                    numberOfCredits = value;
                } else {
                    throw new ArgumentException();
                }
            }
        }

    }
}
