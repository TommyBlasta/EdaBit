using System;
using System.Linq;
public class Program
{
/*Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.*/
		public static string Reverse(string s)
		{
			string toReturn="";
			for(int i=s.Length-1;i>-1;i--)
			{
				toReturn+=s[i];
			}
			return toReturn;
		}
    public static string ReverseAndNot(int i) {
			 return Reverse(i.ToString())+i.ToString();
		}
}