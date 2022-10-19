string[] names = { "Grant", "Clay", "Emma", "Jack", "Jon" };
string[] hometown = { "Trenton", "Southgate", "Taylor", "Wyandotte", "Gibralter" };
string[] favFood = { "Pizza", "Steak", "Hamburger", "Lasagna", "Hot Dog" };
jump:
Console.WriteLine($"Enter a number between 1-{names.Length}: ");
string userIndexString = Console.ReadLine();

if (int.TryParse(userIndexString, out int userIndex))
{
    if (userIndex < 1 || userIndex > names.Length)
    {
        Console.WriteLine("Invalid Index");
        goto jump;
    }
}
else
{
    Console.WriteLine("Enter a number please.");
    goto jump;
}
int actualUserIndex = userIndex - 1;

Console.WriteLine(names[actualUserIndex]);

string userCategory = string.Empty;

do 
{
    Console.WriteLine("Would you like to see their Hometown" +
    " or Favorite Food?");
     userCategory = Console.ReadLine();
    if (userCategory != "Hometown" && userCategory != "Favorite Food")
    {
        Console.WriteLine("That is an invalid option.");
    }
}while (userCategory != "Hometown" && userCategory != "Favorite Food");

if (userCategory == "Hometown")
    {
        Console.WriteLine(hometown[actualUserIndex]);
    }
    else if (userCategory == "Favorite Food")
    {
        Console.WriteLine(favFood[actualUserIndex]);
    }

Console.WriteLine("Would you like to hear about another student?");
Console.WriteLine("Enter 'yes' or 'no': ");
var userRestart = Console.ReadLine();

if (userRestart == "yes")
{
    goto jump;
}