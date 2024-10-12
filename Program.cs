namespace PracticalWorkCollections1OAiP;

public class Program
{
    public static void Main(string[] args)
    {
        // ЗАДАНИЕ ДЛЯ List
        Console.WriteLine("Задание 1 (Задание для List)\n");

        List<int> numbersList = [];

        numbersList.Add(10);
        numbersList.Add(0);
        numbersList.Add(-125);
        numbersList.Add(666);

        numbersList.Sort();

        foreach (var number in numbersList)
        {
            if (number < 50)
                Console.WriteLine(number);
        }


        // ЗАДАНИЕ ДЛЯ Dictionary
        Console.WriteLine("\n\nЗадание 2 (Задание для Dictionary)\n");

        Dictionary<string, int> employeeNameAge = [];

        string employeeName = "Александра";

        employeeNameAge["Олег"] = 12;
        employeeNameAge["Александра"] = 22;
        employeeNameAge["Никита"] = 31;
        employeeNameAge["Алексей"] = 18;

        if (employeeNameAge.ContainsKey(employeeName))
            Console.WriteLine($"Возраст работника с именем \"{employeeName}\" равен {employeeNameAge[employeeName]}.");
        else
            Console.WriteLine($"Сотрудник с именем {employeeName} не найден.");
    }
}