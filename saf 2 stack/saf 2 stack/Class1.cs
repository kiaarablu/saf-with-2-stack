using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saf_2_stack
{
    internal class Class1
    {
        int[] array1;
        int[] array2;
        int top1 = -1;
        int top2 = -1;
        int arraylength;

        public Class1(int len)
        {
            arraylength = len;
            array1 = new int[arraylength];
            array2 = new int[arraylength];
        }

        public bool isfull()
        {
            if (top1 >= array1.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isempty()
        {
            if (top1 == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Enqueue(int val)
        {
            if (!isfull())
            {
                top1++;
                array1[top1] = val;
            }
            else
            {
                Console.WriteLine("table is full");
            }
        }
        //public void dequeue()
        //{
        //    if (!isempty())
        //    {
        //        for (int i = top1; i == 0; i--)
        //        {
        //            top2+=3;
        //            array2[top2] = array1[i];
        //            top1--;
        //        }
        //        //int x = array2[top2];
        //        //Console.WriteLine(x);
        //        top2--;
        //        for (int j = top2; j == 0; j--)
        //        {
                    
        //            array1[top1] = array2[j];
        //        }
               
        //    }
        //    else
        //    {
        //        Console.WriteLine("table is empty");
        //    }

        //}
        public void Deqeueu()
        {
            if (!isempty())
            {
                for (int i = top1; i > -1; i--)
                {
                    top2++;
                    array2[top2] = array1[i];
                }
                top2 --;
                for (int j = top2; j > -1; j--)
                {
                    top1 = 0;
                    array1[top1]= array2[j];
                    top1++;
                }
                 

            }

        }

        public void printnum()
        {
            for(int i = 0; i <= top1; i++)
                Console.WriteLine(array1[i]);
            
        }
        




    }
}
