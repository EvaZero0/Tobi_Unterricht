/* Program-Einstiegspunkt C#
* namespace TD
{
 // Programmeinstiegspunkt (Wo das Programm anfängt auszuführen.)
 // => Program.Main
 internal class Program
 {
   static void Main(string[] args)
   {
     Console.WriteLine("Hello, World!");
     Console.ReadLine();
     // hier...
     var x = Start();
     Console.WriteLine(x);
   }
   static string Start()
   {
     Console.WriteLine("Buxtehude!");
     return "blubb";
   }
   // const login = function() {...}
   // login()
 }
}
*/

// Menü anzeigen mit Optionen
Console.WriteLine("Willkommen bei TD!");

string[] toDos = new string[10];  // es ist ein string-array mit bis zu 10 einträgen und startet bei 0

// Console.WriteLine(todos[9]);

do
{
    Console.Clear();
    Console.WriteLine("Was möchtest du tun?");
    Console.WriteLine("\t[1] Neues Todo erstellen\n\t[2] Todos anzeigen\n\t[3] Todo abhaken\n\t[4] Todo ändern");
    var mainChoice = Console.ReadLine();

    switch (mainChoice)  // zugriff auf input
    {
        case "1": //Erstellen
            Console.WriteLine("Neuer To-Do-Eintrag: ");
            var newToDo = Console.ReadLine();

            for (int i = 0; i < toDos.Length; i++)  // i wird deklariert und ist 0
                                                    // solange i kleiner ist, als die Anzahl der Strings im Array,
                                                    // füge +1 zu i hinzu
            {

                if (toDos[i] == null)   // Wenn der aktuelle Platz im Array nicht besetzt ist
                {
                    toDos[i] = newToDo; // Weiße diesem Platz die Usereingabe hinzu
                    Console.WriteLine("Todo hinzugefügt: " + toDos[i]);
                    break;
                }
            }
            break;

        case "2":  // ToDos auflisten
            Console.WriteLine("Du hast folgende Aufgaben:");
            for (int i = 0; i < toDos.Length; i++)
            {
                Console.WriteLine($"\t{i}. {toDos[i]}"); //Listet alle Positionen auf
            }
            Console.WriteLine("Drücke <ENTER> um zurück ins Menü zu kommen.");
            Console.ReadKey();
            break;

        case "3":
            // Eintrag Löschen
            Console.WriteLine("Welchen Eintrag möchtest du löschen?");
            for (int i = 0; i < toDos.Length; i++)
            {
                Console.WriteLine($"\t{i}. {toDos[i]}"); // Wieder alles aufgelistet...
            }
            var todoIndexnrString = Console.ReadLine(); // Der User gibt eine Nummer ein 0-9
            int todoIndexnr = int.Parse(todoIndexnrString); // Die Eingabe wird zu int konvertiert.


            // float todoIndex = float.Parse(todoIndexString);
            // int todoIndex1 = Convert.ToInt32(todoIndexString);
            toDos[todoIndexnr] = null;  //Jetzt kann der jeweilige String im Array auf null gesetzt werden
            break;

        case "4":
            // Updaten/Verändern eines Todos (verändern des strings)
            // 
            Console.WriteLine("Welchen Eintrag möchten Sie bearbeiten?");
            for (int i = 0; i < toDos.Length; i++)
            {
                Console.WriteLine($"\t{i}. {toDos[i]}"); // Wieder alles aufgelistet...

            }
            var todoIndexnrString2 = Console.ReadLine();
            int todoIndexnr2 = int.Parse(todoIndexnrString2);

            Console.WriteLine("Änderung eingeben:");
            toDos[todoIndexnr2] = Console.ReadLine();
            break;
    }
}
while (true);




