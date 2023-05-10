// oefening: Filteren en transformeren
/*
 * Gegeven een List van strings, schrijf een LINQ-query die alle strings 
 * filtert die langer zijn dan 4 tekens en deze vervolgens omzet 
 * naar hoofdletters.
 */

using Oefening;
{
    List<string> woorden = new List<string>() { "appel", "peer", "banaan", "druif", "kiwi", "mango" };

    List<string> result = woorden
        .Where(x => x.Length > 4).ToList()
        .Select(x => x.ToUpper()).ToList();

    Console.WriteLine("Oefening 1:");
    result.ForEach(x => Console.WriteLine(x));
    Console.WriteLine();
}


/*  Groeperen en tellen
    Gegeven een List van studenten, schrijf een LINQ-query die studenten 
    groepeert op basis van hun klas en het aantal studenten per klas weergeeft. 
    Elke student heeft een Naam en een Klas eigenschap.
*/

List<Student> studenten = new List<Student>
{
    new Student { Naam = "Alice", Klas = "A" },
    new Student { Naam = "Bob", Klas = "B" },
    new Student { Naam = "Charlie", Klas = "A" },
    new Student { Naam = "David", Klas = "C" },
    new Student { Naam = "Eva", Klas = "B" }
};

var groupedStudents = studenten.GroupBy(x => x.Klas).ToList();

Console.WriteLine("Oefening 2:");
groupedStudents.ForEach(x =>
{
    Console.WriteLine($"{x.Key}: {x.Count()}");
});
Console.WriteLine();

/*  Sorteren en samenvoegen
    Gegeven twee Lists van integers, schrijf een LINQ-query 
    die beide Lists samenvoegt, alle even getallen filtert 
    en het resultaat in oplopende volgorde sorteert.
*/

List<int> list1 = new List<int>() { 1, 3, 5, 7, 9 };
List<int> list2 = new List<int>() { 2, 4, 6, 8, 10 };

List<int> samengevoegdEnGesorteerd = list1.Concat(list2)
                                         .Where(i => i % 2 == 0)
                                         .OrderBy(i => i)
                                         .ToList();

Console.WriteLine("Oefening 3:");
foreach (int i in samengevoegdEnGesorteerd)
{
    Console.WriteLine(i);
}

