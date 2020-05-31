/*Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string.
 For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.*/
public enum Month{
				January,
				February,
				March,
				April,
				May,
				June,
				July,
				August,
				September,
				October,
				November,
				December
				}
public class Program 
{
    public static string MonthName(int num) 
    {
			
			return ((Month)(num-1)).ToString();			
    }
}