Console.WriteLine("Привет!");
Console.WriteLine("ФИО: Лойко Арина Станиславна");
Console.WriteLine("Группа: ИСП-232");
Console.WriteLine("Дата и время: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));

while (true)
{
    Console.WriteLine("\nМеню:");
    Console.WriteLine("1 — Показать ФИО");
    Console.WriteLine("2 — Показать группу");
    Console.WriteLine("3 — Показать дату");
    Console.WriteLine("4 — Выход");
    Console.Write("Ваш выбор: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Лойко Арина Станиславна");
            break;
        case "2":
            Console.WriteLine("ИСП-232");
            break;
        case "3":
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
            break;
        case "4":
            Console.WriteLine("Выход");
            return;
        default:
            Console.WriteLine("Неверный выбор");
            break;
    }
}
