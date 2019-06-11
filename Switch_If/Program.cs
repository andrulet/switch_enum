using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_If
{
    class Program
    {
        enum Operation
        {
            Add=1,
            Subtract,
            Multiply,
            Divide
        }

        static void Math_operation(double x,double y, Operation op)
        {
            double result = 0.0;

            switch(op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x *y;
                    break;
                case Operation.Divide:
                    result = x/y;
                    break;
            }
            Console.WriteLine("Result of operation = {0}",result);

        }
        static void Main(string[] args)
        {
            Math_operation(5,4,Operation.Add);
            Console.ReadLine();
        }
    }
}
