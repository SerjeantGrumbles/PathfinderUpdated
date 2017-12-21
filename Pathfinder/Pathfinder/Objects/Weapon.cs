using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Pathfinder.Properties;

namespace Pathfinder
{
    public enum Wielding { Light, OneHanded, TwoHanded }
    public enum Categories { Simple, Martial, Exotic }
    public enum dTypes { Piercing, Slashing, Bludgeoning }
    public enum ammoTypes { Arrows, Bolts, Bullets, Darts}

    public class Weapon : HandItem
    {
        public Weapon() { }

        public Weapon(string n, int b)
        {
            name = n;
            enhanceBonus = b;
        }

        public override float Weight
        {
            get;
        }

        public int Bonus
        {
            get { return enhanceBonus; }
        }

        public virtual Wielding WieldType
        {
            get;
        }

        public virtual Categories Category
        {
            get;
        }

        public virtual dTypes DamageType
        {
            get;
        }

        public virtual int CriticalThreatRoll
        {
            get { return 20; }
        }

        public virtual int CriticalHitMultiplier
        {
            get { return 2; }
        }

        public virtual int Damage()
        {
            return Dice.d6() + Bonus;
        }

        public virtual string BaseDamageToString()
        {
            return "d6";
        }

        public string DamageToString()
        {
            if (Bonus == 0)
            {
                return BaseDamageToString();
            }
            else
            {
                return BaseDamageToString() + " + " + enhanceBonus;
            }
        }
    }

    public class RangedWeapon : Weapon
    {
        public RangedWeapon() { }

        public RangedWeapon(string n, int b)
        {
            name = n;
            enhanceBonus = b;
        }

        public virtual int Range
        {
            get;
        }
    }

    public class ProjectileWeapon : RangedWeapon
    {
        public ProjectileWeapon() { }

        public ProjectileWeapon(string n, int b)
        {
            name = n;
            enhanceBonus = b;
        }

        public virtual ammoTypes Ammunition
        {
            get;
        }
    }

    /************ MELEE WEAPONS *************************\ 
    /****************************************************/

    public class BastardSword : Weapon
    {
        public BastardSword(string n = "Bastard Sword", int b = 0, int p = 35)
        {
            name = n;
            enhanceBonus = b;
            price = p;
        }

        public override float Weight
        {
            get { return 6; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.OneHanded; }
        }

        public override Categories Category
        {
            get { return Categories.Exotic; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Slashing; }
        }

        public override int CriticalThreatRoll
        {
            get { return 19; /* 19-20 */ }
        }

        public override int Damage()
        {
            return Dice.d10() + Bonus;
        }

        public override string BaseDamageToString()
        {
                return "d10";
        }
    }

    public class Battleaxe : Weapon
    {
        public Battleaxe(string n = "Battleaxe", int b = 0, int p = 10)
        {
            name = n;
            enhanceBonus = b;
            price = p;
            thumbPic = Resources.Axe;
        }

        public override float Weight
        {
            get { return 6; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.OneHanded; }
        }

        public override Categories Category
        {
            get { return Categories.Martial; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Slashing; }
        }

        public override int CriticalHitMultiplier
        {
            get { return 3; }
        }

        public override int Damage()
        {
            return Dice.d8() + enhanceBonus;
        }

        public override string BaseDamageToString()
        {
                return "d8";
        }
    }

    public class Club : Weapon
    {
        public Club(string n = "Club", int b = 0, int p = 0)
        {
            name = n;
            enhanceBonus = b;
            price = p;
        }

        public override float Weight
        {
            get { return 3; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.OneHanded; }
        }

        public override Categories Category
        {
            get { return Categories.Simple; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Bludgeoning; }
        }
    }

    public class Dagger : Weapon
    {
        public Dagger(string n = "Dagger", int b = 0, int p = 2)
        {
            name = n;
            enhanceBonus = b;
            price = p;
        }

        public override float Weight
        {
            get { return 1; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.Light; }
        }

        public override Categories Category
        {
            get { return Categories.Simple; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Slashing; } // Piercing OR Slashing
        }

        public override int CriticalThreatRoll
        {
            get { return 19; /* 19-20 */ }
        }

        public override int Damage()
        {
            return Dice.d4() + Bonus;
        }

        public override string BaseDamageToString()
        { 
                return "d4";
        }
    }

    public class Flail : Weapon
    {
        public Flail(string n = "Flail", int b = 0, int p = 8)
        {
            name = n;
            enhanceBonus = b;
            price = p;
        }

        public override float Weight
        {
            get { return 5; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.OneHanded; }
        }

        public override Categories Category
        {
            get { return Categories.Martial; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Slashing; }
        }

        public override int Damage()
        {
            return Dice.d8() + Bonus;
        }

        public override string BaseDamageToString()
        {
                return "d8";
        }
    }

    public class Greataxe : Weapon
    {
        public Greataxe(string n = "Greataxe", int b = 0, int p = 20)
        {
            name = n;
            enhanceBonus = b;
            price = p;
        }

        public override float Weight
        {
            get { return 12; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.TwoHanded; }
        }

