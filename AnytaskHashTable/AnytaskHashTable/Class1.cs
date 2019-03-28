using System;

namespace HashTable
{
    public class KeyValue
    {
        public object Key { get; private set; }
        public object Value { get; private set; }
        public KeyValue(object key, object value)
        {
            Key = key;
            Value = value;
        }
    }

    public class HashTable

    {
        public int Size;
        public KeyValue[] Array;
        /// <summary>

        /// Конструктор контейнера

        /// summary>

        /// size">Размер хэ-таблицы

        public HashTable(int size)

        {
            Array = new KeyValue[size];
            Size = size;
        }



        ///

        /// Метод складывающий пару ключь-значение в таблицу

        ///

        /// key">

        /// value">

        public void PutPair(object key, object value)

        {
            var index = Math.Abs(key.GetHashCode()) % Size;
            for (; Array[index] != null; index = (index + 1) % Size) 
            {
                if (Array[index].Key.Equals(key)) 
                    break;
            }
            Array[index] = new KeyValue(key, value);
        }

        /// <summary>

        /// Поиск значения по ключу

        /// summary>

        /// key">Ключь

        /// <returns>Значение, null если ключ отсутствуетreturns>

        public object GetValueByKey(object key)

        {
            foreach(var e in Array)
            {
                if (e.Key.Equals(key)) 
                    return e.Value;
            }
            return null;
        }
    }
}