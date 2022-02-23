using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponNumber
{
    public class GenerateCoupon
    {
        public static void coupon(int[] arr,int min,int max)
        {
            int[] fake_arr=new int[arr.Length]; 
            int[] new_arr=new int[arr.Length];
            int t=0;
            for(int i=0;i<arr.Length;i++)
            {
                fake_arr[i]=arr[i];
            }
            int count = 0;
            Random rand = new Random();
            while(CheckEqual.compare(arr,new_arr)!=true)
            {
                int coupon=rand.Next(min,max+1);
                for(int i=0;i<new_arr.Length;i++)
                {
                    if(coupon==fake_arr[i])
                    {
                        fake_arr[i]=-1;
                        new_arr[t]=coupon;
                        t++;
                    }
                }
                count++;
            }
            Console.WriteLine("Total random numbers needed:"+count);
        }
    }
}
