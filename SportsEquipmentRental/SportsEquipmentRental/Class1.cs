using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Программа для заполнения договора аренды продавцом
/// </summary>

namespace SportsEquipmentRental
{
    /// <summary>
    /// Класс покупателя
    /// <summary>
    public class Buyer
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; private set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; private set; }
    }


    public class CompletingForm
    {
        /// <summary>
        /// Имя покупателя
        /// </summary>
        public Buyer Name { get; set; }

        /// <summary>
        /// Фамилия покупателя
        /// </summary>
        public Buyer Surname { get; set; }

        /// <summary>
        /// Отчество покупателя
        /// </summary>
        public Buyer Patronymic { get; set; }

        /// <summary>
        /// Арендуемый инвентарь
        /// </summary>
        public Equipment Equip { get; set; }

        /// <summary>
        /// Время аренды
        /// </summary>
        public DateTime Timeframe { get; private set; }

        /// <summary>
        /// Цена аренды
        /// </summary>
        public Equipment Price { get; private set; }
    }

    /// <summary>
    /// Класс продавца
    /// <summary>
    public class Seller
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; private set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; private set; }
        /// <summary>
        /// Фото
        /// </summary>
        public byte[] Photo { get; private set; }
    }

    /// <summary>
    /// Класс инвенторя
    /// <summary>
    public class Equipment
    {
        /// <summary>
        /// Виды спорта
        /// </summary>
        public static List<string> TypeOfSports = new List<string>()
        {
           
        };

        /// <summary>
        /// Список фирм производителей
        /// </summary>
        public static List<string> Manufacturers = new List<string>()
        {

        };

        /// <summary>
        /// Спортивный инвентарь
        /// </summary>
        public string SportEquip { get; private set; }

        /// <summary>
        /// Вид спорта
        /// </summary>
        public string TypeOfSport { get; private set; }

        /// <summary>
        /// Дата производства
        /// </summary>
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// Производитель
        /// </summary>
        public string Manufacturer { get; private set; }

        /// <summary>
        /// Цена товара
        /// </summary>
        public double Price { get; private set; }

        /// <summary>
        /// Цена аренды
        /// </summary>
        public double PriceOfRental { get; private set; }
    }
}
