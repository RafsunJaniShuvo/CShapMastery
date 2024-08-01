DateTime datetime = new DateTime();
var CurrentTime = DateTime.Now;
var UtcTime = DateTime.UtcNow; // UtcNow means 6 hours less compare to our current time
Console.WriteLine($"{CurrentTime},{UtcTime}");
 