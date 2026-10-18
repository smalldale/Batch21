using System.Text;


static void Generate(int count)
    {
        List<(int Divisor, string Word)> modRules = [
            (3, "foo"),
            (4, "baz"),
            (5, "bar"),
            (7, "jazz"),
            (9, "huzz"),
        ];
        for (int i = 1; i <= count; i++)
        {
            StringBuilder text = new StringBuilder();
            foreach ((int Divisor, string Word) rule in modRules)
            {
                if (i % rule.Divisor == 0)
                {
                    text.Append(rule.Word);
                }
            }
            if (text.ToString() == "")
            {
                text.Append($"{i}");
            }
            Console.Write(text.ToString());
            if (i < count)
            {
                Console.Write(", ");
            }
        }
    } 

Generate(105);