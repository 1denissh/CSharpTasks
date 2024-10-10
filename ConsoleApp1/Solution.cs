namespace ConsoleApp1;

public class Solution
{
    private readonly Dictionary<char, char> _chars = new()
    {
        { '(', ')' },
        { '[', ']' },
        { '{', '}' }
    };

    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (char c in s)
        {
            if (_chars.ContainsKey(c))
            {
                stack.Push(c);
            }
            else if (!stack.TryPop(out char pop) || _chars[pop] != c)
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}