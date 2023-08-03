using System;
using System.Xml.Linq;

//Having the class Dog with Age and Name properties, add the next changes:

//-throw ArgumentException for negative age

//-throw ApplicationException for age greater than 100

//- throw ApplicationException for name length lower than 2

//Then create a dog object in Main method using object initializer to set up the age and name. Watch for expected exceptions and send a friendly message to the user with the exception.

try
{
    Console.WriteLine("Insert dog's name:");
    string name = Console.ReadLine();

    Console.WriteLine("Insert dog's age:");
    int age = int.Parse(Console.ReadLine());

    Dog dog = new Dog(name, age);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ApplicationException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Thank you for playing !");
}





