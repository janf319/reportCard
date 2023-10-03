using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CalculateGradePoint
{
    class GPresentation
    {

        private GradePoint gradePoint = new GradePoint();

        //Enter percentage grade for class 1 
        //Enter percentage grade for class 2
        //Enter percentage grade for class 3
        //Enter percentage grade for class 4
        //Enter percentage grade for class 3
        public int EnterPercent(int whichOne)
        {
            string inValue;
            int percentage;
            Write("Enter percentage grade class {0}: ", whichOne);
            inValue = ReadLine();
            while (int.TryParse(inValue, out percentage) == false)
            {
                Write("Please enter a whole number for the grade percentage");
                inValue = ReadLine();
            }
            return percentage;
        }

        public void InputClasPercentages()
        {
            gradePoint.Percent1 = EnterPercent(1);
            gradePoint.Percent2 = EnterPercent(2);
            gradePoint.Percent3 = EnterPercent(3);
            gradePoint.Percent4 = EnterPercent(4);
            gradePoint.Percent5 = EnterPercent(5);
        }

        public void DisplayGrade(int classNum, float fgrade, string lgrade)
        {
            WriteLine("Class {0} Grade Point {1,10:F2}   {2,-5}", classNum, fgrade, lgrade);
        }

        public void DisplayReportCard()
        {
            float gpa = gradePoint.CalculateGPA();
            Clear();
            WriteLine("****************************************");
            WriteLine("Based on the entered class percentage.");
            WriteLine("Grade Point");
            WriteLine("****************************************");
            DisplayGrade(1, gradePoint.GP1, gradePoint.Grade1);
            DisplayGrade(2, gradePoint.GP2, gradePoint.Grade2);
            DisplayGrade(3, gradePoint.GP3, gradePoint.Grade3);
            DisplayGrade(4, gradePoint.GP4, gradePoint.Grade4);
            DisplayGrade(5, gradePoint.GP5, gradePoint.Grade5);
            WriteLine("****************************************");
            WriteLine("Grade Point Average {0,10:F2} {1,20}", gpa,
                gradePoint.CalculateHonors(gpa));
        }

        public void InputReportCardData()
        {
            InputClasPercentages();
            DisplayReportCard();
        }
    }
}
