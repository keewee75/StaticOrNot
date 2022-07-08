//1. Skapa en klass som ska innehålla static av något slag
//2. Skapa en static property i den klassen
//3. Använd propertyn

using StaticOrNot;


//Att använda en non-static metod kräver instansiering
MyStatics instans = new MyStatics { Name = "Object 1", Age = 40 };
MyStatics instans2 = new MyStatics { Name = "Object 2" };
MyStatics instans3 = new MyStatics { Name = "Object 3" };
MyStatics instans4 = new MyStatics("ObjectWithConstructor", 47);


//Skriv ut objektens innehåll
Console.WriteLine($"Id: {instans.Id} Name: {instans.Name}, Age: { instans.Age}");
Console.WriteLine($"Id: {instans2.Id} Name: {instans2.Name}, Age: {instans2.Age}");
Console.WriteLine($"Id: {instans3.Id} Name: {instans3.Name}, Age: {instans3.Age}");
Console.WriteLine($"Id: {instans4.Id} Name: {instans4.Name}, Age: {instans4.Age}");

Console.WriteLine(instans);
Console.WriteLine(instans2);
Console.WriteLine(instans3);
Console.WriteLine(instans4);

Console.WriteLine($"\nCurrent Date & Time: {MyStatics.CurrentDate()}");

