



bool isValidAge = false;
int age;
do
{
	Console.Write("What is your age: ");
	string ageText = Console.ReadLine();
	isValidAge = int.TryParse(ageText, out  age);
	if (!isValidAge )
	{
        Console.WriteLine("That was an invalid age.");
    }
} while (!isValidAge);

Console.WriteLine($"Your age is {age}.");

string name = "";
do
{
	Console.WriteLine("Type exit to end.");
	Console.Write("What is your name: ");
	name = Console.ReadLine();
	if ( name.ToLower() == "héctor")
	{
        Console.WriteLine("Hello professor Héctor.");
    }else if (name.ToLower() != "exit") {
		Console.WriteLine("Hello student.");
	}
} while (name.ToLower() != "exit");



//while (true)
//{

//};