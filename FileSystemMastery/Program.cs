using System.Text;

//string Path = "E:\\Development\\C#Practice\\C#Mastery\\Test.txt";
//var content = "How are you ?";
//File.WriteAllText(Path,content);    
//File.AppendAllText(Path,content);  //ager line er sathe add kore    

//using FileStream stream = File.Create(Path);
//byte[] data = Encoding.UTF8.GetBytes(content);   
//foreach(byte b in data)
//{
//    stream.WriteByte(b); //writing into text.txt using byte
//}
//stream.Flush();

//string[] Lines = File.ReadAllLines(Path); // returning an array with 3 index
//[1] How ara you ?
//[2]Myself Rafsun 
//[3] Software Development
//if (File.Exists(Path))
//{                            

//    string line = File.ReadAllText(Path);      
//    // returning a single text --How are you ? // Myself Rafsun  // Software Development
//    Console.WriteLine();
//}

//FileInfo fileInfo = new FileInfo(Path);
//if (!fileInfo.Exists)
//{
//    fileInfo.Create();
//}

string Path1 = Directory.GetCurrentDirectory();
DirectoryInfo folder = Directory.GetParent(Path1);
string ProjectLocation = folder.Parent.Parent.FullName;
string FullPath = Path.Combine(ProjectLocation, "Demo.txt");
//if (Directory.Exists(FullPath))
//{
//    Directory.Delete(FullPath, true);
//    //Directory.CreateDirectory(FullPath);
//}

DirectoryInfo directory = new DirectoryInfo(ProjectLocation);
FileInfo[] Files = directory.GetFiles();
foreach(FileInfo file in Files)
{
    Console.WriteLine(file.Name);
}
Console.ReadLine();