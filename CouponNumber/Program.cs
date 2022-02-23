using System;

namespace CouponNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of distinct coupons you wish to enter:");
            int quantity=Convert.ToInt32(Console.ReadLine());
            int[] coupons=new int[quantity];
            for(int i=0;i<quantity;i++)
            {
                Console.WriteLine("Enter coupon number:");
                coupons[i]=Convert.ToInt32(Console.ReadLine());
            }
            FindMinMax.find(coupons);
        }
    }

}