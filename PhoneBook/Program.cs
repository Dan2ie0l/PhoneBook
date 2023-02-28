using System.Security.Cryptography.X509Certificates;
using System;

Console.Write("File Path:");
string file =  Console.ReadLine().ToString();
//string file = @"C:\Users\danie\source\repos\PhoneBook\PhoneBook\PhoneBook\phonebook.txt";

string[] lines = File.ReadAllLines(file);

List<PhoneBook.PhoneBook> Phonebook = new();
int i = 1;
foreach (string line in lines)
{
    PhoneBook.PhoneBook a = new PhoneBook.PhoneBook();
    string [] arr = line.Split(" ");
    if (arr.Length == 4)
    {
        a.Id = i;
        a.Name = arr[0];
        a.Surname = arr[1];
        a.Separator = arr[2];
        a.PhoneNumber = arr[3];
    }
    else
    {
        a.Id = i;
        a.Name = arr[0];
        a.Separator = arr[1];
        a.PhoneNumber = arr[2];
    }
    Phonebook.Add(a); 
    i++;

}

/*Console.Write("Please choose an ordering to sort: “Ascending” or “Descending:");
string order = Console.ReadLine().ToString();

Console.Write("Please choose criteria: “Name”, “Surname” or “PhoneNumberCode:");
string criteria = Console.ReadLine().ToString();
*/
foreach (var item in Phonebook)
{
    Console.WriteLine(item.ToString() );
    Console.WriteLine(item.Validation());
}
