using System;
using System.ComponentModel.Design;
using System.Numerics;
using System.Security.Cryptography;

namespace Comeplexnumbersoperation
{
    class Badro
    {
        static void Main(string[] args)

        {
            while (true)
            { 
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice != 5)
                {
                    Console.WriteLine("Complex Numbers using all Arithmetic Operations");

                    Console.Write("Enter real part of first complex number: ");
                    int real1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter imaginary part of first complex number: ");
                    int imag1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter real part of second complex number: ");
                    int real2 = int.Parse(Console.ReadLine());

                    Console.Write("Enter imaginary part of second complex number: ");
                    int imag2 = int.Parse(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Addition:" + (real1 + real2) + "+" + (imag1 + imag2) + "i");
                            break;
                        case 2:
                            Console.WriteLine("Subtraction: " + (real1 + real2) + "-" + (imag1 + imag2) + "i");
                            break;
                        case 3:
                            Console.WriteLine("Multiplication: " + ((real1 * real2) - (imag1 * imag2)) + "+" + ((real1 * imag2) + (imag2 * real1)) + "i");
                            break;
                        case 4:
                            Console.WriteLine("Division: " + (((real1 * real2) + (imag1 * imag2)) / ((real2 * real2) + (imag2 * imag2))) + "+" + (((imag1 * real2) + (real1 * imag2)) / Convert.ToInt32((real2 * real2) + (imag2 * imag2)) + "i")); break;
                       
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                else
                {
                    switch (choice)
                    {

                        case 5:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    
                    }
                    
                }
            }
        }
    }
}