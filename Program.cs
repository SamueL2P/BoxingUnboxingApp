using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Boxing 
            //Converting Value type to reference type 

            int myNumber = 20;
            Object obj = new Object();
            obj = 40;
            Console.WriteLine("The number in object before boxing is : " + obj);
            obj = myNumber; //implicit conversion 
            Console.WriteLine("The number in object after boxing is : " + obj);

            //UnBoxing 
            //Converting Reference type to value type
            myNumber = 40;
            Console.WriteLine("\nThe integer before unboxing is : " + myNumber);
            //myNumber = obj; implicit conversion not possible gives error
            myNumber = (int)obj; //explicit converion 
            Console.WriteLine("The integer after unboxing is : " + myNumber);


        }
    }
}
