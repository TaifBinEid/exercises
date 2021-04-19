using System;

namespace StartEndNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            if (HowManyNumMatch(" ") > 0)
                Console.WriteLine("The matched number is :  " + HowManyNumMatch("999"));
            else
            {
                    Console.WriteLine("There is no matched number !");
            }

        }



    public static int HowManyNumMatch(String number)
        {
            
            int count = 0; 
            for( int i = 0; i <number.Length ;  i++)
            {
                if (number.Contains(number[i]))
                {
                    count++;
                    

                }
                else
                {
                    return 0;
                }
            }
            return count;
        }
    }
}
