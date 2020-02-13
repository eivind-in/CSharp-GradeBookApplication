using System;
using System.Linq;

using GradeBook.Enums;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool IsWeighted) : base(name, IsWeighted)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new System.InvalidOperationException(
                    "Ranked-grading requires a minimum of 5 students to work");
            }
            if(averageGrade >= 80)
                return 'A';
            else if(averageGrade >= 60)
                return 'B';
            else if(averageGrade >= 40)
                return 'C';
            else if(averageGrade >= 20)
                return 'D';
            else
                return 'F';
        }

        public override void CalculateStatistics()
        {
            if(Students.Count < 5)
            {
                Console.WriteLine(
                    "Ranked grading requires at least 5 students " + 
                    "with grades in order to properly calculate a "+
                    "student's overall grade.");
                return;
            }
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if(Students.Count < 5)
            {
                Console.WriteLine(
                    "Ranked grading requires at least 5 students " + 
                    "with grades in order to properly calculate a "+
                    "student's overall grade.");
                return;
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
    
}