using JennySales.Helpers;

System.Console.WriteLine("Enter the year:");
int year = int.Parse(System.Console.ReadLine());
decimal standardDeviation = SalesStatistics.YearStandardDeviation(year);
System.Console.WriteLine($"The standard deviation for the year {year} is: {standardDeviation:F2}");
System.Console.WriteLine("\nPress Enter to close the application.");
System.Console.ReadLine();