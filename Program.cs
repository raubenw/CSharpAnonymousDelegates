using System;

namespace CSharpAnonymousDelegates
{

    public delegate string MyDelegate(int arg1, int arg2);

    class Program
    {

        static void Main(string[] args)
        {
            MyDelegate f = delegate (int a, int b)
            {
                return (a + b).ToString();
            };

            Console.WriteLine("Anonymous delegate result = " + f(20, 30));
        }
    }
}