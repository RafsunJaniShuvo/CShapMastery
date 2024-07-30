using StructureExample;

Student s = new Student();
s.Name = "Rafsun";

Student s2 = s;
s2.Name = "Shuvo";

Console.WriteLine(s.Name);
Console.WriteLine(s2.Name);

Teacher teacher = new Teacher();
teacher.Name = "Hasan";
Teacher teacher2 = teacher;
teacher2.Name = "Rafiq";
Console.WriteLine(teacher.Name);
Console.WriteLine(teacher2.Name);


