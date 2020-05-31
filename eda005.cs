public class Program
{
/*Create a function to multiply all of the values in an array by the amount of values in the given array.*/
	public static int[] MultiplyByLength(int[] arr)
	{
		int[] toReturn=new int[arr.Length];
		for(int i=0;i<arr.Length;i++)
		{
			toReturn[i]=arr[i]*arr.Length;
		}
		return toReturn;
	}
}