using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PerformanceOfPrimitiveTypes
{
    class TestPerformance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition (in order - int, float, long, double, decimal):");         
            Console.WriteLine(AdditionProcedure.AddInt(16, 100000));
            Console.WriteLine(AdditionProcedure.AddFloat(16.4f, 100000f));
            Console.WriteLine(AdditionProcedure.AddLong(16L, 100000L));
            Console.WriteLine(AdditionProcedure.AddDouble(16.4d, 100000d));
            Console.WriteLine(AdditionProcedure.AddDecimal(16.4m, 100000m));
            Console.WriteLine();

            Console.WriteLine("Substraction (in order - int, float, long, double, decimal):");  
            Console.WriteLine(SubstractionProcedure.SubstractInt(16, 100000));
            Console.WriteLine(SubstractionProcedure.SubstractFloat(16.4f, 100000f));
            Console.WriteLine(SubstractionProcedure.SubstractLong(16L, 100000L));
            Console.WriteLine(SubstractionProcedure.SubstractDouble(16.4d, 100000d));
            Console.WriteLine(SubstractionProcedure.SubstractDecimal(16.4m, 100000m));
            Console.WriteLine();

            Console.WriteLine("Multiplication (in order - int, float, long, double, decimal):");
            Console.WriteLine(MultiplicationProcedure.MultiplyInt(16, 100000));
            Console.WriteLine(MultiplicationProcedure.MultiplyFloat(16.4f, 100000f));
            Console.WriteLine(MultiplicationProcedure.MultiplyLong(16L, 100000L));
            Console.WriteLine(MultiplicationProcedure.MultiplyDouble(16.4d, 100000d));
            Console.WriteLine(MultiplicationProcedure.MultiplyDecimal(16.4m, 100000m));
            Console.WriteLine();

            Console.WriteLine("Division (in order - int, float, long, double, decimal):");
            Console.WriteLine(DivisionProcedure.DivideInt(16, 100000));
            Console.WriteLine(DivisionProcedure.DivideFloat(16.4f, 100000f));
            Console.WriteLine(DivisionProcedure.DivideLong(16L, 100000L));
            Console.WriteLine(DivisionProcedure.DivideDouble(16.4d, 100000d));
            Console.WriteLine(DivisionProcedure.DivideDecimal(16.4m, 100000m));
            Console.WriteLine();

            Console.WriteLine("Increment (in order - int, float, long, double, decimal):");
            Console.WriteLine(IncrementProcedure.IncrementInt(16, 100000));
            Console.WriteLine(IncrementProcedure.IncrementFloat(16.4f, 100000f));
            Console.WriteLine(IncrementProcedure.IncrementLong(16L, 100000L));
            Console.WriteLine(IncrementProcedure.IncrementDouble(16.4d, 100000d));
            Console.WriteLine(IncrementProcedure.IncrementDecimal(16.4m, 100000m));
            
        }
    }
}
