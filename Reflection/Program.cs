//using System.Reflection;
//// These two are important for reflection
//Assembly assembly = Assembly.GetExecutingAssembly(); //multiple types makes an assembly
////Type t; // any datatype 

//foreach(var t in assembly.GetTypes())
//{
//    //Console.WriteLine(t.FullName);
//    var methods = t.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
//    foreach(var m in methods)
//    {
//        Console.WriteLine(m.Name);
//    }
//}


using Reflection;


Course course = new Course("C#", 2000 , new List<Topic>
{
    new Topic{ Title = "Tools Installation" , Duration = 2.0 }
});