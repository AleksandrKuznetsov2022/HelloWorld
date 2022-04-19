using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Structur
{
    struct Repository
    {
        //Поля
        private Workers[] workers;  // массив сотрудников
        private string path;        // переменная для доступа к файлу
        int index;                  // Индекс массива для добавления сотрудника

        //конструктор
        public Repository(string Path)
        {
            this.path = Path;
            this.index = 0;
            this.workers = new Workers[1];
            this.Load();
        }

        private void ResizeArr(bool flag)
        {
            if (flag)
            {
                Array.Resize(ref this.workers, this.workers.Length * 2);
            }
        }
        // Метод добавления 
        public void Add(Workers ConretWorker)
        {
            this.ResizeArr(index >= this.workers.Length);
            this.workers[index] = ConretWorker;
            index++;
        }
        //Метод загрузки из файла
        private void Load()
        {
            using (StreamReader sr = new StreamReader(this.path, Encoding.Unicode))
            {
                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split('#');
                    Add(new Workers(Convert.ToInt32(args[0]), Convert.ToDateTime(args[1]), args[2], args[3], args[4], args[5], args[6]));
                }
            }
        }
        //Метод печати хранилища
        public void PrintReposit()
        {
            Console.WriteLine($"{"ID",3}{"Дата и Время",20}{"Ф.И.О.",30}{"Возраст",8}{"Рост",5}{"Дата Рождения",14}{"Место Рождения",20}");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(this.workers[i].Print());
            }
        }
        //Метод вывода строки по ID
        public void IDWorkers(int ID)
        {
            for (int i = 0; i < index; i++)
            {
                int str;
                str = Convert.ToInt32(this.workers[i].ShowId());
                if (ID == str)
                {
                    Console.WriteLine(this.workers[i].Print());
                }
            }
        }
        //Сохранение репозитория в файл
        public void SaveFile(string Path)
        {
            using (StreamWriter sw = new StreamWriter(Path, false, Encoding.Unicode))
                for (int i = 0; i < this.index; i++)
                {
                    string temp = String.Format("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                                        this.workers[i].Id,
                                        this.workers[i].Date,
                                        this.workers[i].Ini,
                                        this.workers[i].Age,
                                        this.workers[i].Lenght,
                                        this.workers[i].Birth,
                                        this.workers[i].Place);
                    sw.WriteLine($"{temp}");
                }
        }
        //получить диапазон дат
        public void GetDate(DateTime startingDate, DateTime endingDate)
        {
            DateTime[] allDates = new DateTime[this.index];
                          
            for (DateTime date = startingDate; date <= endingDate; date = date.AddDays(1))
            {
                allDates.Add(date);// что сюда пихать?
            }
                
            


            
        }
    }
}
