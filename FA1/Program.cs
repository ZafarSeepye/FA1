/*using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user to input details aboout the student 
            Console.WriteLine("Enter Student Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Student Surname : ");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter Student Number : ");
            string stn = Console.ReadLine();

            Console.WriteLine("Enter Students Grades To Calculate Average :");

            Console.WriteLine("Enter Subject 1 : ");
            double sub1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Subject 2 : ");
            double sub2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Subject 3 : ");
            double sub3 = Convert.ToDouble(Console.ReadLine());
            //simple calculation for the average and the total scores 

            double total = sub1 + sub2 + sub3;
            double average = total / 3;

            //created and if statement to check if the user wants to change a mark and if they do it will ask them which subject they want to change and the new mark then it will recalculate the total and average and display the results again

            Console.WriteLine("Do you want to change a mark? (yes/no) : ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("Enter Subject Number To Change (1, 2, 3) : ");
                int subNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter New Mark : ");
                double newMark = Convert.ToDouble(Console.ReadLine());

                switch (subNum)
                {
                    case 1: sub1 = newMark; break;
                    case 2: sub2 = newMark; break;
                    case 3: sub3 = newMark; break;
                    default: Console.WriteLine("Invalid Subject Number"); break;
                }


                total = sub1 + sub2 + sub3;
                average = total / 3;


                Console.WriteLine("\n====RESULTS====");
                Console.WriteLine("Student Name & Surname : " + name + " " + surname);
                Console.WriteLine("Student Number : " + stn);
                Console.WriteLine("Total Marks : " + total);
                Console.WriteLine("Average Marks : " + average);
            }
            else
            {
                Console.WriteLine("\n====RESULTS====");
                Console.WriteLine("Student Name & Surname : " + name + " " + surname);
                Console.WriteLine("Student Number : " + stn);
                Console.WriteLine("Total Marks : " + total);
                Console.WriteLine("Average Marks : " + average);
            }

            //after the user has completed the yes or no thhese lines will run regardless ranking the students based of there average 


            if (average < 50)
                Console.WriteLine("Grade : F");
            else if (average < 60)
                Console.WriteLine("Grade : D");
            else if (average < 70)
                Console.WriteLine("Grade : C");
            else if (average < 80)
                Console.WriteLine("Grade : B");
            else
                Console.WriteLine("Grade : A");

            Console.WriteLine("Program Run Time : " + DateTime.Now);
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

*/