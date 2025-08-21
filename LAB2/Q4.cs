using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB2
{
    class Q4
    {
        static void Main(string[] args)
        {
            // Input numbers
            Console.Write("Enter number A: ");
            string inputA = Console.ReadLine();
            Console.Write("Enter number B: ");
            string inputB = Console.ReadLine();

            // Conversions to different data types
            int a = int.Parse(inputA);
            int b = int.Parse(inputB);
            float af = float.Parse(inputA);
            float bf = float.Parse(inputB);
            double ad = double.Parse(inputA);
            double bd = double.Parse(inputB);
            decimal amd = decimal.Parse(inputA);
            decimal bmd = decimal.Parse(inputB);

            Console.WriteLine("\n=== Integer Operations ===");
            Console.WriteLine($"A + B = {a + b}");
            Console.WriteLine($"A - B = {a - b}");
            Console.WriteLine($"A * B = {a * b}");
            Console.WriteLine($"A / B = {a / b}");
            Console.WriteLine($"A % B = {a % b}");
            Console.WriteLine($"A == B ? {a == b}");
            Console.WriteLine($"A > B ? {a > b}");
            Console.WriteLine($"A < B ? {a < b}");

            Console.WriteLine("\n=== Float Operations ===");
            Console.WriteLine($"A / B = {af / bf}");
            Console.WriteLine($"A * B = {af * bf}");

            Console.WriteLine("\n=== Double Operations ===");
            Console.WriteLine($"A / B = {ad / bd}");
            Console.WriteLine($"A * B = {ad * bd}");

            Console.WriteLine("\n=== Decimal Operations ===");
            Console.WriteLine($"A + B = {amd + bmd}");
            Console.WriteLine($"A - B = {amd - bmd}");

            Console.WriteLine("\n=== Boolean & Logical Operators ===");
            bool cond1 = a > b;
            bool cond2 = a % 2 == 0;
            Console.WriteLine($"A > B = {cond1}");
            Console.WriteLine($"A is Even? {cond2}");
            Console.WriteLine($"(A > B) && (A Even)? {cond1 && cond2}");
            Console.WriteLine($"(A > B) || (A Even)? {cond1 || cond2}");

            Console.WriteLine("\n=== Character & String Operations ===");
            char c1 = (char)(65 + a % 26); // convert number to char
            char c2 = (char)(65 + b % 26);
            Console.WriteLine($"Char from A: {c1}, Char from B: {c2}");
            string s1 = inputA;
            string s2 = inputB;
            Console.WriteLine($"Concatenation: {s1 + s2}");
            Console.WriteLine($"String Equality: {s1 == s2}");

            Console.WriteLine("\n=== Bitwise Operators (int) ===");
            Console.WriteLine($"A & B = {a & b}");
            Console.WriteLine($"A | B = {a | b}");
            Console.WriteLine($"A ^ B = {a ^ b}");
            Console.WriteLine($"~A = {~a}");
            Console.WriteLine($"A << 1 = {a << 1}");
            Console.WriteLine($"A >> 1 = {a >> 1}");

            Console.WriteLine("\n=== Unary Operators ===");
            Console.WriteLine($"++A = {++a}");
            Console.WriteLine($"--B = {--b}");

        }
    }
}