
using Tupple;

(int x, int y) point = (5, 1); // initialized a tupple carrying x = 5 , y = 1
Console.WriteLine(point.x);
Console.WriteLine(point.y);



Person[] person = new Person[3];
person[0] = new Person { Id = 1, Name = "Rafsun Jani shuvo" };
person[1] = new Person { Id = 2, Name = "Aman" };
person[2] = new Person { Id = 3, Name = "Rifat" };

Order[] orders = new Order[3];
orders[0] = new Order { PersonId = 1, Amount = 100, OrderDate = new DateTime(2024, 7, 31) };
orders[1] = new Order { PersonId = 2, Amount = 200, OrderDate = new DateTime(2024,6,25) };
orders[2] = new Order { PersonId = 3, Amount = 300, OrderDate = new DateTime(2024,5,25) };

var r = from p in person
join o in orders on p.Id equals o.PersonId
select (p.Name, o.Amount);

foreach(var item  in r)
    Console.WriteLine($"{item.Name},{item.Amount}");
