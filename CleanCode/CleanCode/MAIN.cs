using System;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {

            // TODO Auto-generated method stub
            int X = 5; int Y = 5;
            int Z = 5;


            Console.WriteLine("\n*****************************");
            Console.WriteLine("In our store we have:");
            Console.WriteLine(X + " apples");
            Console.WriteLine(Y + " bananas");
            Console.WriteLine(Z + " oranges");
            Console.WriteLine("\n*****************************");
            Console.WriteLine("Bananas delivery");
            Y += 3;

            Console.WriteLine("\n*****************************");
            Console.WriteLine("In our store we have:");
            Console.WriteLine(X + " apples");
            Console.WriteLine(Y + " bananas");
            Console.WriteLine(Z + " oranges");
            int K = 8 - Z;
            ORANGES:
            while (K >= 0)
            {
                K--;
                Console.WriteLine("\n*****************************");
                Console.WriteLine("Customer wants 8 oranges");
                if (Z >= 8)
                {
                    Console.WriteLine("We have 8 oranges or more, so we can continue.");
                    Z -= 8;
                    goto CONTINUE;
                }
                else
                {
                    Console.WriteLine("We don't have enough. So we get quick delivery of 1 orange");
                    Z++;
                    Console.WriteLine("\n*****************************");
                    Console.WriteLine("In our store we have:");
                    Console.WriteLine(X + " apples");
                    Console.WriteLine(Y + " bananas");
                    Console.WriteLine(Z + " oranges");
                    goto ORANGES;
                }
            }
            CONTINUE:
            Console.WriteLine("\n*****************************");
            Console.WriteLine("In our store we have:");
            Console.WriteLine(X + " apples");
            Console.WriteLine(Y + " bananas");
            Console.WriteLine(Z + " oranges");
            Z = 20;
            X += 9;
            Y -= 2; X++;
            if (!(Z < Y && X < Y)) { X++; } else { Z--; }
            Console.WriteLine("\n*****************************");
            Console.WriteLine("In our store we have:");
            Console.WriteLine(X + " apples");
            Console.WriteLine(Y + " bananas");
            Console.WriteLine(Z + " oranges");
            Console.WriteLine("\n*****************************");
            Console.WriteLine("Customer wants 2 apples");
            if (X >= 2)
            {
                Console.WriteLine("We have 8 oranges or more, so we can continue.");
                Z -= 2;
            }
            else
            {
                Console.WriteLine("We don't have enough. So we get quick delivery of 1 orange");
                Z++;
                Console.WriteLine("\n*****************************");
                Console.WriteLine("In our store we have:");
                Console.WriteLine(X + " apples");
                Console.WriteLine(Y + " bananas");
                Console.WriteLine(Z + " oranges");
            }
            Console.WriteLine("\n*****************************");
            Console.WriteLine("In our store we have:");
            Console.WriteLine(X + " apples");
            Console.WriteLine(Y + " bananas");
            Console.WriteLine(Z + " oranges");

            Console.WriteLine("\n*****************************");
            Console.WriteLine("Customer wants 3 apples");
            if (X >= 3)
            {
                //Console.WriteLine("We have 8 oranges or more, so we can continue.");
                X -= 3;
            }
            else
            {
                //Console.WriteLine("We don't have enough. So we get quick delivery of 1 orange");
                X++;
                Console.WriteLine("\n*****************************");
                Console.WriteLine("In our store we have:");
                Console.WriteLine(X + " apples");
                Console.WriteLine(Y + " bananas");
                Console.WriteLine(Z + " oranges");
            }
            Console.WriteLine("\n*****************************");
            Console.WriteLine("In our store we have:");
            Console.WriteLine(X + " apples");
            Console.WriteLine(Y + " bananas");
            Console.WriteLine(Z + " oranges");
            Console.WriteLine("\n*****************************");
            Console.WriteLine("Update prices in Console");
            double A, B, C = 0.0; A = 0.6;
            A = A * 1.20;
            Console.WriteLine("a : " + A);
            B = 1.4;
            if (B * 1.2 > 1.5) Console.WriteLine("[super-fruit] b : " + B * 1.2); else Console.WriteLine("b : " + B * 1.2);
            C = 2 * 1.2;
            Console.WriteLine("c : " + A);

            Console.ReadKey();


        }
    }
}