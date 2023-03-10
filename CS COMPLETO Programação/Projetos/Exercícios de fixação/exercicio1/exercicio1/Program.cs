// This is a exercise Number 1, from the udemy C#'s course

using System.Globalization;

string product1 = "PC";
string product2 = "Office desk";

byte age = 30;
int cod = 5290;
char gender = 'M';

double price1 = 2100.0;
double price2 = 650.50;
double measure = 53.234567;

Console.WriteLine("Products:");
Console.WriteLine("{0}, witch price is $ {1}", product1, price1);
Console.WriteLine($"{product2}, witch price is $ {price2.ToString("F2")}");
Console.WriteLine("\nRegister: {0} years old, code {1} and gender: {2}", age, cod, gender);
Console.WriteLine("\nMeasure with eight decimal places: {0}", measure.ToString("F8"));
Console.WriteLine("Rouded (three decimal places): {0}", measure.ToString("F3"));
Console.WriteLine("Separate decimal point: {0}", measure.ToString("F3",CultureInfo.InvariantCulture));
