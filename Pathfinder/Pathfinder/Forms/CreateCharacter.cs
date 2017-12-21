using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Pathfinder.Properties;

namespace Pathfinder
{
    public partial class CreateCharacter : Form
    {
        public Character newCharacter;
        private int str, dex, con, intel, wis, cha;
        private int baseStr, baseDex, baseCon, baseInt, baseWis, baseCha;
        private int strMod, dexMod, conMod, intMod, wisMod, chaMod;
        private int points;
        private bool validAlign, validName;

        public CreateCharacter()
        {
            InitializeComponent();
        }

        private void CreateCharacter_Load(object sender, EventArgs e)
        {
            resetScores();
        }

        private void cmbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            string race;
            race = Convert.ToString(cmbRace.Text);

            grpBody.Visible = true;
            resetScores();
            racialTraitSelectable();

            switch (race)
            {
                case "Dwarf":
                    conMod = 2;
                    wisMod = 2;
                    chaMod = -2;
                    break;
                case "Elf":
                    dexMod = 2;
                    conMod = -2;
                    intMod = 2;
                    break;
                case "Gnome":
                    strMod = -2;
                    conMod = 2;
                    chaMod = 2;
                    break;
                case "Halfling":
                    strMod = -2;
                    dexMod = 2;
                    chaMod = 2;
                    break;
            }

            addRacialMod();
            updateScores();
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            createButtonEnabled();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            validateAlignment();
        }

