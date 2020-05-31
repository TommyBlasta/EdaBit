/*Create a function that takes a base number and an exponent number and returns the calculation.*/
public class Program 
{
    public static long CalculateExponent(long number, long exponent) 
    {
			if(exponent ==1)
			{
				return number;
			}
			return number*CalculateExponent(number,exponent-1);
    }
}