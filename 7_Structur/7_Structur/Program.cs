using System.Text;
namespace _7_Structur
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Workers.txt";
            var rep = new Repository(path);
            Console.WriteLine("Какую команду Вы хотите выполнить?:");
            Console.WriteLine("Показать список сотрудников на экране. Нажмите 1:");
            Console.WriteLine("Добавить нового сотрудника. Нажмите 2:");
            Console.WriteLine("Редактировать записи. Нажмите 3:");
            Console.WriteLine("Показать записи в выбранном диапазоне дат. Нажмите 4:");
            Console.WriteLine("Сортировать по убыванию даты записи. Нажмите 5:");
            Console.WriteLine("Сортировать по возрастанию даты записи. Нажмите 6:");
            Console.WriteLine("Выбрать и удалить запись о работнике. Нажмите 7:");
            while (true)
            {
                int userinput = int.Parse(Console.ReadLine());
                int programm = userinput;
                switch (programm)
                {
                    case 1:
                        {
                            rep.PrintReposit();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите данные сотрудника через запятую:\nID,Дату заполнения, ФИО, Возраст, Рост, Дата рождения, Место рождения ");
                            var userFullName = Console.ReadLine();
                            rep.Add(new Workers(Convert.ToInt32(userFullName.Split(',')[0]), Convert.ToDateTime(userFullName.Split(',')[1]), userFullName.Split(',')[2], userFullName.Split(',')[3], userFullName.Split(',')[4], userFullName.Split(',')[5], userFullName.Split(',')[6]));
                            rep.SaveFile(path);
                            break;
                        }
                    case 3:
                        {

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите начальную дату");
                            var WorkersDataStart = (Console.ReadLine());
                            Console.WriteLine("Введите конечную дату");
                            var WorkersDataEnd = (Console.ReadLine());
                            break;
                        }
                    case 5:
                        {
                            rep.SortRepositDescending();
                            break;
                        }
                    case 6:
                        {
                            rep.SortReposit();
                            break;
                        }
                    case 7:
                        {

                            break;
                        }
                 Console.ReadKey();

                }
                    
                
                //rep.IDWorkers(5);
               
                
               


                //rep.GetDate(date1, date2);
            }

        }

        

    }
}
