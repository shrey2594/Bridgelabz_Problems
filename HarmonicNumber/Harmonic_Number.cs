namespace Harmonic_Number
{
    public class Harmonic_Number
    {
        public static double result(int value)
        {
            double sum = 0;
            for(double i = 1; i <= value; i++)
            {
                sum=sum+(double)(1/i);
            }
            return sum;
        }
    }
}
