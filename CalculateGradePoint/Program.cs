using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CalculateGradePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float gpa;

            Gpresentation gpresentation = new Gpresentation();
            GradePoint gradePoint = new GradePoint();
            gradePoint.Percent1 = gpresentation.EnterPercent(1);
            gradePoint.Percent2 = gpresentation.EnterPercent(2);
            gradePoint.Percent3 = gpresentation.EnterPercent(3);
            gradePoint.Percent4 = gpresentation.EnterPercent(4);
            gradePoint.Percent5 = gpresentation.EnterPercent(5);

            gpa = gradePoint.CalculateGPA();

            Clear();
            WriteLine("*********************");
            WriteLine("Based on the entered class percentage");
            WriteLine("Grade Point");
            gpresentation.DisplayGrade(1, gradePoint.GP1, gradePoint.Grade1);
            gpresentation.DisplayGrade(2, gradePoint.GP2, gradePoint.Grade2);
            gpresentation.DisplayGrade(3, gradePoint.GP3, gradePoint.Grade3);
            gpresentation.DisplayGrade(4, gradePoint.GP4, gradePoint.Grade4);
            gpresentation.DisplayGrade(5, gradePoint.GP5, gradePoint.Grade5);
            WriteLine("*********************");
            WriteLine("Grade Point Average {0,10:F2}{1,20}", gpa, gradePoint.CalculateHonors(gpa));
            ReadKey();

        }
    }
}
