using Case2Aflevering.GlobalClasses; // Namespace som kan ses globalt
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()

    .BuildServiceProvider();

Console.WriteLine();
Console.WriteLine("Tast 0 for lærer eller 1 for elev.");


// ENUM

Console.WriteLine($"(Vælg {Choices.Lærer} eller {Choices.Elev}):");
string userInput = Console.ReadLine();

Choices choices;
if (Enum.TryParse(userInput, true, out choices))
{

    switch (choices)
    {
        case Choices.Lærer:

            Console.Clear();
            Console.WriteLine($"Du har valgt {Choices.Lærer}!");
            Console.WriteLine();

            Teacher teacher = new Teacher("Niels Olesen", "Studieteknik");
            teacher.Hello(); // udskriver "Hej, jeg underviser i Studieteknik og mit navn er Niels Olesen"
            Console.WriteLine();
            Teacher teacher1 = new Teacher("Niels Olesen", "Grundlæggende programmering");
            teacher1.Hello(); // udskriver "Hej, jeg underviser i Grundlæggende programmering og mit navn er Niels Olesen"
            Console.WriteLine();
            Teacher teacher2 = new Teacher("Niels Olesen", "Database programmering");
            teacher2.Hello(); // udskriver "Hej, jeg underviser i Database programmering og mit navn er Niels Olesen"
            Console.WriteLine();
            Teacher teacher3 = new Teacher("Niels Olesen", "Computerteknologi");
            teacher3.Hello(); // udskriver "Hej, jeg underviser i Computerteknologi og mit navn er Niels Olesen"
            Console.WriteLine();
            Teacher teacher4 = new Teacher("Flemming Sørensen", "OOP");
            teacher4.Hello(); // udskriver "Hej, jeg underviser i OOP og mit navn er Flemming Sørensen"
            Console.WriteLine();
            Teacher teacher5 = new Teacher("Henrik Vincent Poulsen", "Netværk");
            teacher5.Hello(); // udskriver "Hej, jeg underviser i Netværk og mit navn er Henrik Vincent Poulsen"
            Console.WriteLine();
            Teacher teacher6 = new Teacher("Peter Suni Lindenskov", "Clientsideprogrammering"); 
            teacher6.Hello(); // udskriver "Hej, jeg underviser i Clientsideprogrammering og mit navn er Peter Suni Lindenskov"
            break;

        case Choices.Elev:

            Console.Clear();
            Console.WriteLine($"Du har valgt {Choices.Elev}!");
            Console.WriteLine();

            Student student = new Student("Alexander Mathias Thamdru");
            student.Hello(); // udskriver "Hej, jeg er elev og mit navn er Alexander Mathias Thamdru"
            Console.WriteLine();
            Student student1 = new Student("Allan Gawron");
            student1.Hello(); // udskriver "Hej, jeg er elev og mit navn er Allan Gawron"
            Console.WriteLine();
            Student student2 = new Student("Andreas Carl Balle");
            student2.Hello(); // udskriver "Hej, jeg er elev og mit navn er Andreas Carl Balle"
            Console.WriteLine();
            Student student3 = new Student("Darab Haqnazar");
            student3.Hello(); // udskriver "Hej, jeg er elev og mit navn er Darab Haqnazar"
            Console.WriteLine();
            Student student4 = new Student("Felix Enok Berger");
            student4.Hello(); // udskriver "Hej, jeg er elev og mit navn er Felix Enok Berger"
            Console.WriteLine();
            Student student5 = new Student("Jamie D.");
            student5.Hello(); // udskriver "Hej, jeg er elev og mit navn er Jamie D."
            Console.WriteLine();
            Student student6 = new Student("Jeppe Carlseng Pedersen");
            student6.Hello(); // udskriver "Hej, jeg er elev og mit navn er Jeppe Carlseng Pedersen"
            Console.WriteLine();
            Student student7 = new Student("Joseph Holland-Hale");
            student7.Hello(); // udskriver "Hej, jeg er elev og mit navn er Joseph Holland-Hale"
            Console.WriteLine();
            Student student8 = new Student("Kamil Marcin Kulpa");
            student8.Hello(); // udskriver "Hej, jeg er elev og mit navn er Kamil Marcin Kulpa"
            Console.WriteLine();
            Student student9 = new Student("Loke Emil Bendtsen");
            student9.Hello(); // udskriver "Hej, jeg er elev og mit navn er Loke Emil Bendtsen"
            Console.WriteLine();
            Student student10 = new Student("Mark Hyrsting Larsen");
            student10.Hello(); // udskriver "Hej, jeg er elev og mit navn er Mark Hyrsting Larsen"
            Console.WriteLine();
            Student student11 = new Student("Niklas Kim Jensen");
            student11.Hello(); // udskriver "Hej, jeg er elev og mit navn er Niklas Kim Jensen"
            Console.WriteLine();
            Student student12 = new Student("Rasmus Peter Hjorth");
            student12.Hello(); // udskriver "Hej, jeg er elev og mit navn er Rasmus Peter Hjorth"
            Console.WriteLine();
            Student student13 = new Student("Sammy Damiri");
            student13.Hello(); // udskriver "Hej, jeg er elev og mit navn er Niklas Sammy Damiri"
            Console.WriteLine();
            Student student14 = new Student("Thomas Mose Holmberg");
            student14.Hello(); // udskriver "Hej, jeg er elev og mit navn er Thomas Mose Holmberg"
            Console.WriteLine();
            Student student15 = new Student("Tobias Casanas Besser");
            student15.Hello(); // udskriver "Hej, jeg er elev og mit navn er Tobias Casanas Besser"
            break;

        default:
            Console.Clear();
            Console.WriteLine($"Du skal vælge {Choices.Lærer} eller {Choices.Elev}!");
            break;
    }
}


