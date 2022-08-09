using System;

namespace ExtraOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var add= a + b;
            var sub = a - b;
            var mult = a * b;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("what is the radius of the circle you wish to find the area of ?");
            var radius = double.Parse(Console.ReadLine());

            var AreaOfCircle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of your circle is {AreaOfCircle}");

            // Thought Excerise

            var i = 3;
            var j = 4;

            var k = ++i * j++;
            // ^^ I believe this will be 4*4 which is 16

            Console.WriteLine(k);






        }
    }
}

