using System.Text;

public class FooBar
{
    private List<(int Divisor, string Word)> modRules = [];
    
    public void AddRule(int divisor, string output)
    {
        modRules.Add((divisor, output));
        modRules.Sort((a, b) => a.Divisor.CompareTo(b.Divisor));
    }

    public string Evaluate(int number)
    {
        StringBuilder text = new StringBuilder();
        foreach ((int Divisor, string Word) rule in modRules)
        {
            if (number % rule.Divisor == 0)
            {
                text.Append(rule.Word);
            }
        }
        if (text.ToString() == "")
        {
            text.Append($"{number}");
        }
        return text.ToString();

    }

    public string GenerateSequence(int start, int end)
    {
        StringBuilder text = new StringBuilder();
        for (int i = start; i <= end; i++)
        {
            text.Append(Evaluate(i));
            if (i < end)
            {
                text.Append(", ");
            }
        }
        return text.ToString();
    }
}