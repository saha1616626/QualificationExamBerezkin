using Smartphones;
using System;

public class Program
{
    static void Main(string[] args)
    {
        GadgetFactory gadgetFactory = null;

        while (true)
        {
            Console.WriteLine("\nВыбор функции:");
            Console.WriteLine("1 - Просмотр списка смартфонов по убыванию (по сочетанию свойств «модель» и «размер диагонали экрана» с возможностью экспорта данных)");
            Console.WriteLine("2 - Заполнить список смартфонов (все текущие данные из списка сотрутся)");
            Console.WriteLine("3 - Выход из программы");
            Console.Write("\nВведите номер функции: ");

            string number = Console.ReadLine();
            Console.Write("");

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
                        gadgetFactory.SortingArray();
                        gadgetFactory.OutputArrayFromSmartphones();

                        // Сохранение массива в файл
                        Console.WriteLine("Сохранить список в файл? (Да или Нет)");
                        if (Console.ReadLine().Equals("Да", StringComparison.OrdinalIgnoreCase))
                        {
                            gadgetFactory.SavingSrrayFile();
                            Console.WriteLine("Список сохранён!");
                        }

                    }

                    break;

                case "2":

                    Console.Write("Введите размер списка смартфонов: ");
                    int size;

                    if (int.TryParse(Console.ReadLine(), out size))
                    {
                        gadgetFactory = new GadgetFactory(size); // Произвести очистку и создание нового списка

                        for (int i = 0; i < size; i++)
                        {
                            Console.WriteLine($"Ввод {i + 1}-го смартфона:");

                            Console.Write("Введите модель смартфона: ");
                            string model = Console.ReadLine();

                            decimal price;
                            while (true)
                            {
                                Console.Write("Введите цену смартфона: ");
                                if (decimal.TryParse(Console.ReadLine(), out price) && price >= 0)
                                {
                                    break;
                                }
                                Console.WriteLine("Ошибка: Введите корректную цену.");
                            }

                            decimal screenDiagonal;
                            while (true)
                            {
                                Console.Write("Введите диагональ смартфона: ");
                                if (decimal.TryParse(Console.ReadLine(), out screenDiagonal) && screenDiagonal > 0)
                                {
                                    break;
                                }
                                Console.WriteLine("Ошибка: Введите корректный размер диагонали.");
                            }

                            Smartphone smartphone = new Smartphone();
                            smartphone.nameModel = model;
                            smartphone.price = price;
                            smartphone.screenDiagonal = screenDiagonal;

                            gadgetFactory.AddSmartphoneArray(smartphone);
                            Console.WriteLine("Смартфон успешно добавлен.");
                        }

                        // Вывод массива смартфонов
                        gadgetFactory.SortingArray();
                        gadgetFactory.OutputArrayFromSmartphones();

                        // Сохранение массива в файл
                        Console.WriteLine("Сохранить список в файл? (Да или Нет)");
                        if (Console.ReadLine().Equals("Да", StringComparison.OrdinalIgnoreCase))
                        {
                            gadgetFactory.SavingSrrayFile();
                            Console.WriteLine("Список сохранён!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Корректно введите размер списка!");
                    }

                    break;

                case "3":
                    Console.WriteLine("Выход из программы...");
                    break;

                default:
                    Console.WriteLine("Ошибка: Неверный ввод!");
                    break;
            }
        }

        Console.ReadLine();
    }
}
