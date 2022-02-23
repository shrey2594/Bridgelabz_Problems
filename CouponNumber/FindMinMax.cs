using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponNumber
{
    public class FindMinMax
    {
        public static void find(int[] arr )
        {
            int max=0;
            int min=arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>max)
                {
                    max=arr[i];
                }
                if(arr[i]<min)
                {
                    min=arr[i];
                }
            }
            GenerateCoupon.coupon(arr,min,max);
        }
    }
}
