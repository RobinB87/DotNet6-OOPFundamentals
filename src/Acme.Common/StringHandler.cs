namespace Acme.Common;
public static class StringHandler
{
    /// <summary>
    /// Inserts spaces before each capital letter in a string
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public static string InsertSpaces(this string source)
    {
        if (string.IsNullOrEmpty(source)) return string.Empty;

        var result = string.Empty;
        foreach (var letter in source)
        {
            if (char.IsUpper(letter))
            {
                // Trim any spaces already there
                result = result.Trim();
                result += " ";
            }

            result += letter;
        }

        return result.Trim();
    }
}