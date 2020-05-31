using System;
public class Program 
{
	/*Given a string, create a function to reverse the case.
	All lower-cased letters should be upper-cased, and vice versa.*/
    public static string ReverseCase(string str) 
    {
			string toReturn="";
			foreach(char c in str)
			{
				if(!Char.IsLetter(c))
					toReturn+=c;
				else
				{
				if(Char.IsLower(c))
					toReturn+=Char.ToUpper(c);
				if(Char.IsUpper(c))
					toReturn+=Char.ToLower(c);
				}
			}
			return toReturn;	 
    }
}