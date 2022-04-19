namespace _7_Structur
{
    struct Workers
    {
        // Поля

        // id сотрудника
        private int id;
        // дата внесения записи   
        private DateTime date;
        // ФИО сотрудника
        private string ini;
        // возраст
        private string age;
        // рост
        private string lenght;
        // дата рождения
        private string birth;
        // место рождения
        private string place;

        // Конструктор
        public Workers(int Id, DateTime Date, string Ini, string Age, string Lenght, string Birth, string Plase)
        {
            this.id = Id;
            this.date = Date;
            this.ini = Ini;
            this.age = Age;
            this.lenght = Lenght;
            this.birth = Birth;
            this.place = Plase;
        }

        //Cвойства
        public int Id { get { return this.id; } set { this.id = value; } }
        public DateTime Date { get { return this.date; } set { this.date = value; } }
        public string Ini { get { return this.ini; } set { this.ini = value; } }
        public string Age { get { return this.age; } set { this.age = value; } }
        public string Lenght { get { return this.lenght; } set { this.lenght = value; } }
        public string Birth { get { return this.birth; } set { this.birth = value; } }
        public string Place { get { return this.place; } set { this.place = value; } }

        //Методы
        public string Print()
        {
            return $"{this.id,3}{this.date,20}{this.ini,30}{this.age,8}{this.lenght,5}{this.birth,14}{this.place,20}";
        }
        public string ShowId()
        {
            return $"{this.id}";
        }
    }
}
