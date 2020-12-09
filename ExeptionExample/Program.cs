using System;

namespace ExeptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodDivideByZeroException();
            //MethodIndexOutOfRangeException();
            CreateUser();
        }
        static void MethodDivideByZeroException()
        {
            Console.Write("Please input number");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            int sNumber = 0;
            try
            {
                int result = fNumber / sNumber;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException exMessage) when (sNumber==0)
            {
                Console.WriteLine($"OHOHOHO! {exMessage.Message}");
            }
        }
        static void MethodIndexOutOfRangeException()
        {
            int[] arrnumber = new int[10];
            try
            {
                arrnumber[11] = 100;
            }
            catch(IndexOutOfRangeException exObject)
            {
                Console.WriteLine($"InnerException - {exObject.InnerException}");
                Console.WriteLine($"Message - {exObject.Message}");
                Console.WriteLine($"Source - {exObject.Source}");
                Console.WriteLine($"StackTrace - {exObject.StackTrace}");
                Console.WriteLine($"TargetSite - {exObject.TargetSite}");
                Console.WriteLine(exObject.Message);
            }
        }
        static void CreateUser()
        {
            Console.Write("Please input your name:");
            string nameUser = Console.ReadLine();
            Console.Write("Please input your age:");
            double ageUser = Convert.ToDouble(Console.ReadLine());
            Person userPerson = new Person(nameUser, ageUser);
        }
    }
}
