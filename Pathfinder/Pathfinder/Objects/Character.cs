using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Pathfinder
{
    public class Character
    {
        private int charStrength, charDexterity, charConstitution, charIntelligence, charWisdom, charCharisma;
        private string charName;
        private Genders charGender;
        private Races charRace;
        private Orders charOrderAlign;
        private Morals charMoralAlign;
        private int charLevel = 1;
        private const int maxLevel = 20;
        private int charExp = 0;
        private int nextLevelExp = 2000;
        private const int maxExp = 3600000;
        private int abilityPts = 0;
        protected int baseHP = 6;
        protected int currentHP; //= baseHP
        protected int charGold = 0;
        private const int baseAC = 10;
        private bool successEquip;
        public Weapon MainHand;
        public Armor Armour;
        public Item[,] Inventory = new Item[3, 13];
        public enum Genders { Male, Female };
        public enum Races { Dwarf, Elf, Gnome, HalfElf, HalfOrc, Halfling, Human };
        public enum Orders { Lawful, Neutral, Chaotic };
        public enum Morals { Good, Neutral, Evil };

        public Character()
        {

        }

        public Character(string nom, Races race, Genders gender, Orders order, Morals moral,
            int str, int dex, int con, int intel, int wis, int cha)
        {
            ConstructCharacter(nom, race, gender, order, moral, str, dex, con, intel, wis, cha);
            currentHP = HitPoints;
        }

        public Character(Character c)
        {
            ConstructCharacter(c.Name, c.Race, c.Gender, c.OrderAlignment, c.MoralAlignment, c.Strength, c.Dexterity,
                c.Constitution, c.Intelligence, c.Wisdom, c.Charisma);
            currentHP = HitPoints;
        }

        protected void ConstructCharacter(string name, Races race, Genders gender, Orders order, Morals moral,
            int str, int dex, int con, int intel, int wis, int cha)
        {
            charName = name;
            charRace = race;
            charGender = gender;
            charOrderAlign = order;
            charMoralAlign = moral;
            charStrength = str;
            charDexterity = dex;
            charConstitution = con;
            charIntelligence = intel;
            charWisdom = wis;
            charCharisma = cha;
        }

        /* START PROPERTY ACCESSORS *************************\ 
        /****************************************************/
        public Image Portrait { get; set; }

        public string Name
        {
            get
            {
                return charName;
            }
        }

        public Races Race
        {
            get
            {
                return charRace;
            }
        }

        public Genders Gender
        {
            get
            {
                return charGender;
            }
        }

        public Orders OrderAlignment
        {
            get
            {
                return charOrderAlign;
            }
        }

        public Morals MoralAlignment
        {
            get
            {
                return charMoralAlign;
            }
        }

        public int Strength
        {
            get
            {
                return charStrength;
            }
        }

        public int Dexterity
        {
            get
            {
                return charDexterity;
            }
        }

        public int Constitution
        {
            get
            {
                return charConstitution;
            }
        }

        public int Intelligence
        {
            get
            {
                return charIntelligence;
            }
        }

        public int Wisdom
        {
            get
            {
                return charWisdom;
            }
        }

        public int Charisma
        {
            get
            {
                return charCharisma;
            }
        }

        public string Alignment
        {
            get
            {
                if (OrderAlignment == Orders.Neutral && MoralAlignment == Morals.Neutral)
                {
                    return "True Neutral";
                }
                else
                {
                    return OrderAlignment + " " + MoralAlignment;
                }
            }
        }

        public int Level
        {
            get
            {
                return charLevel;
            }
        }

        public int Experience
        {
            get
            {
                return charExp;
            }
        }

        public int ToNextLevel
        {
            get
            {
                return nextLevelExp;
            }
        }

        public int AbilityPoints
        {
            get
            {
                return abilityPts;
            }
        }

        public int StrengthModifier
        {
            get
            {
                return AbilityMod(Strength);
            }
        }

        public int DexterityModifier
        {
            get
            {
                return AbilityMod(Dexterity);
            }
        }

        public int ConstitutionModifier
        {
            get
            {
                return AbilityMod(Constitution);
            }
        }

        public int IntelligenceModifier
        {
            get
            {
                return AbilityMod(Intelligence);
            }
        }

        public int WisdomModifier
        {
            get
            {
                return AbilityMod(Wisdom);
            }
        }

        public int CharismaModifier
        {
            get
            {
                return AbilityMod(Charisma);
            }
        }

        public int HitPoints
        {
            get
            {
                return baseHP + (Level * ConstitutionModifier);
            }
        }

        public int CurrentHitPoints
        {
            get
            {
                return currentHP;
            }
        }

        public virtual int ArmorClass
        {
            get
            {
                // Armor Class = BaseAC(10) + armor bonus + shield bonus + Dex modifier + other modifiers
                
                if (Armour == null)
                {
                    return baseAC + DexterityModifier;
                }
                else if (DexterityModifier <= Armour.MaxDexBonus)
                {
                    return baseAC + Armour.ArmorBonus + DexterityModifier;
                }
                else
                {
                    return baseAC + Armour.ArmorBonus + Armour.MaxDexBonus;
                }
                
            }
        }

        public virtual int BaseAttackBonus
        {
            get
            {
                // applicable to Sorcerer, Wizard
                return Level / 2;
            }
        }

        public virtual int BaseWillSave // Weak, used by Barbarian, Fighter, Ranger, Rogue
        {
            get { return Level / 3; }
        }

        public virtual int BaseRefSave // Weak, used by Barbarian, Cleric, Druid, Fighter, Paladin, Sorcerer, Wizard
        {
            get { return Level / 3; }
        }

        public virtual int BaseFortSave // Weak, used by Bard, Rogue, Sorcerer, Wizard
        {
            get { return Level / 3; }
        }

        public int WillSave
        {
            get { return BaseWillSave + WisdomModifier; }
        }

        public int RefSave
        {
            get { return BaseRefSave + DexterityModifier; }
        }

        public int FortSave
        {
            get { return BaseFortSave + ConstitutionModifier; }
        }

        public int Gold
        {
            get { return charGold; }
        }

        public bool SuccessfulEquip
        {
            get { return successEquip; }
        }

        // END PROPERTY ACCESSORS______________________________

        /* START VOID METHODS*************************\ 
        /********************************************/
        // public void Save()
        // public void Load()

        public void AddExperience(int xp)
        {
            if (charLevel == maxLevel)
            {
                charExp = maxExp;
                return;
            }
            charExp += xp;
            while (Experience >= nextLevelExp && charLevel < maxLevel)
            {
                LevelUp();
            }
        }

        private void LevelUp()
        {
            charLevel += 1;
            switch (Level)
            {
                // Level up
                // 1:  0 XP
                // 2:  2000 XP
                // 3:  5000 XP
                // 4:  9000 XP
                // 5:  15,000 XP 
                // 6:  23,000 XP
                // 7:  35,000 XP
                // 8:  51,000 XP
                // 9:  75,000 XP
                // 10: 105,000 XP
                // 11: 155,000 XP
                // 12: 220,000 XP
                // 13: 315,000 XP
                // 14: 445,000 XP
                // 15: 635,000 XP
                // 16: 890,000 XP
                // 17: 1,300,000 XP
                // 18: 1,800,000 XP
                // 19: 2,550,000 XP
                // 20: 3,600,000 XP
                case 2:
                    nextLevelExp = 5000;
                    break;
                case 3:
                    nextLevelExp = 9000;
                    break;
                case 4:
                    nextLevelExp = 15000;
                    break;
                case 5:
                    nextLevelExp = 23000;
                    break;
                case 6:
                    nextLevelExp = 35000;
                    break;
                case 7:
                    nextLevelExp = 51000;
                    break;
                case 8:
                    nextLevelExp = 75000;
                    break;
                case 9:
                    nextLevelExp = 105000;
                    break;
                case 10:
                    nextLevelExp = 155000;
                    break;
                case 11:
                    nextLevelExp = 220000;
                    break;
                case 12:
                    nextLevelExp = 315000;
                    break;
                case 13:
                    nextLevelExp = 445000;
                    break;
                case 14:
                    nextLevelExp = 635000;
                    break;
                case 15:
                    nextLevelExp = 890000;
                    break;
                case 16:
                    nextLevelExp = 1300000;
                    break;
                case 17:
                    nextLevelExp = 1800000;
                    break;
                case 18:
                    nextLevelExp = 2550000;
                    break;
                case 19:
                    nextLevelExp = 3600000;
                    break;
            }

            if ((Level % 4) == 0)
            {
                abilityPts += 1;
            }

            AddHitPoints();

            MessageBox.Show("Level Up!", "DING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*** TEST: Add Gold each Level Up***/
        }

        public void AddStrength()
        {
            if (AbilityPoints > 0)
            {
                charStrength += 1;
                abilityPts -= 1;
            }
        }

        public void AddDexterity()
        {
            if (AbilityPoints > 0)
            {
                charDexterity += 1;
                abilityPts -= 1;
            }
        }

        public void AddConstitution()
        {
            if (AbilityPoints > 0)
            {
                int oldConMod = ConstitutionModifier;
                charConstitution += 1;
                //baseHP += AbilityMod(Level);
                //currentHP += Level;
                abilityPts -= 1;
                currentHP += (ConstitutionModifier - oldConMod) * Level;
            }
        }

        public void AddIntelligence()
        {
            if (AbilityPoints > 0)
            {
                charIntelligence += 1;
                abilityPts -= 1;
            }
        }

        public void AddWisdom()
        {
            if (AbilityPoints > 0)
            {
                charWisdom += 1;
                abilityPts -= 1;
            }
        }

        public void AddCharisma()
        {
            if (AbilityPoints > 0)
            {
                charCharisma += 1;
                abilityPts -= 1;
            }
        }

        protected virtual void AddHitPoints() //HP gained whenver character levels up
        {
            baseHP += 6; // Number applicable to daughter classes Wizard, Sorcerer
                         // Bard, Cleric, Druid, Monk, Rogue  = d8 or 8
                         // Figher, Paladin, Ranger = d10 or 10
                         // Barbarian = d12 or 12
            currentHP += 6 + ConstitutionModifier;
        }


        /* used to test inventory */
        public void StartingInventory()
        {
            Inventory[0, 0] = new Longsword();
            Inventory[0, 1] = new Greatsword();
            Inventory[0, 2] = new Battleaxe();
            Inventory[0, 3] = new Halberd();
            Inventory[0, 4] = new Mace();
            Inventory[0, 5] = new Warhammer();
            Inventory[0, 6] = new Quarterstaff();
            Inventory[0, 7] = new Padded();
            Inventory[0, 8] = new Leather();
            Inventory[0, 9] = new Chainmail();
            Inventory[0, 10] = new FullPlate();
            Inventory[1, 0] = new LightCrossbow();
        }

        public void SwapInventory(int i1, int j1, int i2, int j2)
        {
            Item temp;
            temp = Inventory[i1, j1];
            Inventory[i1, j1] = Inventory[i2, j2];
            Inventory[i2, j2] = temp; 
        }

        public void EquipMainHand(int i, int j)
        {
            if (Inventory[i, j] != null && !(Inventory[i, j] is Weapon))
            {
                MessageBox.Show("Unable to equip item in that slot!", "Wrong slot", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                successEquip = false;
                return;
            }
            successEquip = true;
            Weapon temp;
            temp = (Weapon)Inventory[i, j];
            Inventory[i, j] = MainHand;
            MainHand = temp;
        }

        public void EquipArmour(int i, int j)
        {
            if (Inventory[i, j] != null && !(Inventory[i, j] is Armor))
            {
                MessageBox.Show("Unable to equip item in that slot!", "Wrong slot", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                successEquip = false;
                return;
            }
            successEquip = true;
            Armor temp;
            temp = (Armor)Inventory[i, j];
            Inventory[i, j] = Armour;
            Armour = temp;
        }

        // END VOID METHODS______________________________

        /* START ToSTRING FUNCTIONS*************************\ 
        /********************************************/
        public override string ToString()
        {
            return Name + "\nLevel " + Level;
        }

        public string RaceToString()
        {
            string strRace = Race.ToString();
            if (strRace == "HalfElf" || strRace == "HalfOrc")
            {
                strRace = strRace.Replace(strRace.Substring(4, 1), strRace.Substring(4, 1).ToLower());
                strRace = strRace.Insert(4, "-");
            }
            return strRace;
        }

        public string CharInfoToString()
        {
            return RaceToString() + "\n" + Alignment + "\n" + Gender;
        }

        public string ExperienceToString()
        {
            return String.Format("{0:N0} / {1:N0}", charExp, nextLevelExp);
        }

        public string HitPointsToString()
        {
            return String.Format("{0} / {1}", CurrentHitPoints, HitPoints);
        }

        public string AttackToString()
        {
            // If ranged:
            // Base attack bonus + dexterity mod
            // If melee:
            // Base attack bonus + strength mod + size mod
            int attackBonus;
            if (MainHand is RangedWeapon)
            {
                attackBonus = BaseAttackBonus + DexterityModifier;
            }
            else
            {
                attackBonus = BaseAttackBonus + StrengthModifier;
            }
            string strAttack = "";
            int i = 0;
            do
            {
                if (attackBonus - i >= 0)
                {
                    strAttack += "+" + (attackBonus - i);
                }
                else
                {
                    strAttack += (attackBonus - i);
                }
                if (BaseAttackBonus - i > 5)
                {
                    strAttack += "/";
                }
                i += 5;
            } while (i < BaseAttackBonus);
            return strAttack;
        }

        public string WillSaveToString()
        {
            if (WillSave >= 0)
            {
                return "+" + WillSave;
            }
            else
            {
                return Convert.ToString(WillSave);
            }
        }

        public string RefSaveToString()
        {
            if (RefSave >= 0)
            {
                return "+" + RefSave;
            }
            else
            {
                return Convert.ToString(RefSave);
            }
        }

        public string FortSaveToString()
        {
            if (FortSave >= 0)
            {
                return "+" + FortSave;
            }
            else
            {
                return Convert.ToString(FortSave);
            }
        }

        public virtual string DamageToString() //Monk overrides for different fist damage
        {
            string strDamage;
            int totalBonus;
            if (MainHand == null)
            {
                strDamage = "d3";
                totalBonus = StrengthModifier;
            }
            else 
            {
                strDamage = MainHand.BaseDamageToString();
                if (MainHand is ProjectileWeapon)
                {
                    totalBonus = MainHand.Bonus;
                }
                else // if melee or thrown
                {
                    totalBonus = MainHand.Bonus + StrengthModifier;
                }
            }
            if (totalBonus > 0)
                {
                    strDamage += " +" + totalBonus;
                }
                else if (totalBonus < 0)
                {
                    strDamage += " " + totalBonus;
                }
            return strDamage;
        }

        // END ToSTRING FUNCTIONS______________________________

        private int AbilityMod(int ability)
        {
            return (ability / 2) - 5;
        }
    } // class

    public class Barbarian : Character
    {
        public Barbarian(Character c)
        {
            ConstructCharacter(c.Name, c.Race, c.Gender, c.OrderAlignment, c.MoralAlignment, c.Strength, c.Dexterity,
                c.Constitution, c.Intelligence, c.Wisdom, c.Charisma);
            baseHP = 12;
            currentHP = HitPoints;
            for (int i = 1; i <= 3; i++)
            {
                charGold += Dice.d6();
            }
            charGold *= 10;
        }

        public override string ToString()
        {
            return base.ToString() + " Barbarian";
        }

        protected override void AddHitPoints()
        {
            baseHP += 12;
            currentHP += 12 + ConstitutionModifier;
        }

        public override int BaseAttackBonus
        {
            get
            {
                return Level;
            }
        }

        public override int BaseFortSave
        {
            get { return (Level / 2) + 2; }
        }
    }

    public class Bard : Character
    {
        public Bard(Character c)
        {
            ConstructCharacter(c.Name, c.Race, c.Gender, c.OrderAlignment, c.MoralAlignment, c.Strength, c.Dexterity,
                c.Constitution, c.Intelligence, c.Wisdom, c.Charisma);
            baseHP = 8;
            currentHP = HitPoints;
            for (int i = 1; i <= 3; i++)
            {
                charGold += Dice.d6();
            }
            charGold *= 10;
        }

        public override string ToString()
        {
            return base.ToString() + " Bard";
        }

        protected override void AddHitPoints()
        {
            baseHP += 8;
            currentHP += 8 + ConstitutionModifier;
        }

        public override int BaseAttackBonus
        {
            get
            {
                return (Level * 3) / 4;
            }
        }

        public override int BaseWillSave
        {
            get { return (Level / 2) + 2; }
        }

        public override int BaseRefSave
        {
            get { return (Level / 2) + 2; }
        }
    }

    public class Cleric : Character
    {
        public Cleric(Character c)
        {
            ConstructCharacter(c.Name, c.Race, c.Gender, c.OrderAlignment, c.MoralAlignment, c.Strength, c.Dexterity,
                c.Constitution, c.Intelligence, c.Wisdom, c.Charisma);
            baseHP = 8;
            currentHP = HitPoints;
            for (int i = 1; i <= 4; i++)
            {
                charGold += Dice.d6();
            }
            charGold *= 10;
        }

        public override string ToString()
        {
            return base.ToString() + " Cleric";
        }

        protected override void AddHitPoints()
        {
            baseHP += 8;
            currentHP += 8 + ConstitutionModifier;
        }

        public override int BaseAttackBonus
        {
            get
            {
                return (Level * 3) / 4;
            }
        }

        public override int BaseWillSave
        {
            get { return (Level / 2) + 2; }
        }

        public override int BaseFortSave
        {
            get { return (Level / 2) + 2; }
        }
    }

    public class Druid : Character
    {
        public Druid(Character c)
        {
            ConstructCharacter(c.Name, c.Race, c.Gender, c.OrderAlignment, c.MoralAlignment, c.Strength, c.Dexterity,
                c.Constitution, c.Intelligence, c.Wisdom, c.Charisma);
            baseHP = 8;
            currentHP = HitPoints;
            charGold = Dice.d6() + Dice.d6();
            charGold *= 10;
        }

        public override string ToString()
        {
            return base.ToString() + " Druid";
        }

        protected override void AddHitPoints()
        {
            baseHP += 8;
            currentHP += 8 + ConstitutionModifier;
        }

        public override int BaseAttackBonus
        {
            get
            {
                return (Level * 3) / 4;
            }
        }

        public override int BaseWillSave
        {
            get { return (Level / 2) + 2; }
        }

        public override int BaseFortSave
        {
            get { return (Level / 2) + 2; }
        }
    }

    public class Fighter : Character
    {
        public Fighter(Character c)
        {
            ConstructCharacter(c.Name, c.Race, c.Gender, c.OrderAlignment, c.MoralAlignment, c.Strength, c.Dexterity,
                c.Constitution, c.Intelligence, c.Wisdom, c.Charisma);
            baseHP = 10;
            currentHP = HitPoints;
            for (int i = 1; i <= 5; i++)
            {
                charGold += Dice.d6();
            }
            charGold *= 10;
        }

        public override string ToString()
        {
            return base.ToString() + " Fighter";
        }

        protected override void AddHitPoints()
        {
            baseHP += 10;
            currentHP += 10 + ConstitutionModifier;
        }

        public override int BaseAttackBonus
        {
            get
            {
                return Level;
            }
        }

        public override int BaseFortSave
        {
            get { return (Level / 2) + 2; }
        }
    }

    public class Monk : Character
    {
        public Monk(Character c)
        {
            ConstructCharacter(c.Name, c.Race, c.Gender, c.OrderAlignment, c.MoralAlignment, c.Strength, c.Dexterity,
                c.Constitution, c.Intelligence, c.Wisdom, c.Charisma);
            baseHP = 8;
            currentHP = HitPoints;
            charGold = Dice.d6();
            charGold *= 10;
        }

        public override string ToString()
        {
            return base.ToString() + " Monk";
        }

        protected override void AddHitPoints()
        {
            baseHP += 8;
            currentHP += 8 + ConstitutionModifier;
        }

        public override int BaseAttackBonus
        {
            get
            {
                return (Level * 3) / 4;
            }
        }

        public override int BaseWillSave
        {
            get { return (Level / 2) + 2; }
        }

        public override int BaseRefSave
        {
            get { return (Level / 2) + 2; }
        }

        public override int BaseFortSave
        {
            get { return (Level / 2) + 2; }
        }
    }

    public class Paladin : Character
    {
        public Paladin(Character c)
        {
            ConstructCharacter(c.Name, c.Race, c.Gender, c.OrderAlignment, c.MoralAlignment, c.Strength, c.Dexterity,
                c.Constitution, c.Intelligence, c.Wisdom, c.Charisma);
            baseHP = 10;
            currentHP = HitPoints;
            for (int i = 1; i <= 5; i++)
            {
                charGold += Dice.d6();
            }
            charGold *= 10;
        }

        public override string ToString()
        {
            return base.ToString() + " Paladin";
        }

        protected override void AddHitPoints()
        {
            baseHP += 10;
            currentHP += 10 + ConstitutionModifier;
        }

        public override int BaseAttackBonus
        {
            get
            {
                return Level;
            }
        }

        public override int BaseWillSave
        {
            get { return (Level / 2) + 2; }
        }

        public override int BaseFortSave
        {
            get { return (Level / 2) + 2; }
        }
    }

    public class Ranger : Character
    {
        public Ranger(Character c)
        {
            ConstructCharacter(c.Name, c.Race, c.Gender, c.OrderAlignment, c.MoralAlignment, c.Strength, c.Dexterity,
                c.Constitution, c.Intelligence, c.Wisdom, c.Charisma);
            baseHP = 10;
            currentHP = HitPoints;
            for (int i = 1; i <= 5; i++)
            {
                charGold += Dice.d6();
            }
            charGold *= 10;
        }

        public override string ToString()
        {
            return base.ToString() + " Ranger";
        }

        protected override void AddHitPoints()
        {
            baseHP += 10;
            currentHP += 10 + ConstitutionModifier;
        }

        public override int BaseAttackBonus
        {
            get
            {
                return Level;
            }
        }

        public override int BaseRefSave
        {
            get { return (Level / 2) + 2; }
        }

        public override int BaseFortSave
        {
            get { return (Level / 2) + 2; }
        }
    }

    public class Rogue : Character
    {
        public Rogue(Character c)
        {
            ConstructCharacter(c.Name, c.Race, c.Gender, c.OrderAlignment, c.MoralAlignment, c.Strength, c.Dexterity,
                c.Constitution, c.Intelligence, c.Wisdom, c.Charisma);
            baseHP = 8;
            currentHP = HitPoints;
            for (int i = 1; i <= 4; i++)
            {
                charGold += Dice.d6();
            }
            charGold *= 10;
        }

        public override string ToString()
        {
            return base.ToString() + " Rogue";
        }

        protected override void AddHitPoints()
        {
            baseHP += 8;
            currentHP += 8 + ConstitutionModifier;
        }

        public override int BaseAttackBonus
        {
            get
            {
                return (Level * 3) / 4;
            }
        }

        public override int BaseRefSave
        {
            get { return (Level / 2) + 2; }
        }
    }

    public class Sorcerer : Character
    {
        public Sorcerer(Character c)
        {
            ConstructCharacter(c.Name, c.Race, c.Gender, c.OrderAlignment, c.MoralAlignment, c.Strength, c.Dexterity,
                c.Constitution, c.Intelligence, c.Wisdom, c.Charisma);
            currentHP = HitPoints;
            charGold = Dice.d6() + Dice.d6();
            charGold *= 10;
        }

        public override string ToString()
        {
            return base.ToString() + " Sorcerer";
        }

        public override int BaseWillSave
        {
            get { return (Level / 2) + 2; }
        }
    }

    public class Wizard : Character
    {
        public Wizard(Character c)
        {
            ConstructCharacter(c.Name, c.Race, c.Gender, c.OrderAlignment, c.MoralAlignment, c.Strength, c.Dexterity,
                c.Constitution, c.Intelligence, c.Wisdom, c.Charisma);
            currentHP = HitPoints;
            charGold = Dice.d6() + Dice.d6();
            charGold *= 10;
        }

        public override string ToString()
        {
            return base.ToString() + " Wizard";
        }

        public override int BaseWillSave
        {
            get { return (Level / 2) + 2; }
        }
    }
} // namespace
