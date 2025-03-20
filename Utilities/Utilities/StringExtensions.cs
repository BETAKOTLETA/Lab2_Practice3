using System.Text.RegularExpressions;

namespace Utilities;

public static class StringExtensions
{
    public static string ToSnakeCase(this string input)
    {
        //return new string(input.Select(c => c == ' ' ? '_' : c).ToArray()).ToLower();

        string cleaned = Regex.Replace(input, @"[^\w\s]", "");

        return Regex.Replace(cleaned.Trim(), @"\s+", "_").ToLower();

    }
}