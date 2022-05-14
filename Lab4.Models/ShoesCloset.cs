using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class ShoesCloset : Closet
    {
        public bool DividedIntoCells { get; set; }
        public int ShelvesNumber { get; set; }

        public override double ArrangeDelivery()
        {
            return base.ArrangeDelivery() + 
                (DividedIntoCells ? 500 : 0);
        }

        public int HowManyShoesFitsOnSelf(double shoeWidth)
        {
            if (shoeWidth == 0)
                return 0;

            return (int)(Length / shoeWidth);
        }

        public int HowManyShoesFits(double shoeWidth)
        {
            return ShelvesNumber * HowManyShoesFitsOnSelf(shoeWidth);
        }

        public override void Copy(IFurniture other)
        {
            base.Copy(other);

            if (other is ShoesCloset shoesCloset)
            {
                DividedIntoCells = shoesCloset.DividedIntoCells;
                ShelvesNumber = shoesCloset.ShelvesNumber;
            }
        }
    }
}
