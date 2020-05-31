public class Program
{
/*Create a function that repeats each character in a string n times.*/
    public static string Repeat(string str, int num)
    {
			string toReturn="";
			foreach(char c in str)
			{
				for(int i=1;i<=num;i++)
					toReturn+=c;
			}
			return toReturn;
    }
}