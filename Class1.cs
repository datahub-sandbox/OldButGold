using System.Diagnostics.CodeAnalysis;

namespace OldButGold;

public static class DateTimeHumanized
{
    public static string Humanize(this DateTime date)
    {
        var timeSpan = DateTime.Now.Subtract(date);

        if (timeSpan.TotalSeconds < 60)
        {
            return "just now";
        }

        if (timeSpan.TotalMinutes < 60)
        {
            return $"{timeSpan.Minutes} minutes ago";
        }

        if (timeSpan.TotalHours < 24)
        {
            return $"{timeSpan.Hours} hours ago";
        }

        if (timeSpan.TotalDays < 30)
        {
            return $"{timeSpan.Days} days ago";
        }

        if (timeSpan.TotalDays < 365)
        {
            var months = Math.Round(timeSpan.TotalDays / 30);
            return $"{months} months ago";
        }

        var years = Math.Round(timeSpan.TotalDays / 365);
        return $"{years} years ago";
    }
}
