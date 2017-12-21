using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pathfinder
{
    public abstract class Item
    {
        protected string name;
        protected int price;
        protected Image thumbPic;

        public string Name
        {
            get { return name; }
        }

        public int Price
        {
            get { return price; }
        }

        public abstract float Weight
        {
            get;
        }

        public Image ThumbnailPic
        {
            get { return thumbPic; }
        }
    }

    public abstract class HandItem : Item
    {
        protected int enhanceBonus;
    }
}
