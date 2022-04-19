using System.Text;
namespace _7_Structur
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Workers.txt";
            Repository rep = new Repository(path);
            // rep.Add(new Workers(10, DateTime.Now, "Иванов Иван Иваныч", "56", "180", "1980.2.1", "Красноярск"));
            // Метод ручного добавления
            //Console.WriteLine($"{"ID",3}{"Дата и Время",20}{"Ф.И.О.",30}{"Возраст",8}{"Рост",5}{"Дата Рождения",14}{"Место Рождения",20}");
            //rep.Add(new Workers(Convert.ToInt32(Console.ReadLine()), DateTime.Now, Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
            rep.IDWorkers(5);
            //rep.PrintReposit();
            //rep.SaveFile(path);
            
        }

        

    }
}
