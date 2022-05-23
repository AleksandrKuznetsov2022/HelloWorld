using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _7_Structur
{
    internal class Program
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
                            rep.SaveChanges();
                            break;
                        }
                    case 3:
                        {
                            Found:
                            Console.WriteLine("Введите Id сотрудника для редоктирования");
                            var IdOld = Int32.Parse(Console.ReadLine());
                            var worker = rep.GetById(IdOld);

                            Console.WriteLine("Введите новое Id сотрудника");
                            var NewId = Console.ReadLine();
                            worker.Id = int.Parse(NewId);

                            Console.WriteLine("Введите новую дату и время записи сотрудника");
                            var NewDate = Console.ReadLine();
                            worker.Date = DateTime.Parse(NewDate);

                            Console.WriteLine("Введите новое Ф.И.О сотрудника");
                            var NewIni = Console.ReadLine();
                            worker.Ini = NewIni;

                            Console.WriteLine("Введите новый возраст сотрудника");
                            var NewAge = Console.ReadLine();
                            worker.Age = NewAge;

                            Console.WriteLine("Введите новый рост сотрудника");
                            var NewLenght = Console.ReadLine();
                            worker.Lenght = NewLenght;

                            Console.WriteLine("Введите новую дату рождения сотрудника");
                            var NewBirth = Console.ReadLine();
                            worker.Birth = NewBirth;

                            Console.WriteLine("Введите новое место рождения сотрудника");
                            var NewPlace = Console.ReadLine();
                            worker.Place = NewPlace;

                            rep.Remove(worker);
                            rep.Add(worker);
                            rep.SaveChanges();

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите начальную дату");
                            var WorkersDataStart = (Console.ReadLine());
                            Console.WriteLine("Введите конечную дату");
                            var WorkersDataEnd = (Console.ReadLine());
                            var workerss = rep.GetAll().Where(e => e.Date >= DateTime.Parse(WorkersDataStart)
                                                                 && e.Date <= DateTime.Parse(WorkersDataEnd));
                            foreach (var workers in workerss)
                            {
                                Console.WriteLine(workers.Id + " "+
                                             workers.Date + " " +
                                             workers.Ini + " " +
                                             workers.Age + " " +
                                             workers.Lenght + " " +
                                             workers.Birth + " " +
                                             workers.Place);
                            }

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
                         Found:
                            Console.WriteLine("Введите Id сотрудника для удаления");
                            var IdOld = Int32.Parse(Console.ReadLine());
                            var worker = rep.GetById(IdOld);
                            rep.Remove(worker);
                            rep.SaveChanges();
                            break;
                        }
                 Console.ReadKey();

                }
                    
             
            }

        }

        

    }
}
