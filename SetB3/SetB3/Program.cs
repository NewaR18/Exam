using System;
namespace Except
{
    public class ExceptionH
    {
        public int s1;
        public int s2;
        public int s3;
        public void DividebyZero()
        {
            try
            {
                Console.Write("Enter First Value: ");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second Value: ");
                s2 = Convert.ToInt32(Console.ReadLine());
                s3 = s1 / s2;
                Console.WriteLine(s1+ " divided by "+ s2 + " is "+s3);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program Finished");
            }
        }
    }
    public class Mainia
    {
        static void Main(string[] args)
        {
            ExceptionH e1=new ExceptionH();
            e1.DividebyZero();
        }
    }
}