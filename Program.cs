using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_cycles1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, lastName;
            int Grade;
            int problemsNum=0;
            int badGradeNum;
            int badGrades=0;
            double average=0;
            

            Console.WriteLine("Maximum poor grades: ");
            badGradeNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Name of problem: ");
            name = Console.ReadLine();
            lastName = name;

            while (name != "Enough")
            {
                Console.WriteLine("Grade: ");
                Grade = int.Parse(Console.ReadLine());
                if(Grade<2 || Grade > 6)
                {
                    throw new ArgumentException("Invalid grade.");
                }

                if (Grade <= 4)
                {
                    badGrades++;
                }

                if (badGrades == badGradeNum)
                {
                    break;
                }

                else
                {
                    problemsNum++;
                    average = average + Grade;
                }

                Console.WriteLine("Name of problem: ");
                name = Console.ReadLine();
                if(name!= "Enough")
                {
                    lastName = name;
                }
            }

            

            if (badGrades == badGradeNum)
            {
                Console.WriteLine("You need a break, {0} poor grades.", badGrades);
            }

            else
            {
                average = average / problemsNum;
                Console.WriteLine("Average score: {0}",average);

                Console.WriteLine("Number of problems: {0}", problemsNum);

                Console.WriteLine("Last problem: {0}", lastName);
            }

            Console.ReadLine();
        }
    }
}
