//1. Skapa en klass som ska innehålla static av något slag
//2. Skapa en static property i den klassen
//3. Använd propertyn

using StaticOrNot;


//Att använda en non-static metod kräver instansiering
MyStatics instans = new MyStatics { Name = "Object 1" };
MyStatics instans2 = new MyStatics { Name = "Object 2" };
MyStatics instans3 = new MyStatics { Name = "Object 3" };
MyStatics instans4 = new MyStatics("ObjectWithConstructor");


//Skriv ut objektens innehåll
Console.WriteLine($"Id: {instans.Id}, Name: {instans.Name}");
Console.WriteLine($"Id: {instans2.Id}, Name: {instans2.Name}");
Console.WriteLine($"Id: {instans3.Id}, Name: {instans3.Name}");
Console.WriteLine($"Id: {instans4.Id}, Name: {instans4.Name}");

Console.WriteLine($"\nCurrent Date & Time: {MyStatics.CurrentDate()}");
