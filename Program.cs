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

            int myNumber2 = 30;
            Object obj2 = new Object();
            obj2 = 50;
            Console.WriteLine("\nThe number in integer before unboxing is : " + myNumber2);
            //myNumber = obj2; implicit conversion not possible gives error 
            myNumber2 = (int)obj2; //explicit converion 
            Console.WriteLine("The number in integer after unboxing is : " + myNumber2);


        }
    }
}
