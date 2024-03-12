// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using MyValidatorStart;

Console.WriteLine("Hello, World!");


ConcreteValidator CV = new ConcreteValidator("Oliver", "Hansen", "testvej");
CV.Start();








/*string pattern = @"hello1";
Regex rg = new Regex(pattern);
string somethingToValidate = "hello2";

bool istrue = Regex.IsMatch(somethingToValidate, pattern); // False
//Regex.IsMatch("MyValidator", pattern); // True
Console.Write(istrue);*/