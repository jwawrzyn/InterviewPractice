using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter5Bits;
using System.Collections;

namespace ConsoleWriting
{
    class Program
    {
        static void Main(string[] args)
        {

            Question1 test = new Question1();

            Console.WriteLine("Chapter 5 Question 1");

            Console.WriteLine(test.UpdateBits(100, 10, 2, 6));
            Console.WriteLine(test.UpdateBits(100, 10, 2, 5));

            Console.WriteLine("Chapter 5 Question 2");
            Question2 test2 = new Question2();
            var binaryString = test2.PrintBinary2(.125);
            Console.WriteLine(binaryString);

            for (var i = 0; i < 1000; i++)
            {
                var num = i / 1000.0;
                var binary = test2.PrintBinary(num);
                var binary2 = test2.PrintBinary2(num);

                if (!binary.Equals("ERROR") || !binary2.Equals("ERROR"))
                {
                    Console.WriteLine(num + " : " + binary + " " + binary2);
                }
            }


            Console.WriteLine("Chapter 5 Question 3");
            Question3 test3 = new Question3();
            int result = test3.BruteForce(1775);
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
