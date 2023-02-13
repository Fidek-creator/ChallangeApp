List<string>  dayOfWeeks = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
dayOfWeeks.Add("dupa");
foreach (var day in dayOfWeeks)
{
    Console.WriteLine(day);
}