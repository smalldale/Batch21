// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! New new");
int x;
// x = 1;
// float f = 1.5F;

// string @string = "String";

// string variable = "A Var";
// string @variable = "Another var";
// System.Console.WriteLine(@string);
// System.Console.WriteLine(variable, @variable);


// string @and = "test";
// System.Console.WriteLine(@and);


// int number = 2_147_483_647;
// float fnum = number;
// System.Console.WriteLine(fnum);
// number = number + 1;
// number = number - 2;
// System.Console.WriteLine(number);

System.Console.WriteLine(-3.0/0);

bool a = true;
bool b = false;
bool c = true;

static bool UseUmbrella(bool rainy, bool sunny, bool windy)
{
    return !windy && (rainy || sunny);
}

static bool UseUmbrella2(bool rainy, bool sunny, bool windy)
{
    return !windy & (rainy | sunny);
}

System.Console.WriteLine(UseUmbrella);