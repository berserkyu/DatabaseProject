using System;

public class ProgramCore
{
	public ProgramCore()
	{
		
        
    }
    public static string ageGroup(string i)
    {
        switch (i)
        {
            case "1":
                return "7-8";
            case "2":
                return "9-10";
            case "3":
                return "11-12";
            default:
                return "其他";
        }
    }
}
