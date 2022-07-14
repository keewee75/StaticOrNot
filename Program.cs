//1. Skapa en klass som ska innehålla static av något slag
//2. Skapa en static property i den klassen
//3. Använd propertyn
//4. Skapa en metod med return
//5. Unit Testa metoden som skapdes i 4.

using StaticOrNot;

//Anropa metoden CurrentDate från klassen MyStatics och skriv ut.(Då CurrentDate är static så behöver vi inte skapa ett objekt av MyStatics)
Console.WriteLine($"\nCurrent Date & Time: {MyStatics.CurrentDate()}");


//Att använda en non-static metod kräver instansiering //Sätter Name och Age mha den andra konstruktorn i MyStatics
MyStatics instans1 = new MyStatics("Olle", 35);
MyStatics instans2 = new MyStatics("Bengt", 15);
MyStatics instans3 = new MyStatics("Kalle", 41);
MyStatics instans4 = new MyStatics("Karin", 47);
MyStatics instans5 = new MyStatics("Emma", 17);


//Skriv ut objektens innehåll (ToString overridas i MyStatics)
Console.WriteLine(instans1);
Console.WriteLine(instans2);
Console.WriteLine(instans3);
Console.WriteLine(instans4);
Console.WriteLine(instans5);

instans5.HappyBirthDay();
Console.WriteLine(instans5);