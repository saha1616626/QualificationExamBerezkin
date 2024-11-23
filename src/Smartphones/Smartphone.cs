using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones
{
    /// <summary>
    /// Данные о смартфоне
    /// </summary>
    public class Smartphone
    {
        /// <summary>
        /// Назавние модели
        /// </summary>
        public string nameModel {  get; set; }
        /// <summary>
        /// Цена смартфона
        /// </summary>
        public decimal price { get; set; }
        /// <summary>
        /// Диагональ экрана
        /// </summary>
        public decimal screenDiagonal { get; set; }

        /// <summary>
        /// Свободный конструктор
        /// </summary>
        public Smartphone() { }

    }
}
