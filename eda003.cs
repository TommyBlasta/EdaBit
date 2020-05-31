public class Program
{
/*Write a function that returns true if all characters in a string are identical and false otherwise.*/
    public static bool isIdentical(string str)
    {
			char firstCharacter=str[0];
			foreach(char c in str)
			{
				if(!(c==firstCharacter))
				{
					return false;
				}
			}
			return true;
    }
}