
const string prompt = "Insert username: ";
const string masha = "Maria";

Console.Write(prompt);
string username = Console.ReadLine();

if(username == masha)
{
    Console.Write("Yike! It's Maria!");
}
else
{
    Console.Write("Hello, "+username);
}