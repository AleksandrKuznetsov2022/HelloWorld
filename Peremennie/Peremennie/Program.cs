    // Задание 1 (Немного покреативил, слегка отсутпил от ТЗ)
double ScoreProgramming = 4.4;
double ScoreMath = 4.9;
double ScorePhisic = 3.1;
Console.WriteLine("Здравствуйте, как Вас зовут? Укажите полные ФИО");
string FullName = Console.ReadLine();
Console.WriteLine("Приятно с вами  познакомиться, " + FullName);
Console.WriteLine("Сколько вам лет?");
byte age = byte.Parse(Console.ReadLine());
Console.WriteLine("Укажите пожалуйста вашу электронную почту для связи");
string email = Console.ReadLine();
Console.WriteLine("По предоставленным данным, нам удалось выяснить вашу успеваемость в школе:");
string information = "ФИО: {0} \nВозраст: {1} \nПочта: {2} \nБалл по Программированию: {3}" +
                     " \nБалл по Математике: {4} \nБалл по Физике: {5}";
Console.WriteLine(information,
                  FullName,
                  age,
                  email,
                  ScoreProgramming,
                  ScoreMath,
                  ScorePhisic);
Console.WriteLine("Нажмите любую клавишу для получения дополнительной информации");
Console.ReadKey();
double SummScore = (double) ScoreProgramming + ScoreMath + ScorePhisic;
Console.WriteLine($"Сумма ваших баллов по предметам: {SummScore} \nНажмите любую клавишу для продолжения");
Console.ReadKey();
byte CountScore = 3;
double AverageScore = (double) SummScore / CountScore;
Console.WriteLine($"Ваш средний балл по предметам: {AverageScore} \nСпасибо за использование нашей программы");
Console.ReadKey();
