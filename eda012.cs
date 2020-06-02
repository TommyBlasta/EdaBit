/*Create a function that takes in n, a, b and returns the number of values raised to the nth power that lie
 in the range [a, b], inclusive.*/
using System;
public class Program 
{
    public static int PowerRanger(int power, int min, int max) 
    {
			int toReturn=0;
			double currentTestValue=0.0;
			var baseValue= Math.Floor(Math.Pow((double)min,1.0/(double)power));
			while(currentTestValue<=max)
			{
				currentTestValue=Math.Pow(baseValue,power);
				if(currentTestValue>=min && currentTestValue<=max)
				{
					toReturn++;
				}
				baseValue++;
			}
			return toReturn;
    }
}
