/*Carlos is a huge fan of something he calls smooth sentences.
A smooth sentence is one where the last letter of each word is identical to the first letter the following word.

To illustrate, the following would be a smooth sentence: "Carlos swam masterfully."

Since "Carlos" ends with an "s" and swam begins with an "s" and swam ends with an "m" and masterfully begins with an "m".*/

public class Program 
{
    public static bool IsSmooth(string sentence) 
    {
			char? toMatch=null;
			var words= sentence.Split(' ');
			foreach (string word in words)
			{
				if(toMatch ==null)
				{
					toMatch=word[word.Length-1];
				}
				else if(char.ToLower(word[0])==char.ToLower(toMatch.Value))
				{
					toMatch=word[word.Length-1];
				}
				else
				{
					return false;
				}
			}
			return true;
    }
}
