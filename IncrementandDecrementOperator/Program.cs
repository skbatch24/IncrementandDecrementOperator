using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementandDecrementOperator
{
    /*
     * Increment operator is used to increase the value by 1.
     * Increment operator is once again having two types.
     * operator for increment is (++)
     * we use under looping statemetns to increase the values.
     * 1)pre increment :
     * under pre increment value will be assigned before itself.
     * ex for pre increment
     * a=10
     * ++a is pre increment.
     * 2)post increment:
     * after compilation the value will be incremented.
     * a=10
     * a++ is post increment
     * 
     * Decrement operator is used to decrease the value by one.
     * operator sign is (--)
     * 1)pre decrement:
     * under pre decrement value will be decrease before 
     * a=100
     * --a;
     * 2)post decrement:
     * after compilation the value will be decremented.
     * a=100
     * a--
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of a is {0}", a);
            Console.WriteLine("while pre incrementing the value {0}", ++a);//
            Console.WriteLine("while after pre incrementing {0}", a);
     


            Console.WriteLine("enter a value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of b is {0}", b);
            Console.WriteLine("while post incrementing the value is {0}", b++);//
            Console.WriteLine("after post incrementing the value is {0}", b);

            Console.WriteLine("enter a value");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of c is {0}", c);
            Console.WriteLine("while pre decrementing the value {0}", --c);
            Console.WriteLine("after pre decrement is {0}", c);

            Console.WriteLine("enter a value");
            int d=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of d is {0}", d);
            Console.WriteLine("while post decrement the value is {0}", d--);
            Console.WriteLine("after post decrement is {0}", d);
        }
    }
}
