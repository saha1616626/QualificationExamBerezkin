using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Smartphones
{
    /// <summary>
    /// Хранение списка смартфонов и выполнение сортировки данных
    /// </summary>
    public class GadgetFactory
    {
        /// <summary>
        /// Массив хранения списка смартфонов
        /// </summary>
        public Smartphone[] smartphones;

        /// <summary>
        /// Количество смартфонов в массиве
        /// </summary>
        public int numberSmartphonesArray;

        /// <summary>
        /// Конструктор определения размерности массива
        /// </summary>
        /// <param name="arraySize"> Размре массива </param>
        public GadgetFactory(int arraySize)
        {
            smartphones = new Smartphone[arraySize];
        }

        /// <summary>
        /// Добавить смартфон в массив
        /// </summary>
        /// <param name="smartphone"></param>
        public void AddSmartphoneArray(Smartphone smartphone)
        {
            // Проверка заполненности массива
            if (numberSmartphonesArray < smartphones.Length)
            {
                // Добавляем смартфон
                smartphones[numberSmartphonesArray] = smartphone;
                numberSmartphonesArray++;
                Console.WriteLine("Смартфон добавлен успешно!");
            }
            else
            {
                Console.WriteLine("Массив смартфонов заполнен.");
                // Вывод массива смартфонов
                OutputArrayFromSmartphones();
            }
        }

        /// <summary>
        /// Вывод массива смартфонов
        /// </summary>
        public void OutputArrayFromSmartphones()
        {
            if (smartphones != null)
            {
                for (int i = 0; i < numberSmartphonesArray; i++)
                {
                    Console.WriteLine($"\n{i + 1} - смартфон");
                    Console.WriteLine("Модель: " + smartphones[i].nameModel.ToString());
                    Console.WriteLine("Цена: " + smartphones[i].price.ToString());
                    Console.WriteLine("Диагональ: " + smartphones[i].screenDiagonal.ToString() + "\n");
                }
            }
            else
            {
                Console.WriteLine("\nМассив пустой!\n");
            }
        }

        /// <summary>
        /// Путь к файлу со смартфонами
        /// </summary>
        private readonly string path = @"/Smartphones.txt";

        /// <summary>
        /// Сохранение массива в файл
        /// </summary>
        public void SavingSrrayFile()
        {
            if (smartphones != null)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (int i = 0; i < numberSmartphonesArray; i++)
                    {
                        // Сохранение каждого смартфона в файл
                        writer.WriteLine($"\n{i + 1} - смартфон\n {smartphones[i].nameModel}\n,{smartphones[i].price}\n,{smartphones[i].screenDiagonal}\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nМассив пустой! Данные не сохранены!\n");
            }
        }
    }
}
