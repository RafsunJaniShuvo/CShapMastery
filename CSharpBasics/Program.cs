
var i = 0;
Console.WriteLine("Type of i is {0}", i.GetType());

string str = "Hello world";
Console.WriteLine("Type of str is {0}", str[0]);

var dbl = 50.0d;
Console.WriteLine("Type of dbl is {0}", dbl.GetType());


var isValid = true;
Console.WriteLine("Type of isValid is {0}", isValid.GetType());

var Name = new { name = "Rafsun" };
Console.WriteLine("Type of Name is {0}", Name.GetType());

var arr = new[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Type of arr is {0}", arr.GetType());

var file = new FileInfo("MyFile");
Console.WriteLine("Type of file is {0}", file.GetType());



Console.ReadLine();