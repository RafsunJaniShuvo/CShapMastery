using OOP;
using Opp.FirstDemo; // calling namespace 

//Student student1 = new Student();
//student1.name = "Rafsun";
//student1.SetRoll(1);
//student1.AccNum = null; 
//Student student2 = new Student("Foyzur",2);


Teacher teacher = new Teacher();
teacher.Name = "Rafsun Jani shuvo";
teacher.Height = 5.11;
teacher.Weight = 80;
teacher.setAddress("Takhalpur/Sreepur/Magura");
Console.WriteLine(teacher.Name,
                  teacher.Height,
                  teacher.Weight);
Console.ReadLine();