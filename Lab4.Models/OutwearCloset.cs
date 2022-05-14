using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    // шкаф для верхней одежды
    // то есть там в основном можно поевесить одежду

    public class OutwearCloset : Closet
    {
        public bool HaveTopSelf { get; set; }

        public override double ArrangeDelivery()
        {
            return base.ArrangeDelivery() +
                (HaveTopSelf ? 500 : 0);
        }

        public int HowManyClothesFits(double clotheHeight, double clotheWidth)
        {
            if (clotheHeight == 0 || clotheWidth == 0)
                return 0;

            return (int)(Length / clotheWidth) + (int)(Height / clotheHeight);
        }

        public override void Copy(IFurniture other)
        {
            base.Copy(other);

            if (other is OutwearCloset outwearCloset)
            {
                HaveTopSelf = outwearCloset.HaveTopSelf;
            }
        }
    }
}
