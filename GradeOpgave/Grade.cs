using System;

namespace GradeOpgave
{
    public class Grade : IGrade
    {
        public int ToGrade(int procent)
        {
            if (procent < 0)
            {
                throw new Exception();
            }

            if (procent < 6)
            {
                return -3;
            }

            if (procent is < 50)
            {
                return 0;
            }

            if (procent is < 60)
            {
                return 2;
            }

            if (procent is < 80)
            {
                return 4;
            }

            if (procent is < 85)
            {
                return 7;
            }

            if (procent is < 95)
            {
                return 10;
            }
            
            
            return 12;

        }
    }
}