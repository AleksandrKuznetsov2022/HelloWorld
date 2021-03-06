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
        public Workers[] workers;  // массив сотрудников
        private string path;        // переменная для доступа к файлу
        int index;                  // Индекс структуры для добавления сотрудника
        
        //конструктор
        public Repository(string Path)
        {
            this.path = Path;
            this.index = 0;
            this.workers = new Workers[1];
            Load();
        }
        // Список сотрудника (частный вспомогательный список)

        // Получаем список всех сотрудников
        public Workers[] GetAll()
        {
            return workers;
        }
        //Увеличение массива сотрудников
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
        public void SortReposit()
        {
            this.workers = this.workers.OrderBy(x => x.Date).ToArray();
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].Id != 0)
                {
                    Console.WriteLine(this.workers[i].Print());
                }
            }
        }
        public void SortRepositDescending()
        {
            this.workers = this.workers.OrderByDescending(x => x.Date).ToArray();
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].Id != 0)
                {
                    Console.WriteLine(this.workers[i].Print());
                }
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
        // Удаляем сотрудника
        public void Remove(Workers worker)
        {
            workers = workers.Where(e => e.Id != worker.Id).ToArray();            
        }     
        //Сохранение репозитория в файл
        
        public void SaveChanges()
        {
            using (StreamWriter sw = new StreamWriter("Workers.txt", false, Encoding.Unicode))
            {
                foreach (var workers in workers)
                {
                    if (workers.Id != 0)
                           sw.WriteLine(workers.Id + "#" +
                                        workers.Date + "#" +
                                        workers.Ini + "#" +
                                        workers.Age + "#" +
                                        workers.Lenght + "#" +
                                        workers.Birth + "#" +
                                        workers.Place);
                }
            }
        }
        public Workers GetById(int id)
        {
            return workers.FirstOrDefault(e => e.Id == id);
        }

       
    }
}