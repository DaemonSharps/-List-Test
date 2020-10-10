using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List_Test
{
    class List
    {
        private List<int> nums=new List<int>();
        public List(params int[] par)
        {
            if (par.Length != 0)
            {
                for (int i = 0; i < par.Length; i++)
                {
                    nums.Add(par[i]);
                }
            }
            else
            {
                throw new Exception("List must contain at least 1 element.");
            }
           
          
        }
        public void ListShow()
        {
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
        public void ListDel(int value)
        {
            if (nums.Contains(value))
            {
                nums = nums.Where(x => x != value).ToList();
               

            }
            
        }
    }
}
