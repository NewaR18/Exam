using System;
namespace indexer
{
    class employee
    {
        int id;
        string name;
        string job;
        double salary;
        public employee(int id, string name, string job, double salary)
        {
            this.id = id;
            this.name = name;
            this.job = job;
            this.salary = salary;
        }
        public object this[int x]
        {
            get
            {
                if (x == 0)
                {
                    return this.id;
                }
                else if (x == 1)
                {
                    return this.name;
                }
                else if (x == 2)
                {
                    return this.job;
                }
                else if (x == 3)
                {
                    return this.salary;
                }
                else
                {
                    return "error";
                }

            }
            set
            {

                if (x == 0)
                {
                    this.id = (int)value;
                }
                else if (x == 1)
                {
                    this.name = (string)value;
                }
                else if (x == 2)
                {
                    this.job = (string)value;
                }
                else if (x == 3)
                {
                    this.salary = (double)value;
                }
                else
                {
                    this.id = 0;
                    this.name = "";
                    this.job = "";
                    this.salary = 0;
                }
            }
        }
    }
    internal class Indexerdemo
    {
        static void Main(string[] args)
        {
            employee e1 = new employee(3, "Sudip", "Senior Developer", 100000.15);
            Console.WriteLine("Employee info: \n" + "id = " + e1[0] + "\n" + "Name = " + e1[1] + "\n" + "Job = " + e1[2] + "\n" + "Salary = " + e1[3]);
        }
    }
}