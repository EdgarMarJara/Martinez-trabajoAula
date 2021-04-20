using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    // Constructor that takes no arguments:
    public Person()
    {
        Name = "Edgar";
    }

    // Constructor that takes one argument:
    public Person(string Edgar)
    {
        Name = Edgar;
    }

    // Auto-implemented readonly property:
    public string Name { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Name;
    }
}
class TestPerson
{
    static void Main()
    {
        // Call the constructor that has no parameters.
        var person1 = new Person();
        //var person2 = new Person();
        Console.WriteLine(person1.Name);
        //Console.WriteLine(person2.Name);
        // Call the constructor that has one parameter.
        var person2 = new Person("Alma Marcela");
        var person3 = new Person("Juliana Cepolla");
        var person4 = new Person("Edgar Martinez");
        Console.WriteLine(person3.Name);
        Console.WriteLine(person2.Name);
        Console.WriteLine(person4.Name);
        // Get the string representation of the person2 instance.
        Console.WriteLine("Aca lem llama sin unar la clase y directo desde el nombre de la variable");
        Console.WriteLine("/ n");
        Console.WriteLine(person2);
        Console.WriteLine(person3);
        Console.WriteLine(person4);
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

