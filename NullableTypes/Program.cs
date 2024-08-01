int? x = null; // int is value type , so we cant assign null here but what if we need to assign null then we can use ? 
string? y = null;
if (x.HasValue)
{
    Console.WriteLine(x.Value);
}
