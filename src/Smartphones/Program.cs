using Smartphones;

static void Main(string[] args)
{
    GadgetFactory gadgetFactory = null;

    while (true)
    {
        Console.WriteLine("Выбор функции:");
        Console.WriteLine("1 - Просмотр списка смартфонов по убыванию (по сочетанию свойств «модель» и «размер диагонали экрана» с возможностью экспорта данных)");
        Console.WriteLine("2 - Заполнить список смартфонов (все текущие данные из списка сотрутся)");
        Console.WriteLine("3 - Выход из программы");
        Console.Write("\nВведите номер функции: ");

        string number = Console.ReadLine();

        switch (number)
        {
            case "1":

                if (gadgetFactory == null || gadgetFactory.numberSmartphonesArray == 0)
                {
                    Console.WriteLine("Список смартфонов пустой.");
                }
                else
                {
                    // Вывод массива смартфонов
                    gadgetFactory.OutputArrayFromSmartphones();

                    // Сохранение массива в файл
                    Console.WriteLine("Сохранить список в файл? (Да или Нет)");
                    if (Console.ReadLine().Equals("Да", StringComparison.OrdinalIgnoreCase))
                    {
                        gadgetFactory.SortingArray();
                        Console.WriteLine("Список сохранён!");
                    }

                }

                break;
            
            case "2":



                break;
        }
    }
}