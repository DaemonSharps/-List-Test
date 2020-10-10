using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List nums = new List(1,2,2,2,2,2,2,2,2,2,5,5,4,4,22,6,7);

            nums.ListShow();
            Console.Write("Print number you want to delete: ");
           
            nums.ListDel(int.Parse(Console.ReadLine()));
            nums.ListShow();
            Console.ReadKey();

            
           
        }
       
        

    }  
}
