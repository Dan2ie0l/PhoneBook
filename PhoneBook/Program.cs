using System.Security.Cryptography.X509Certificates;
using System;
using System.Globalization;
using System.Collections.Generic;

Console.Write("File Path:");
string file = Console.ReadLine().ToString();
//string file = @"C:\Users\danie\source\repos\PhoneBook\PhoneBook\PhoneBook\phonebook.txt";
string validationMessage = "";
string[] lines = File.ReadAllLines(file);

List<PhoneBook.PhoneBook> Phonebook = new();


foreach (string line in lines)
{
    PhoneBook.PhoneBook a = new PhoneBook.PhoneBook();
    string[] arr = line.Split(" ");

    if (arr.Length == 4)
    {
        a.Name = arr[0];
        a.Surname = arr[1];
        a.Separator = arr[2];
        a.PhoneNumber = arr[3];
    }
    else
    {
        a.Name = arr[0];
        a.Surname = " ";
        a.Separator = arr[1];
        a.PhoneNumber = arr[2];
    }
    Phonebook.Add(a);

}

Console.Write("Please choose an ordering to sort: “Ascending” or “Descending:");
string order = Console.ReadLine().ToString();

Console.Write("Please choose criteria: “Name”, “Surname” or “PhoneNumberCode:");
string criteria = Console.ReadLine().ToString();






var sort = from a in Phonebook
           orderby a.Name
           descending
           select a;

if (order == "Descending")
{
    if (criteria == "Name")
    {
        sort = from a in Phonebook
               orderby a.Name
               descending
               select a;

    }
    else if (criteria == "Surname")
    {
        sort = from a in Phonebook
               orderby a.Surname
               descending
               select a;

    }
    else if (criteria == "PhoneNumberCode")
    {
        sort = from a in Phonebook
               orderby a.PhoneNumber.Substring(0, 3)
               descending
               select a;

    }
}
else if (order == "Ascending")
{
    if (criteria == "Name")
    {
        sort = from a in Phonebook
               orderby a.Name
               ascending
               select a;

    }
    else if (criteria == "Surname")
    {
        sort = from a in Phonebook
               orderby a.Surname
               ascending
               select a;
    }
    else if (criteria == "PhoneNumberCode")
    {
        sort = from a in Phonebook
               orderby a.PhoneNumber.Substring(0, 3)
               ascending
               select a;

    }
}
/*if(criteria == "Surname")
{
    var newlist = sort.ToList();
    PhoneBook.PhoneBook.Move(newlist, 1, newlist.Count-1);

    foreach (var name in newlist)
    {
        Console.WriteLine(name);
    }
}
else
{

    foreach (var name in sort)
    {
        Console.WriteLine(name);
    }
}*/
foreach (var name in sort)
{
    Console.WriteLine(name);
}

int i = 1;
foreach (var item in sort)
{
    validationMessage += "Line " + i + ": " + item.Validation() + "\n";
    i++;
}
Console.WriteLine();
Console.WriteLine(validationMessage);

{

}

