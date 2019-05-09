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
        public string Name { get;  set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get;  set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get;  set; }

        public override string ToString()
        {
            return $"Покупатель: {Surname}  {Name}  {Patronymic}";
        }
    }


    public class CompletingForm
    {
        /// <summary>
        ///Покупатель
        /// </summary>
        public Buyer Buyer { get; set; }
        /// <summary>
        ///Продавец
        /// </summary>

        public Seller Seller { get; set; }

        /// <summary>
        /// Арендуемый инвентарь
        /// </summary>
        public string[] Equip { get; set; }
        
    }

    /// <summary>
    /// Класс продавца
    /// <summary>
    public class Seller
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Фото
        /// </summary>
        public byte[] Photo { get;  set; }
        public override string ToString()
        {
            return $"Продавец: {Surname} {Name} {Patronymic}";
        }
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
           "Футбол","Баскетбол", "Валейбол", "Плавание", "Лыжный спорт", "Тэнис", "Другое"
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
        public string SportEquip { get; set; }

        /// <summary>
        /// Вид спорта
        /// </summary>
        public string TypeOfSport { get; set; }

        /// <summary>
        /// Дата производства
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Цена товара
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Цена аренды
        /// </summary>
        public string PriceOfRental { get; set; }

        public override string ToString()
        {
            return $"Название:{SportEquip} , Вид спорта:{TypeOfSport} , Цена аренды: {PriceOfRental} , Изготовитель: {Manufacturer}, Цена товара: {Price}, Дата изготовления: {CreationDate.ToLongDateString()}";
        }

    }
}