        private void cmbOrderAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            validateAlignment();
        }

        private void cmbMoralAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            validateAlignment();
        }

        private void updStrength_ValueChanged(object sender, EventArgs e)
        {
            int newStr = Convert.ToInt32(updStrength.Value);
            int pointAdj;

            pointAdj = adjustPoints(baseStr, newStr);

            points += pointAdj;
            baseStr = newStr;
            str = newStr + strMod;

            updateScores();
            createButtonEnabled();
        }

        private void updDexterity_ValueChanged(object sender, EventArgs e)
        {
            int newDex = Convert.ToInt32(updDexterity.Value);
            int pointAdj;

            pointAdj = adjustPoints(baseDex, newDex);

            points += pointAdj;
            baseDex = newDex;
            dex = newDex + dexMod;

            updateScores();
            createButtonEnabled();
        }

        private void updConstitution_ValueChanged(object sender, EventArgs e)
        {
            int newCon = Convert.ToInt32(updConstitution.Value);
            int pointAdj;

            pointAdj = adjustPoints(baseCon, newCon);

            points += pointAdj;
            baseCon = newCon;
            con = newCon + conMod;

            updateScores();
            createButtonEnabled();
        }

        private void updIntelligence_ValueChanged(object sender, EventArgs e)
        {
            int newInt = Convert.ToInt32(updIntelligence.Value);
            int pointAdj;

            pointAdj = adjustPoints(baseInt, newInt);

            points += pointAdj;
            baseInt = newInt;
            intel = newInt + intMod;

            updateScores();
            createButtonEnabled();
        }

        private void updWisdom_ValueChanged(object sender, EventArgs e)
        {
            int newWis = Convert.ToInt32(updWisdom.Value);
            int pointAdj;

            pointAdj = adjustPoints(baseWis, newWis);

            points += pointAdj;
            baseWis = newWis;
            wis = newWis + wisMod;

            updateScores();
            createButtonEnabled();
        }

        private void updCharisma_ValueChanged(object sender, EventArgs e)
        {
            int newCha = Convert.ToInt32(updCharisma.Value);
            int pointAdj;

            pointAdj = adjustPoints(baseCha, newCha);

            points += pointAdj;
            baseCha = newCha;
            cha = newCha + chaMod;

            updateScores();
            createButtonEnabled();
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            strMod = 0;
            dexMod = 0;
            conMod = 0;
            intMod = 0;
            wisMod = 0;
            chaMod = 0;

            if (radStr.Checked)
            {
                strMod = 2;
            }
            else if (radDex.Checked)
            {
                dexMod = 2;
            }
            else if (radCon.Checked)
            {
                conMod = 2;
            }
            else if (radInt.Checked)
            {
                intMod = 2;
            }
            else if (radWis.Checked)
            {
                wisMod = 2;
            }
            else if (radCha.Checked)
            {
                chaMod = 2;
            }

            addRacialMod();
            updateScores();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            validateName();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Character.Races race = (Character.Races)cmbRace.SelectedIndex;
            Character.Genders gender = (Character.Genders)cmbGender.SelectedIndex;
            Character.Orders order = (Character.Orders)cmbOrderAlign.SelectedIndex;
            Character.Morals moral = (Character.Morals)cmbMoralAlign.SelectedIndex;
            string name = txtName.Text;
            newCharacter = new Character(name, race, gender, order, moral, str, dex, con, intel, wis, cha);
            switch (cmbClass.Text)
            {
                case "Barbarian":
                    newCharacter = new Barbarian(newCharacter);
                    break;
                case "Bard":
                    newCharacter = new Bard(newCharacter);
                    break;
                case "Cleric":
                    newCharacter = new Cleric(newCharacter);
                    break;
                case "Druid":
                    newCharacter = new Druid(newCharacter);
                    break;
                case "Fighter":
                    newCharacter = new Fighter(newCharacter);
                    break;
                case "Monk":
                    newCharacter = new Monk(newCharacter);
                    break;
                case "Paladin":
                    newCharacter = new Paladin(newCharacter);
                    break;
                case "Ranger":
                    newCharacter = new Ranger(newCharacter);
                    break;
                case "Rogue":
                    newCharacter = new Rogue(newCharacter);
                    break;
                case "Sorcerer":
                    newCharacter = new Sorcerer(newCharacter);
                    break;
                case "Wizard":
                    newCharacter = new Wizard(newCharacter);
                    break;
            }
            //MessageBox.Show(newCharacter.ToString() + "\n" + newCharacter.CharInfoToString());
            Forms.CharacterPortrait cPortrait = new Forms.CharacterPortrait();
            cPortrait.Show();
            this.Hide();
        }

        private void resetScores()
        {
            str = 10;
            dex = 10;
            con = 10;
            intel = 10;
            wis = 10;
            cha = 10;

            baseStr = 10;
            baseDex = 10;
            baseCon = 10;
            baseInt = 10;
            baseWis = 10;
            baseCha = 10;

            strMod = 0;
            dexMod = 0;
            conMod = 0;
            intMod = 0;
            wisMod = 0;
            chaMod = 0;

            points = 15;
        }

        private void racialTraitSelectable()
        {
            string race;
            race = Convert.ToString(cmbRace.Text);

            switch (race)
            {
                case "Half-elf":
                case "Half-orc":
                case "Human":
                    radStr.Visible = true;
                    radDex.Visible = true;
                    radCon.Visible = true;
                    radInt.Visible = true;
                    radWis.Visible = true;
                    radCha.Visible = true;

                    radStr.Checked = false;
                    radDex.Checked = false;
                    radCon.Checked = false;
                    radInt.Checked = false;
                    radWis.Checked = false;
                    radCha.Checked = false;
                    break;
                default:
                    radStr.Visible = false;
                    radDex.Visible = false;
                    radCon.Visible = false;
                    radInt.Visible = false;
                    radWis.Visible = false;
                    radCha.Visible = false;
                    break;
            }
        }

        private void addRacialMod()
        {
            str = baseStr + strMod;
            dex = baseDex + dexMod;
            con = baseCon + conMod;
            intel = baseInt + intMod;
            wis = baseWis + wisMod;
            cha = baseCha + chaMod;
        }

        private void updateScores()
        {
            lblStrMod.Text = Convert.ToString(strMod);
            lblDexMod.Text = Convert.ToString(dexMod);
            lblConMod.Text = Convert.ToString(conMod);
            lblIntMod.Text = Convert.ToString(intMod);
            lblWisMod.Text = Convert.ToString(wisMod);
            lblChaMod.Text = Convert.ToString(chaMod);

            lblAdjStr.Text = Convert.ToString(str);
            lblAdjDex.Text = Convert.ToString(dex);
            lblAdjCon.Text = Convert.ToString(con);
            lblAdjInt.Text = Convert.ToString(intel);
            lblAdjWis.Text = Convert.ToString(wis);
            lblAdjCha.Text = Convert.ToString(cha);

            lblPointsVal.Text = Convert.ToString(points);
        }

        private void createButtonEnabled()
        {
            if (points >= 0 && validAlign && validName && cmbRace.Text != "" && cmbClass.Text != ""
            && cmbGender.Text != "" && cmbOrderAlign.Text != "" && cmbMoralAlign.Text != "" && txtName.Text != "")
            {
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
            }
        }

        private void validateAlignment()
        {
            string errorMessage = "";
            validAlign = true;
            switch (cmbClass.Text)
            {
                case "Barbarian":  // non-lawful alignment
                    if (cmbOrderAlign.Text == "Lawful")
                    {
                        errorMessage = "Barbarian class restricted to any non-lawful alignment";
                        validAlign = false;
                    }
                    break;
                case "Druid":   // any neutral
                    if (cmbOrderAlign.Text != "Neutral" && cmbMoralAlign.Text != "Neutral")
                    {
                        errorMessage = "Druid class restricted to any neutral alignment";
                        validAlign = false;
                    }
                    break;
                case "Monk":    // any lawful
                    if (cmbOrderAlign.Text != "Lawful")
                    {
                        errorMessage = "Monk class restricted to any lawful alignment";
                        validAlign = false;
                    }
                    break;
                case "Paladin": // lawful good only
                    if (cmbOrderAlign.Text != "Lawful" || cmbMoralAlign.Text != "Good")
                    {
                        errorMessage = "Paladin class restricted to lawful good alignment";
                        validAlign = false;
                    }
                    break;
            }
            lblAlignError.Text = errorMessage;
            createButtonEnabled();
        }

        private void validateName()
        {
            if (Regex.IsMatch(txtName.Text, @"(\d|\W)"))
            {
                lblNameError.Text = "Name must contain only letters";
                validName = false;
            }
            else
            {
                lblNameError.Text = "";
                validName = true;
            }
            createButtonEnabled();
        }

        private int adjustPoints(int baseVal, int newVal)
        {
            int pointAdj = 0;

            if (newVal - baseVal > 0) //Attribute increase
            {
                pointAdj = attributeIncrease(newVal);
            }
            else if (newVal - baseVal < 0) //Attribute decrease
            {
                pointAdj = attributeDecrease(newVal);
            }
            return pointAdj;
        }

        private int attributeIncrease(int val)
        {
            int pointAdj = 0;

            switch (val)
            {
                case 8:
                    pointAdj = -2;
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    pointAdj = -1;
                    break;
                case 14:
                case 15:
                    pointAdj = -2;
                    break;
                case 16:
                case 17:
                    pointAdj = -3;
                    break;
                case 18:
                    pointAdj = -4;
                    break;
            }
            return pointAdj;
        }

        private int attributeDecrease(int val)
        {
            int pointAdj = 0;

            switch (val)
            {
                case 7:
                    pointAdj = 2;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    pointAdj = 1;
                    break;
                case 13:
                case 14:
                    pointAdj = 2;
                    break;
                case 15:
                case 16:
                    pointAdj = 3;
                    break;
                case 17:
                    pointAdj = 4;
                    break;
            }
            return pointAdj;
        }

    } // partial class
} // namespace


