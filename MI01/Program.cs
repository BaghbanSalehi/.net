using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI01
{

    class Student
    {
        private string name;
        private double score = -1;
            public string nameSetter
        {
           
            set {

                if (value.Length < 2)
                    Console.WriteLine("Name must have atleast to letters! please try again");
                else
                    name = value;
                
                        }
            get { return name; }
           

        }

        public double scoreSetter
        {
            set
            {
                
                if (value < 0 || value > 20)
                    Console.WriteLine("Wrong value for score.Score must be between 0 and 20 please try again.");
                else
                    score = value;
            }
            get { return score; }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            Program p1 = new Program();
            p1.work();


        }

        void work()
        {
            Student student = new Student();
            while(student.nameSetter == null) {
                Console.WriteLine("Please enter a student name: ");
                student.nameSetter = Console.ReadLine();
            }
           while(student.scoreSetter == -1)
            {
                Console.WriteLine("Please enter a score for this student: ");
                student.scoreSetter = Convert.ToDouble(Console.ReadLine());
            }
          
            Console.WriteLine("The student name is " + student.nameSetter + " and his score is " + student.scoreSetter);
        }
    }
}
