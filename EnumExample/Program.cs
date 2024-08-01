
using EnumExample;

string option = Console.ReadLine();
//Note:  We can convert this enum to integer value like (int)RegisterType.Name
//Console.WriteLine((int)RegisterType.Name);
if (option == RegisterType.Name.ToString())
{
    Console.WriteLine($"Please enter your name");
}else if (option == RegisterType.VoterID.ToString())
{
    Console.WriteLine($"Please enter voter id");
}else if(option == RegisterType.PassportNumber.ToString())
{
    Console.WriteLine($"Please enter passport number");
}
