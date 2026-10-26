FooBar foobar = new();
foobar.AddRule(5, "bar");
foobar.AddRule(9, "huzz");
foobar.AddRule(7, "jazz");
foobar.AddRule(3, "foo");
foobar.AddRule(4, "baz");

Console.WriteLine(foobar.Evaluate(3*4*5*7*9));
Console.WriteLine(foobar.GenerateSequence(1, 100));
