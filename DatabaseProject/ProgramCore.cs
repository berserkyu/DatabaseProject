using System;

public class ProgramCore
{
	public ProgramCore()
	{
		
        
    }
    public static string ageGroup(string range)
    {
        switch (range)
        {
            case "7-8": case "7": case "8": return "1";
            case "9-10": case "9": case "10": return "2";
            case "11-12": case "11": case "12": return "3";
            default:return "0";
        }
    }
    public static string ageRange(string no)
    {
        switch (no)
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
    public static string ageGroup(int age)
    {
        switch (age)
        {
            case 7: case 8: return "1";
            case 9: case 10: return "2";
            case 11: case 12: return "3";
            default: return "0";
        }
    }
}
