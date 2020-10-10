using System;
using System.Collections.Generic;

namespace List_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() {1,5,8,3,4,4,234234,153,1234,568,4,681,4,26,2,3,56323,3,64,7989,12,4,7,9 };
            int value;
            ListShow(nums);
            Console.Write("Print number you want to delete: ");
            value=int.Parse(Console.ReadLine());
            ListDel(nums,value);
            ListShow(nums);
            Console.ReadKey();

            void ListShow(List<int> nums)
            {
                foreach (int num in nums)
                {
                    Console.WriteLine(num);
                }
            }
            void ListDel(List<int> list, int val)
            {
                if (list.Contains(val))
                {
                    foreach (int num in list)
                    {
                        if (num == val)
                        {
                            list.Remove(val);
                        }
                    }
                }
            }
        }
       
        

    }  
}
