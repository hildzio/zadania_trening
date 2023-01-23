using Zadania_trening;

Count number = new();

number.WriteNumber();
number.ReadNumber();
number.Add(5);
Console.WriteLine($"Dodano 5 i jest {number.Value} ");
number.Add(14);
Console.WriteLine($"Dodano 14 i jest {number.Value} ");
number.Subtract(15);
Console.WriteLine($"Odjęto 15 i jest {number.Value} ");
number.Add(16);
Console.WriteLine($"Dodano 16 i jest {number.Value} ");
number.Subtract(17);
Console.WriteLine($"Odjęto 17 i jest {number.Value} ");
number.Add(18);
Console.WriteLine($"Dodano 18 i jest {number.Value} ");

Sumator sumator= new();
sumator.HowManyElementsInNumbers();
sumator.PrintAllElementsFromNumbers();


