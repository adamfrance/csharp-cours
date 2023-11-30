using System.Xml // pour utiliser des docs xml

var population = 67_000_000; // 67 million in UK.
var weight = 1.88; // in kilograms.
var price = 4.99M; // in pounds sterling.
var fruit = "Apples"; // string values use double-quotes.
var letter = 'Z'; // char values use single-quotes.
var happy = true;

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");
XmlDocument xml3 = new(); // à partir de C# 9

Person kim = new();
kim.BirthDate = new(1967, 12, 26);

class Person
{
    public DateTime BirthDate;
    public String FirstName;
}

List<Person> people = new()
{
    new() { FirstName = "Ahmed"},
    new() { FirstName = "Joe"},
    new() { FirstName = "Max"}
};


