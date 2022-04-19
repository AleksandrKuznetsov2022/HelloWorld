using System.Text;
static void WriteFile(char symbol)
{
    using (StreamWriter sw = new StreamWriter("Workers.txt", true, Encoding.Unicode))
    {
        char key = 'д';
        do
        {
            string id = string.Empty;
            Console.WriteLine("\nВведите ID сотрудника");
            id += $"{Console.ReadLine()}#";

            string date = DateTime.Now.ToString();
            Console.WriteLine($"Дата и время добавления записи: {date}");
            id += $"{date}#";

            Console.WriteLine("ФИО сотрудника");
            string ini = Console.ReadLine();
            id += $"{ini}#";

            Console.WriteLine("Введите возраст");
            string age = Console.ReadLine();
            id += $"{age}#";

            Console.WriteLine("Введите рост");
            string lenght = Console.ReadLine();
            id += $"{lenght}#";

            Console.WriteLine("Введите дату рождения");
            string birth = Console.ReadLine();
            id += $"{birth}#";


            Console.WriteLine("Введите место рождения");
            string place = Console.ReadLine();
            id += place;
            sw.WriteLine(id);

            Console.WriteLine("Добавить еще сотрудника? Нажмите 'д' для продолжения или 'н' для выхода");
            key = Console.ReadKey(true).KeyChar;
        } while (char.ToLower(key) == 'д');
    }
}
static void ReadFile(char symbol)
{
    using (StreamReader sr = new StreamReader("Workers.txt", Encoding.Unicode))
    {
        string line;
        Console.WriteLine($"{"ID",3}{"Дата и Время",20}{"Ф.И.О.",30}{"Возраст",8}{"Рост",5}{"Дата Рождения",14}{"Место Рождения",20}");
        while ((line = sr.ReadLine()) != null)
        {
            string[] data = line.Split('#');
            Console.WriteLine($"{data[0],3}{data[1],20}{data[2],30}{data[3],8}{data[4],5}{data[5],14}{data[6],20}");
        }
    }
}
Console.WriteLine("Здравствуйте!");
while (true)
{
    Console.WriteLine("Введите 1 для просмотра списка сотрудников.\nВведите 2 для добавления сотрудника");
    char symbol = Console.ReadKey(true).KeyChar;
    if (symbol == '1')
    {
        ReadFile(symbol);
    }
    else if (symbol == '2')
    {
        Console.WriteLine("Создаем файл");
        WriteFile(symbol);
    }
    else
    {
        Console.WriteLine("Введите 1 или 2");
    }
    Console.ReadKey();
}