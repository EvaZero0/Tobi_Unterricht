//  PascalCase  -> HalloWeltNum
//  camelCase   -> halloWeltNum
//  snake_case  -> hallo_welt_num
//  kebab -case -> hallo - welt - num

//DateTime ist einer von vielen komplexen Datentypen in C#.
//DateTime ist ein Strukturtyp, der Datum und Uhrzeit darstellt.
//Komplexe Datentypen sind Objekte, die aus mehreren Werten bestehen, welche ebenfalls komplex oder auch primitiv sein können.
//Objekte können nur in der Konsole ausgegeben werden, wenn sie eine Methoe ToString() haben.

string name = " Eva";

DateTime date = DateTime.Now;
Console.WriteLine(date.Year);

Console.WriteLine(name);

bool is_true = false;
//Funktionen
//x = 5y

string? test_null = null;
Console.WriteLine("Buxtehude");

//var y = Console.ReadLine();

var trimmed_name = name.Trim();
Console.WriteLine(trimmed_name);

var test = 5.5;

//implicit conversion
Console.WriteLine((int)test + (int)test);

//explicit conversion
//int num int.Parse(test)

void PrintName()
{
    Console.WriteLine("Hallo Welt...");
}

// JavaScript
// function printName() {"Hallo Welt...");
//
// Python
// def printName():
// print ("Hallo Welt...")


PrintName();
PrintName();

string GetGreeting()
{
    return "Herzlich willkommen!";
}

var greeting = GetGreeting();

Console.WriteLine(greeting);

// Chararrays
var my_array = "Feierabend!";
var my_letter = my_array[0];

// Collections-Basics
// Array
string[] namen = new string[5];
string[] alternative_namen = ["Tobi", "Popstar", "Lehrer"]; //max 3 items
string[] alternative_namen1 = { "Ab", "Bc", "Cd" };
namen[0] = "Tobi";
namen[1] = "Melanie";
namen[2] = "Torben";
namen[99999999999999998] = "Buxtehude!";
Console.WriteLine(namen[0][0]);

// Array ist eine Liste an Werten
// Eine kontinuierliche Speicherregion, für mehrere Daten eines gewissen Typs
int[] nums = new int[5];
