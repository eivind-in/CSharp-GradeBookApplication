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
        public RankedGradeBook(string name) : base(name)
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
    }
    
}