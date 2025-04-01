using System.Text.Json.Serialization;

namespace repetition_csharp;

class Program
{
    static async Task Main(string[] args)
    {
        await AsyncDemo.RunAsync();

        if (true) return;
        Console.WriteLine("Hello, World!");

        // Variabler
        double pi = 3.14;
        var name = "Ironman";

        // Datatyper
        /*
        bool
        byte
        char
        short
        long
        int
        double
        float
        string
        array[]
        object
        */

        // Operatörer (+, -, /, *, %, &&, >, >>)
        int a = 10;
        int b = 20;
        int sum = a + b;

        // Arrayer
        string[] languages = ["C#", "JavaScript", "Go"];
        languages[0] = "Java";
        Console.WriteLine(languages.Length);

        // List
        List<string> listLanguages = [];
        // List<string> listLanguages = new List<string>();
        // List<string> listLanguages = new();
        listLanguages.Add("C#");
        listLanguages.Remove("C#");
        Console.WriteLine(listLanguages[0]);

        // If
        if (languages.Length == 2 && sum <= 20)
        {
            Console.WriteLine("Do something");
        }

        // Loopar
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        foreach (var language in languages)
        {
            Console.WriteLine(language);
        }

        int index = 0;
        while (index < listLanguages.Count)
        {
            Console.WriteLine(listLanguages[index]);

            if (listLanguages[index] == "Java")
            {
                break;
            }
            else if (listLanguages[index] == "C#")
            {
                continue;
            }

            Console.WriteLine("HEJ!");
        }

        // Klasser & objekt
        Person ironman = new Person("Ironman", DateTime.Now);
        ironman.PrintInfo();

        Guid randomId = Person.RandomId();
    }
}

public class Person
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }

    public Person(string name, DateTime birthDate)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
        this.BirthDate = birthDate;
    }

    public void PrintInfo()
    {
        Console.WriteLine(this.Name + ":" + this.BirthDate);
    }

    public static Guid RandomId()
    {
        return Guid.NewGuid();
    }
}
