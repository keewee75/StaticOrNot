//1. Skapa en klass som ska innehålla static av något slag
//2. Skapa en static property i den klassen
//3. Använd propertyn

using StaticOrNot;

Random rnd = new Random();
for (int i = 0; i < 5; i++)
{
MyStatics.LuckyNumber = rnd.Next(1, 101);
Console.WriteLine(MyStatics.LuckyNumber);

}

//Att använda en non-static metod kräver instansiering
MyStatics instans = new MyStatics();
instans.Name = "Object 1";
int startValue = 0;
MyStatics.LuckyNumber = startValue;
for (int i = 0; i < 5; i++)
{
    instans.Incrementing();
    Console.Write(MyStatics.LuckyNumber + ", ");
}

MyStatics instans2 = new MyStatics();
instans2.Name = "Object 2";
Console.WriteLine(MyStatics.LuckyNumber);

//Skriv ut de 2 objektens innehåll
Console.WriteLine($"Id: {instans.Id}, Name: {instans.Name} , LuckyNumber value: {MyStatics.LuckyNumber}");
Console.WriteLine($"Id: {instans2.Id}, Name: {instans2.Name} , LuckyNumber value: {MyStatics.LuckyNumber}");
