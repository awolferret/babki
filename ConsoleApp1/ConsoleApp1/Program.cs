using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько перед вами людей?");
            int people = Convert.ToInt32(Console.ReadLine());
            int timeForPeople = 10;
            int waitTime = people * timeForPeople;
            int minutesInHour = 60;
            int waitHours = waitTime / minutesInHour;
            int waitMinutes = waitTime % minutesInHour;
            Console.WriteLine($"вам осталось ждать {waitHours} часов и {waitMinutes} минут");
        }
    }
}
