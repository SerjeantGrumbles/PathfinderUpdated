using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pathfinder.Properties;

namespace Pathfinder
{
    public class Armor : Item
    {
        protected int enhanceBonus;

        public enum Categories { Light, Medium, Heavy}

        public Armor() { }

        public Armor(string n, int b)
        {
            name = n;
            enhanceBonus = b;
        }

        public override float Weight
        {
            get;
        }

        public int EnhanceBonus
        {
            get { return enhanceBonus; }
        }

        public virtual Categories Category
        {
            get;
        }

        public virtual int BaseArmor
        {
            get;
        }

        public int ArmorBonus
        {
            get { return BaseArmor + EnhanceBonus; }
        }

        public virtual int MaxDexBonus
        {
            get;
        }

        public virtual int ArmorChkPenalty
        {
            get;
        }

        public virtual float ArcaneSpellFail
        {
            get;
        }
    }


    //Breastplate

    public class Chainmail : Armor
    {
        public Chainmail(string n = "Chainmail", int b = 0, int p = 150)
        {
            name = n;
            enhanceBonus = b;
            price = p;
            thumbPic = Resources.Chainmail;
        }

        public override float Weight
        {
            get { return 40; }
        }

        public override Categories Category
        {
            get { return Categories.Medium; }
        }

        public override int BaseArmor
        {
            get { return 6; }
        }

        public override int MaxDexBonus
        {
            get { return 2; }
        }

        public override int ArmorChkPenalty
        {
            get { return 5; }
        }

        public override float ArcaneSpellFail
        {
            get { return 0.30F; }
        }
    }

    public class FullPlate : Armor
    {
        public FullPlate(string n = "Full Plate", int b = 0, int p = 1500)
        {
            name = n;
            enhanceBonus = b;
            price = p;
            thumbPic = Resources.Fullplate;
        }

        public override float Weight
        {
            get { return 50; }
        }

        public override Categories Category
        {
            get { return Categories.Heavy; }
        }

        public override int BaseArmor
        {
            get { return 9; }
        }

        public override int MaxDexBonus
        {
            get { return 1; }
        }

        public override int ArmorChkPenalty
        {
            get { return 6; }
        }

        public override float ArcaneSpellFail
        {
            get { return 0.35F; }
        }
    }

    //Half-plate

    public class Leather : Armor
    {
        public Leather(string n = "Leather", int b = 0, int p = 10)
        {
            name = n;
            enhanceBonus = b;
            price = p;
            thumbPic = Resources.Leather;
        }

        public override float Weight
        {
            get { return 15; }
        }

        public override Categories Category
        {
            get { return Categories.Light; }
        }

        public override int BaseArmor
        {
            get { return 2; }
        }

        public override int MaxDexBonus
        {
            get { return 6; }
        }

        public override int ArmorChkPenalty
        {
            get { return 0; }
        }

        public override float ArcaneSpellFail
        {
            get { return 0.10F; }
        }
    }

    public class Padded : Armor
    {
        public Padded(string n = "Padded", int b = 0, int p = 5)
        {
            name = n;
            enhanceBonus = b;
            price = p;
            thumbPic = Resources.Cloth;
        }

        public override float Weight
        {
            get { return 10; }
        }

        public override Categories Category
        {
            get { return Categories.Light; }
        }

        public override int BaseArmor
        {
            get { return 1; }
        }

        public override int MaxDexBonus
        {
            get { return 8; }
        }

        public override int ArmorChkPenalty
        {
            get { return 0; }
        }

        public override float ArcaneSpellFail
        {
            get { return 0.05F; }
        }
    }

    //Scale Mail
    //Splint Mail
    //Studded Leather
}
