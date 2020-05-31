public class Program
{
	/*Hamming distance is the number of characters that differ between two strings.
	Create a function that computes the hamming distance between two strings.*/
    public static int HammingDistance(string str1, string str2)
    {
			int toReturn=0;
			for(int i=0;i<str1.Length;i++)
			{
				if(str1[i]!=str2[i])
				{
					toReturn++;
				}
			}
			return toReturn;
    }
}