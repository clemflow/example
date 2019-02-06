using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class CodeBank
{
	public CodeBank()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    /// <$ tag=['parenthesis', 'test', 'method'] language=c#
    public static IList<string> GenerateParenthesis(int n)
    {
        List<string> result = new List<string>();
        if (n <= 0) return result;
        GenerateParenthesis(n, n, "", result);
        return result;
    }

    private static void GenerateParenthesis(int left, int right, string item, List<string> result)
    {
        if (right < left) return;
        if (left == 0 && right == 0)
        {
            result.Add(item);
        }
        if (left > 0)
        {
            GenerateParenthesis(left - 1, right, item + "(", result);
        }
        if (right > 0)
        {
            GenerateParenthesis(left, right - 1, item + ")", result);
        }

    }
    // $>
}