        public override Categories Category
        {
            get { return Categories.Martial; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Slashing; }
        }

        public override int CriticalHitMultiplier
        {
            get { return 3; }
        }

        public override int Damage()
        {
            return Dice.d12() + Bonus;
        }

        public override string BaseDamageToString()
        {
                return "d12";
        }
    }

    public class Greatsword : Weapon
    {
        public Greatsword(string n = "Greatsword", int b = 0, int p = 50)
        {
            name = n;
            enhanceBonus = b;
            price = p;
            thumbPic = Resources._2H_Sword;
        }

        public override float Weight
        {
            get { return 8; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.TwoHanded; }
        }

        public override Categories Category
        {
            get { return Categories.Martial; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Slashing; }
        }

        public override int CriticalThreatRoll
        {
            get { return 19; /* 19-20 */ }
        }

        public override int Damage()
        {
            return Dice.d6() + Dice.d6() + Bonus;
        }

        public override string BaseDamageToString()
        {
                return "2d6";
        }
    }
    
    public class Halberd : Weapon
    {
        public Halberd(string n = "Halberd", int b = 0, int p = 10)
        {
            name = n;
            enhanceBonus = b;
            price = p;
            thumbPic = Resources.Halberd;
        }

        public override float Weight
        {
            get { return 12; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.TwoHanded; }
        }

        public override Categories Category
        {
            get { return Categories.Martial; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Slashing; } //Piercing or Slashing
        }

        public override int CriticalHitMultiplier
        {
            get { return 3; }
        }

        public override int Damage()
        {
            return Dice.d10() + Bonus;
        }

        public override string BaseDamageToString()
        {
                return "d10";
        }
    }

    public class Longsword : Weapon
    {
        public Longsword(string n = "Longsword", int b = 0, int p = 15)
        {
            name = n;
            enhanceBonus = b;
            price = p;
            thumbPic = Resources.Longsword;
        }

        public override float Weight
        {
            get { return 4; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.OneHanded; }
        }

        public override Categories Category
        {
            get { return Categories.Martial; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Slashing; }
        }

        public override int CriticalThreatRoll
        {
            get { return 19; /* 19-20 */ }
        }

        public override int Damage()
        {
            return Dice.d8() + Bonus;
        }

        public override string BaseDamageToString()
        {
                return "d8";
        }
    }

    public class Mace : Weapon
    {
        public Mace(string n = "Mace", int b = 0, int p = 12)
        {
            name = n;
            enhanceBonus = b;
            price = p;
            thumbPic = Resources.Mace;
        }

        public override float Weight
        {
            get { return 8; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.OneHanded; }
        }

        public override Categories Category
        {
            get { return Categories.Simple; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Bludgeoning; }
        }

        public override int Damage()
        {
            return Dice.d8() + Bonus;
        }

        public override string BaseDamageToString()
        {
                return "d8";
        }
    }
    // Morning Star


    public class Quarterstaff : Weapon
    {
        public Quarterstaff(string n = "Quarterstaff", int b = 0, int p = 0)
        {
            name = n;
            enhanceBonus = b;
            price = p;
            thumbPic = Resources.Staff;
        }

        public override float Weight
        {
            get { return 4; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.TwoHanded; }
        }

        public override Categories Category
        {
            get { return Categories.Simple; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Bludgeoning; }
        }
    }

    // Scimitar
    // ShortSword
    // Spear
    public class Warhammer : Weapon
    {
        public Warhammer(string n = "Warhammer", int b = 0, int p = 12)
        {
            name = n;
            enhanceBonus = b;
            price = p;
            thumbPic = Resources.Hammer;
        }

        public override float Weight
        {
            get { return 5; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.OneHanded; }
        }

        public override Categories Category
        {
            get { return Categories.Martial; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Bludgeoning; }
        }

        public override int CriticalHitMultiplier
        {
            get { return 3; }
        }

        public override int Damage()
        {
            return Dice.d8() + Bonus;
        }

        public override string BaseDamageToString()
        {
                return "d8";
        }
    }

    /************ RANGED WEAPONS ************************\ 
    /****************************************************/

    public class LightCrossbow : ProjectileWeapon
    {
        public LightCrossbow(string n = "Light Crossbow", int b = 0, int p = 35)
        {
            name = n;
            enhanceBonus = b;
            price = p;
            thumbPic = Resources.LightCrossbow;
        }

        public override float Weight
        {
            get { return 4; }
        }

        public override Wielding WieldType
        {
            get { return Wielding.TwoHanded; }
        }

        public override Categories Category
        {
            get { return Categories.Simple; }
        }

        public override dTypes DamageType
        {
            get { return dTypes.Piercing; }
        }

        public override int CriticalThreatRoll
        {
            get { return 19; }
        }

        public override int Damage()
        {
            return Dice.d8() + Bonus;
        }

        public override string BaseDamageToString()
        {
            return "d8";
        }

        public override int Range
        {
            get { return 80; }
        }

        public override ammoTypes Ammunition
        {
            get { return ammoTypes.Bolts; }
        }
    }
}
