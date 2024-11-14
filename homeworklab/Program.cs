using System;

enum AccountType
{
    Текущий,
    Сберегательный
}

class Program
{
    static void Main()
    {
        Console.WriteLine("№1lab");
        /*Создать перечислимый тип данных отображающий виды банковского
счета(текущий и сберегательный).Создать переменную типа перечисления, присвоить ей
значение и вывести это значение на печать.*/

        AccountType myAccount = AccountType.Сберегательный;
        Console.WriteLine("Тип банковского счета: " + myAccount);
    }
}