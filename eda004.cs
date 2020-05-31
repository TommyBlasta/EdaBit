using System;
public class Program
{
	/*Create a function that returns the smaller number.*/
	//without convertin to Int32
	public static string smallerNum(string n1, string n2)
	{
		if(n1.Length<n2.Length)
		{
			return n1;
		}
		else if(n1.Length>n2.Length)
		{
			return n2;
		}
		else
		{
			for(int i=0;i<n1.Length;i++)
			{
				if((int)n1[i]<(int)n2[i])
				{
					return n1;
				}
				if((int)n2[i]<(int)n1[i])
				{
					return n2;
				}
			}
		}
		return n1;
	}
}