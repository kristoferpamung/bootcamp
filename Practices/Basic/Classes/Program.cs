using Classes;

/* ----------- Constructor -----------*/
Person p1 = new(name: "Rizad Immalano");
Person p2 = new(name: "Cookie Red", age: 26);
p2.HairColor = "Red";

Console.WriteLine("====== Constructor ======");
Console.WriteLine(Person.Welcome);
Console.WriteLine($"Nama: {p1.Name}, Age: {p1.age} tahun, Hair Color: {p1.HairColor}");
Console.WriteLine($"Nama: {p2.Name}, Age: {p2.age} tahun, Hair Color: {p2.HairColor}");
Console.WriteLine("====== End Constructor ======\n");
/* ----------- End Constructor -----------*/

/* ----------- Indexer -----------*/
Person p3 = new(name: "Sylvia Agnes", age: 27, ["Sepak Bola", "Menggambar", "Menyanyi"]);
Console.WriteLine("====== Indexer ======");
Console.WriteLine($"{p3[1]} adalah hobby dari {p3.Name} index ke 1");
void PrintHobbies(string[] hobbies)
{
	foreach (string hobby in hobbies)
	{
		Console.Write(hobby + ", ");
	}
}
PrintHobbies(p3[..2]);
Console.Write($"adalah semua hobby {p3.Name}\n");
Console.WriteLine("====== End Indexer ======\n");

/* ----------- Primary Constructor ----------- */
Console.WriteLine("====== Primary Constructor ======");
Animal doggy = new(name: "Doggy", age: 4);
Console.WriteLine(Animal.Welcome);
doggy.Print();
Console.WriteLine("====== End Primary Constructor ======\n");

/* ----------- End Primary Constructor ----------- */