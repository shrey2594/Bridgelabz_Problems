using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponNumber
{
    public class CheckEqual
    {
        public static bool compare(int [] arr,int [] arr1)
        {
            int[] vs = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                vs[i] = arr[i];
            }
            int[] vs2 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                vs2[i] = arr1[i];
            }
            Array.Sort (vs);
            Array.Sort(vs2);
            for (int i = 0; i < arr.Length; i++)
            {
                if (vs[i] != vs2[i])
                {
                    return false;

                }
            }   
            return true;
        }
    }
}
