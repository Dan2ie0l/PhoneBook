Console.Write("File Path:");
string file =  Console.ReadLine().ToString();
//string file = @"C:\Users\danie\source\repos\PhoneBook\PhoneBook\PhoneBook\phonebook.txt";

string[] lines = File.ReadAllLines(file);

List<string> names = new List<string>();
List<string> surnames = new List<string>();
List<string> numbers = new List<string>();
List<string> phonebook = new List<string>();

foreach (string line in lines)
{
    phonebook.Add(line);
    Console.WriteLine(line);
    string [] arr = line.Split(" ");
    names.Add(arr[0]);
    surnames.Add(arr[1]);
    numbers.Add(arr[2]);
    Console.WriteLine();
}

