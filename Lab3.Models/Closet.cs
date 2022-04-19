using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    //Абстрактный класс должен содержать 3-5 свойств и 3-5 методов(включая унаследованные свойства интерфейса).   
    
    //унаследованные свойства - Price, Id, свои Height, Length, Width = 5 всего
    // методы унаследванные ArrangeDelivery, Copy, свои - Volume = 3 всего


    // абстрактный класс шкаф
    public abstract class Closet : IFurniture
    {
        // приватные поля, хранящие информацию для свойств
        private double _price;
        private double _height;
        private double _length;
        private double _width;
        private int _id;

        // свойства set проверяют информацию на валидность и присваюивают соответсвующей переменной

        public double Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Указана отрицательная цена");

                _price = value;
            }
        }

        public double Height
        {
            get => _height;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Указана отрицательная высота");

                _height = value;
            }
        }

        public double Length
        {
            get => _length;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Указана отрицательная длина");

                _length = value;
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Указана отрицательная ширина");

                _width = value;
            }
        }

        public int Id
        {
            get => _id;
            set
            {
                if (value < 0)
                    throw new ArithmeticException("Указан отрицательный Id");
                
                _id = value;
            }
        }

        public double ArrangeDelivery()
        {
            // пусть дотсавка зависит от объёма товара
            // минимальная сумма доставки - 500, максимальная - 10000
            return Math.Min((Volume() * 0.01 + 500), 10000); 
        }

        public void Copy(IFurniture other)
        {
            // Id уникальное, копироваться не будет
            Price = other.Price;
            
            // так как на вход интерфейс, проверим, что это явлеятся типом шкаф
            if (other is Closet)
            {
                // это тип шкаф, коипруем инфу
                Closet otherCloset = other as Closet;
                Height = otherCloset.Height;
                Length = otherCloset.Length;
                Width = otherCloset.Width;
            }
        }

        public double Volume()
        {
            return Height * Length * Width;
        }
    }
}
