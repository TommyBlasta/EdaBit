
/*Create a function that takes a character and a string as arguments and returns the number
 of times the character is found in the string.*/
public class Program 
{
    public static int CharCount(char myChar, string str) 
    {
			int counter=0;
			for(int i=0;i<str.Length;i++)
			{
				if(str[i]==myChar)
				{
					counter++;
				}
			}
			return counter;
    }
}