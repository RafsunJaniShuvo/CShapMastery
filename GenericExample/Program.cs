

using GenericExample;

Point<int,double> p = new Point<int, double>(); // passing datatype 
p.X = 1;
p.Y = 2.5;
Point<int,int> p1 = new Point<int,int>();
p1.X = 6;
p1.Y = 8;

Point<double, int> p2 = new Point<double, int>();
p2.X = 1.5;
p2.Y = 9;


SuperPoint<int,string,double> superPoint = new SuperPoint<int,string,double>();
superPoint.X = 5;
superPoint.Y = "Rafsun";
superPoint.amount = 500.50;


Point<Person,double> point1 = new Point<Person,double>();

SecuritySystem<Person> securitySystem = new SecuritySystem<Person>();

securitySystem.open<string>("Rafsun"); // here security system is class , open is a method and string is the type of method . Rafsun is a parameter of method

