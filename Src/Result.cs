using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

        public static List<int> gradingStudents(List<int> grades)
        {
            var newGrades = new List<int>(){};
            foreach (var grade in grades)
            {
                if (grade < 38) 
                {
                    newGrades.Add(grade);
                    continue;
                }
                if (grade >= 38 && grade % 5 > 2) {
                    newGrades.Add(grade - (grade % 5) + 5);
                } else {
                    newGrades.Add(grade);
                }
            }
            return newGrades;
        }
    }
}