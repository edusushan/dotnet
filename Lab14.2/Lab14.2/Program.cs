using System;

public enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a day of the week:");
        string userInput = Console.ReadLine();

        DayOfWeek inputDay;
        if (Enum.TryParse(userInput, true, out inputDay))
        {
            switch (inputDay)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("It's a weekday.");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the weekend.");
                    break;
                default:
                    Console.WriteLine("Invalid day of the week.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid day of the week.");
        }
    }
}
