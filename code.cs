using System;
					
public class Program
{

	
	public static void Main()
	{
		bool isOpenBracked = false;
		var valueAsString = "000000[]a3d003d5[0.5]xxyy[4444411144]";
    var ret = "";

    for (var i = 1; i <= valueAsString.Length; i++)
    {
        var p = valueAsString[i - 1];
		if (isOpenBracked)
		{	
			while(isOpenBracked == true)
			{
				p = valueAsString[i - 1];
				if (p == ']')
				{
					isOpenBracked = false;
				}
				ret += p;
				i++;
				
			}
			i--;
		}
		else if (p == '[')
		{
			isOpenBracked = true;
			ret += p;

		}
		else
		{
			ret += p;
			if (i % 2 == 0)
				ret += " ";
		}
		
    }

    Console.WriteLine(ret.Trim());

	}
}
