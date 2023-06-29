using System;

public class TimeFormatter
{
    public static string FormatTime(int seconds)
    {
        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int remainingSeconds = (seconds % 3600) % 60;

        string formattedTime = $"{hours:00}:{minutes:00}:{remainingSeconds:00}";
        return formattedTime;
    }

    public static void Main(string[] args)
    {
        int totalSeconds = 332;
        string formattedTime = FormatTime(totalSeconds);
        Console.WriteLine(formattedTime);
    }
}