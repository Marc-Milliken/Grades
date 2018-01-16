﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GradeBook book = new GradeBook();
            book.Name = "Marc's Grade Book:";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(book.Name);
            WriteResult("Average", stats.averageGrade);
            WriteResult("Highest", (int)stats.highestGrade);
            WriteResult("Lowest", (int)stats.lowestGrade);
            
        }


        static void WriteResult(string description, int result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result);
        }


        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}", description, result); //Different way to do the same thing as above WriteResult
        }

    }
}