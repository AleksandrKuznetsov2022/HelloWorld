int Summ = 0;
Console.WriteLine("Приветсвуем вас в карточном калькуляторе! \nВведите количество карт, которое у вас на руках");
byte CountCard = byte.Parse(Console.ReadLine());
Console.WriteLine("В нашем калькуляторе мы будем использовать условные обозначения карт: цифры с 2 по 10" +
    "\nJ - валет, D - дама, K - король, T - туз");
for (int i = 1; i <= CountCard; i++)
{
    Console.WriteLine($"Введите номинал {i} - й карты");
    string CardValue = Console.ReadLine();
    int Value;
   switch (CardValue)
    {
        case "2":
            Value = 2;
            Summ = Summ + Value;
            break;
        case "3":
            Value = 3;
            Summ = Summ + Value;
            break;
        case "4":
            Value = 4;
            Summ = Summ + Value;
            break;
        case "5":
            Value = 5;
            Summ = Summ + Value;
            break;
        case "6":
            Value = 6;
            Summ = Summ + Value;
            break;
        case "7":
            Value = 7;
            Summ = Summ + Value;
            break;
        case "8":
            Value = 8;
            Summ = Summ + Value;
            break;
        case "9":
            Value = 9;
            Summ = Summ + Value;
            break;
        case "10":
            Value = 10;
            Summ = Summ + Value;
            break;
        case "J":
            Value = 10;
            Summ = Summ + Value;
            break;
        case "D":
            Value = 10;
            Summ = Summ + Value;
            break;
        case "K":
            Value = 10;
            Summ = Summ + Value;
            break;
        case "T":
            Value = 10;
            Summ = Summ + Value;
            break;
        default:
            i--;
            Console.WriteLine("Введенное значение не корректное, таких карт не существует");
            break;
   }
      
    
    
}
Console.WriteLine($"У вас на руках {CountCard} \nСумма очков ваших карт = {Summ}");
Console.ReadKey();
