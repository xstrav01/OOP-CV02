using System;

namespace CV02
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(2, 2);
            Complex b = new Complex(3, -2);
            Complex c = new Complex(2, 2);

            Console.WriteLine(a+b); 
            Console.WriteLine(a-b); 
            Console.WriteLine(a*b); 
            Console.WriteLine(a/b);

            Console.WriteLine(a.Sdruzene());
            Console.WriteLine(a.Modul());
            Console.WriteLine(a.Argument());

            Console.WriteLine(TestComplex.Test(a, a, "stejné"));
            Console.WriteLine(TestComplex.Test(a, b, "rozdílné"));

            Console.ReadLine();
        }
    }
}
