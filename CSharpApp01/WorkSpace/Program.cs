using System;

namespace WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            People people = new People(); 
            Console.ReadLine();

        }

        public class People
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int BirthDate  { get; set; }
            public long TcNumber { get; set; }


        }
    }
}
