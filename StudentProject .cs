using System;
using System.Collections.Generic;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfname = new List<string>();

            List<int> listOfGrade = new List<int>();


            string choice;

               while (true){

                Console.WriteLine(" Please Enter Your Name :");
                listOfname.Add(Console.ReadLine());

                Console.WriteLine(" Please Enter Your Grade :");
                listOfGrade.Add(int.Parse(Console.ReadLine()));


                Console.WriteLine(" Do You Want Add Another Student ? ( Yes / No ) :");
                choice = Console.ReadLine();

                if (choice == "No" || choice == "no")
                {
                    break;

                }

            }

            for (int i = 0; i < listOfname.Count; i++)
            {
                Console.WriteLine("Student Name : " + listOfname[i] + " , " +
                                  "Student Grade : " + listOfGrade[i] + "  "

                                                                                                 );
            }

            Console.WriteLine("Enter the grade to search : ");
            int inputSearch = int.Parse(Console.ReadLine());
            CountGradeOfStudent(listOfGrade, inputSearch);



        }
        //this is method counter number of student have the same result by list of grade and the number of grade you need to search
        
        public static void CountGradeOfStudent(List<int> listGrade , int searchGrade)
        {
            int counter = 0; 
            foreach (var g in listGrade)
            {
             if(g == searchGrade)
                {
                    counter++;
                }

               
            }
            Console.WriteLine("Number Of Student With Grade : " + searchGrade + "  is : " + counter);


        }


    }
}
