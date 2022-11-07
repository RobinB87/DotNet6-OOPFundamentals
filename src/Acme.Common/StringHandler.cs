namespace Acme.Common;
public class StringHandler
{
    public string InsertSpaces(string source)
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