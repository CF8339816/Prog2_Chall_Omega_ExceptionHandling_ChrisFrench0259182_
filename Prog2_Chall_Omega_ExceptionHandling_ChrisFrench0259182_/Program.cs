using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Chall_Omega_ExceptionHandling_ChrisFrench0259182_
{
    internal class Program
    {
        static string filepath1 = "TextFile1.txt";
        static string file;
        static int Numerator;
        static int Denominator;
        static int total;
        static void Main(string[] args)
        {
            FileLoader();
                Console.ReadKey(true);
           getNumerator();
                Console.ReadKey(true);
           getDenominator();
                Console.ReadKey(true);
           doEquasion();
                Console.ReadKey(true);
        }
        static void FileLoader()
        {
            try
            {
                file = File.ReadAllText(filepath1);
                  
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($" {file} ");
                Console.ResetColor();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: The file '{filepath1}' was not found, please check the filename.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"You do not have permission to read file {filepath1}.");
            }
            finally 
            {
            Console.WriteLine("Thank you for using this program");
            }
        Console.ReadKey(true);
        Console.Clear();
        }
        static void getNumerator()
        {
            try
            {
                Console.WriteLine("please enter a Numerator");
                Numerator = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"Invalid Input: Error: '{Numerator}' is not a number. Please enter a number.");
                Console.ReadKey(true);
                Console.Clear();
                getNumerator();
            }
        }
        static void getDenominator()
        {
            try
            {
                Console.WriteLine("please enter a denominator");
                Denominator = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.WriteLine($"Invalid Input: Error: '{Denominator}' is not a number. Please enter a number.");
                Console.ReadKey(true);
                Console.Clear();
                getDenominator();
            }
        }
        static void doEquasion()
        {
            try
            {
                total = (Numerator / Denominator);
                Console.WriteLine($"{Numerator}/ {Denominator} = {total}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Error: cannot divide by zero.");
                Console.ReadKey(true);
                Console.Clear();
            }
            finally
            {
                Console.WriteLine("Thank you for using this program");
            }
        }
    }
 }

    

