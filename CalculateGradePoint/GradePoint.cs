using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGradePoint
{
    class GradePoint
    {
        //entered data: percentage data for 5 classes
        private int percent1, percent2, percent3, percent4, percent5;
        //calculated data: grade for 5 classes based on percentage data
        private string grade1, grade2, grade3, grade4, grade5;
        //calculated data: grade point for 5 classes based on grade
        private float gp1, gp2, gp3, gp4, gp5;

        //entered data: all percentage properties are write only
        public int Percent1
        {
            set { percent1 = value; }
        }
        public int Percent2
        {
            set { percent2 = value; }
        }
        public int Percent3
        {
            set { percent3 = value; }
        }
        public int Percent4
        {
            set { percent4 = value; }
        }
        public int Percent5
        {
            set { percent5 = value; }
        }

        //calculated data: all class grade point are read only
        public float GP1
        {
            get { return gp1; }
        }
        public float GP2
        {
            get { return gp2; }
        }
        public float GP3
        {
            get { return gp3; }
        }
        public float GP4
        {
            get { return gp4; }
        }
        public float GP5
        {
            get { return gp5; }
        }

        //calculated data: all grades are read only
        public string Grade1
        {
            get { return grade1; }
        }
        public string Grade2
        {
            get { return grade2; }
        }
        public string Grade3
        {
            get { return grade3; }
        }
        public string Grade4
        {
            get { return grade4; }
        }
        public string Grade5
        {
            get { return grade5; }
        }

        //used to calculate an individual letter grade from percentage
        //letter grade is based on a range so we use if-else-if 
        public string CalculateGrade(int percent)
        {
            string grade;
            if (percent >= 93)
            {
                grade = "A";
            }
            else if (percent >= 90)
            {
                grade = "A-";
            }
            else if (percent >= 88)
            {
                grade = "B+";
            }
            else if (percent >= 83)
            {
                grade = "B";
            }
            else if (percent >= 80)
            {
                grade = "B-";
            }
            else if (percent >= 70)
            {
                grade = "C";
            }
            else if (percent >= 60)
            {
                grade = "D";
            }
            else
                grade = "U";
            return grade;
        }

        //used to calculated class grade point from grade
        //grade is a single equal value use switch statement
        ////1 to 1 relationship
        public float CalculateGP(string grade)
        {
            float gp;
            switch (grade)
            {
                case "A":
                    gp = 4.0F;
                    break;
                case "A-":
                    gp = 3.7F;
                    break;
                case "B+":
                    gp = 3.3F;
                    break;
                case "B":
                    gp = 3.0F;
                    break;
                case "B-":
                    gp = 2.7F;
                    break;
                case "C+":
                    gp = 2.3F;
                    break;
                case "C":
                    gp = 2.0F;
                    break;
                case "C-":
                    gp = 1.7F;
                    break;
                case "D":
                    gp = 1.3F;
                    break;
                default:
                    gp = 0F;
                    break;
            }
            return gp;
        }

        //use percentage to calculate all grades and gradpoints
        public float CalculateGPA()
        {
            grade1 = CalculateGrade(percent1);
            grade2 = CalculateGrade(percent2);
            grade3 = CalculateGrade(percent3);
            grade4 = CalculateGrade(percent4);
            grade5 = CalculateGrade(percent5);

            gp1 = CalculateGP(grade1);
            gp2 = CalculateGP(grade2);
            gp3 = CalculateGP(grade3);
            gp4 = CalculateGP(grade4);
            gp5 = CalculateGP(grade5);

            return (gp1 + gp2 + gp3 + gp4 + gp4) / 5;


        }

        //use grade point to calculate honors
        //honors is a range so use an if - else statement
        public string CalculateHonors(float gpa)
        {
            string honor = "";
            if (gpa > 3.999)
            {
                honor = "Summa Cum Laude";
            }
            else if (gpa > 3.799)
            {
                honor = "Magna Cum Laude";
            }
            else if (gpa > 3.499)
            {
                honor = "Cum Laude";
            }
            return honor;


        }
    }
}
