using System.Linq.Expressions;

Console.WriteLine("Введите дату Вашего рождения: ");
string Age = Console.ReadLine();
try
{
    string[] twoNumb = Age.Split('.');
    foreach (string nums in twoNumb)
    {
        Console.WriteLine($"Число: {nums}");
    }

    int date = Convert.ToInt32(twoNumb[0]);
    int mon = Convert.ToInt32(twoNumb[1]);
    int year = Convert.ToInt32(twoNumb[2]);

    string text = "Ваш знак зодиака: ";

    switch (mon)
    {
        case (03):
            if (date >= 21)
            { Console.WriteLine(text + "Овен"); }
            else { Console.WriteLine(text + "Рыбы"); }
            break;
        case (04):
            if (date >= 21)
            { Console.WriteLine(text + "Телец"); }
            else { Console.WriteLine(text + "Овен"); }
            break;
        case (05):
            if (date >= 21)
            { Console.WriteLine(text + "Близнецы"); }
            else { Console.WriteLine(text + "Телец"); }
            break;
        case (06):
            if (date >= 22)
            { Console.WriteLine(text + "Рак"); }
            else { Console.WriteLine(text + "Близнецы"); }
            break;
        case (07):
            if (date >= 23)
            { Console.WriteLine(text + "Лев"); }
            else { Console.WriteLine(text + "Рак"); }
            break;
        case (08):
            if (date >= 24)
            { Console.WriteLine(text + "Дева"); }
            else { Console.WriteLine(text + "Лев"); }
            break;
        case (09):
            if (date >= 24)
            { Console.WriteLine(text + "Весы"); }
            else { Console.WriteLine(text + "Дева"); }
            break;
        case (10):
            if (date >= 24)
            { Console.WriteLine(text + "Скорпион"); }
            else { Console.WriteLine(text + "Весы"); }
            break;
        case (11):
            if (date >= 23)
            { Console.WriteLine(text + "Стрелец"); }
            else { Console.WriteLine(text + "Скорпион"); }
            break;
        case (12):
            if (date >= 22)
            { Console.WriteLine(text + "Козерог"); }
            else { Console.WriteLine(text + "Стрелец"); }
            break;
        case (01):
            if (date >= 21)
            { Console.WriteLine(text + "Водолей"); }
            else { Console.WriteLine(text + "Козерог"); }
            break;
        case (02):
            if (date >= 21)
            { Console.WriteLine(text + "Рыбы"); }
            else { Console.WriteLine(text + "Водолей"); }
            break;
    }
 
    string textYear = "Ваше животное: ";

    switch (year % 12)
    {
        case 0: Console.WriteLine(textYear + "Обезьяна");
            break;
        case 1: Console.WriteLine(textYear + "Петух");
            break;
        case 2: Console.WriteLine(textYear + "Собака");
            break;
        case 3: Console.WriteLine(textYear + "Свинья");
            break;
        case 4: Console.WriteLine(textYear + "Крыса");
            break;
        case 5: Console.WriteLine(textYear + "Бык");
            break;
        case 6: Console.WriteLine(textYear + "Тигр");
            break;
        case 7: Console.WriteLine(textYear + "Кролик");
            break;
        case 8: Console.WriteLine(textYear + "Дракон");
            break;
        case 9: Console.WriteLine(textYear + "Змея");
            break;
        case 10: Console.WriteLine(textYear + "Лошадь");
            break;
        case 11: Console.WriteLine(textYear + "Овца");
            break;

    }

    string textEl = "Ваша стихия: ";
    switch (year % 10)
    {
        case 0:
        case 1: Console.WriteLine(textEl + "Металл"); break;
        
        case 2:
        case 3: Console.WriteLine(textEl + "Вода"); break;
        
        case 4:
        case 5: Console.WriteLine(textEl + "Дерево"); break;
        
        case 6:
        case 7: Console.WriteLine(textEl + "Огонь"); break;
        
        case 8:
        case 9: Console.WriteLine(textEl + "Земля"); break;
    }

      
   }
catch (Exception e) { Console.WriteLine("Некорректный ввод, введите в формате дд.мм.гггг"); }




Console.ReadKey();
