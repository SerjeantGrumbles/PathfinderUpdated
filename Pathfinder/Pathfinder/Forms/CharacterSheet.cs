using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pathfinder.Properties;

namespace Pathfinder
{
    public partial class CharacterSheet : Form
    {
        CreateCharacter createChar; /* references the createChar starting form */
        public Character playerCharacter;
        private PictureBox[,] invPics = new PictureBox[3,13];
        private PictureBox currentSource;
        public CharacterSheet()
        {
            InitializeComponent();
        }

        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            //createTestCharacter(); /* used to bypass the normal character creation process */
            playerCharacter.StartingInventory(); /* populate inventory with test items */
            // ensures that the createChar object is correctly cast as the starting form
            int i = 0;
            while (createChar == null)
            {
                if (Application.OpenForms[i] is CreateCharacter)
                {
                    createChar = (CreateCharacter)Application.OpenForms[i];
                }
                else
                {
                    i++;
                }
            }
            /**** Profile *****/
            picPortrait.Image = playerCharacter.Portrait;
            boxStr.Text = Convert.ToString(playerCharacter.Strength);
            boxDex.Text = Convert.ToString(playerCharacter.Dexterity);
            boxCon.Text = Convert.ToString(playerCharacter.Constitution);
            boxInt.Text = Convert.ToString(playerCharacter.Intelligence);
            boxWis.Text = Convert.ToString(playerCharacter.Wisdom);
            boxCha.Text = Convert.ToString(playerCharacter.Charisma);
            lblCharName.Text = playerCharacter.ToString();
            lblCharInfo.Text = playerCharacter.CharInfoToString();
            boxExp.Text = playerCharacter.ExperienceToString();
            boxHP.Text = playerCharacter.HitPointsToString();
            boxWillSave.Text = playerCharacter.WillSaveToString();
            boxRefSave.Text = playerCharacter.RefSaveToString();
            boxFortSave.Text = playerCharacter.FortSaveToString();
            updateArmour();
            updatePlayerAttack();
            /**** Inventory *****/
            boxGold.Text = String.Format("{0:N0}", playerCharacter.Gold);
            generateInventoryPics();
            //initWeaponPics();
            //Allow drop for equipped item slots
            picMainHand.AllowDrop = true;
            picArmour.AllowDrop = true;
        }

        private void btnAddExp_Click(object sender, EventArgs e)
        {
            int xp = Convert.ToInt32(updAddExp.Text);

            playerCharacter.AddExperience(xp);
            lblCharName.Text = playerCharacter.ToString();
            boxExp.Text = playerCharacter.ExperienceToString();
            boxHP.Text = playerCharacter.HitPointsToString();
            boxAP.Text = playerCharacter.AttackToString();
            boxWillSave.Text = playerCharacter.WillSaveToString();
            boxRefSave.Text = playerCharacter.RefSaveToString();
            boxFortSave.Text = playerCharacter.FortSaveToString();
            boxGold.Text = String.Format("{0:N0}", playerCharacter.Gold);
            toggleVisibleAddPoints();
        }

        private void btnAddStr_Click(object sender, EventArgs e)
        {
            playerCharacter.AddStrength();
            boxStr.Text = Convert.ToString(playerCharacter.Strength);
            updatePlayerAttack();
            toggleVisibleAddPoints();
        }

        private void btnAddDex_Click(object sender, EventArgs e)
        {
            playerCharacter.AddDexterity();
            boxDex.Text = Convert.ToString(playerCharacter.Dexterity);           
            boxRefSave.Text = playerCharacter.RefSaveToString();
            updateArmour();
            toggleVisibleAddPoints();
        }

        private void btnAddCon_Click(object sender, EventArgs e)
        {
            playerCharacter.AddConstitution();
            boxCon.Text = Convert.ToString(playerCharacter.Constitution);
            boxHP.Text = playerCharacter.HitPointsToString();
            boxFortSave.Text = playerCharacter.FortSaveToString();
            toggleVisibleAddPoints();
        }

        private void btnAddInt_Click(object sender, EventArgs e)
        {
            playerCharacter.AddIntelligence();
            boxInt.Text = Convert.ToString(playerCharacter.Intelligence);
            toggleVisibleAddPoints();
        }

        private void btnAddWis_Click(object sender, EventArgs e)
        {
            playerCharacter.AddWisdom();
            boxWis.Text = Convert.ToString(playerCharacter.Wisdom);
            boxWillSave.Text = playerCharacter.WillSaveToString();
            toggleVisibleAddPoints();
        }

        private void btnAddCha_Click(object sender, EventArgs e)
        {
            playerCharacter.AddCharisma();
            boxCha.Text = Convert.ToString(playerCharacter.Charisma);
            toggleVisibleAddPoints();
        }

        /*private void invPic_Click(object sender, EventArgs e)
        {
            PictureBox currentPic = (PictureBox)sender;
            int i = Convert.ToInt32(currentPic.Name.Substring(6, 1));
            int j = Convert.ToInt32(currentPic.Name.Substring(8, currentPic.Name.Length - 8));
            MessageBox.Show(String.Format("{0}\n{1}\n{2}", currentPic.Name, "Row: " + i, "Column: " + j));
        }*/

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentSource = (PictureBox)sender;
                currentSource.DoDragDrop(currentSource.Image, DragDropEffects.Move);
            }
        }

        private void pic_DragEnter(object sender, DragEventArgs e)
        {
            // See if this is a copy and the data includes an image.
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
                (e.AllowedEffect & DragDropEffects.Move) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                // Don't allow any other drop.
                e.Effect = DragDropEffects.None;
            }
        }

        private void pic_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox currentTarget = (PictureBox)sender;
            if (currentSource.Name.Contains("invPic"))
            {
                int i1 = Convert.ToInt32(currentSource.Name.Substring(6, 1));
                int j1 = Convert.ToInt32(currentSource.Name.Substring(8, currentSource.Name.Length - 8));
                int i2 = Convert.ToInt32(currentTarget.Name.Substring(6, 1));
                int j2 = Convert.ToInt32(currentTarget.Name.Substring(8, currentTarget.Name.Length - 8));
                playerCharacter.SwapInventory(i1, j1, i2, j2);
                currentSource.Image = currentTarget.Image;
                currentTarget.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
                if (currentSource.Image == null)
                {
                    currentSource.MouseDown -= pic_MouseDown;
                    currentSource.MouseClick -= invPic_Click;
                    currentSource.Cursor = Cursors.Default;
                    currentTarget.MouseDown += new MouseEventHandler(pic_MouseDown);
                    currentTarget.MouseClick += new MouseEventHandler(invPic_Click);
                    currentTarget.Cursor = Cursors.Hand;
                }
            }
            else if (currentSource.Name.Contains("MainHand"))
            {
                int i = Convert.ToInt32(currentTarget.Name.Substring(6, 1));
                int j = Convert.ToInt32(currentTarget.Name.Substring(8, currentTarget.Name.Length - 8));
                playerCharacter.EquipMainHand(i, j);
                if (!playerCharacter.SuccessfulEquip)
                {
                    return;
                }
                updatePlayerAttack();
                picMainHand.Image = currentTarget.Image;
                currentTarget.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);                
                if (picMainHand.Image == null)
                {
                    picMainHand.MouseDown -= pic_MouseDown;
                    picMainHand.MouseClick -= mainHand_Click;
                    picMainHand.Cursor = Cursors.Default;
                    currentTarget.MouseDown += new MouseEventHandler(pic_MouseDown);
                    currentTarget.MouseClick += new MouseEventHandler(invPic_Click);
                    currentTarget.Cursor = Cursors.Hand;
                }
            }
            else if (currentSource.Name.Contains("Armour"))
            {
                int i = Convert.ToInt32(currentTarget.Name.Substring(6, 1));
                int j = Convert.ToInt32(currentTarget.Name.Substring(8, currentTarget.Name.Length - 8));
                playerCharacter.EquipArmour(i, j);
                if (!playerCharacter.SuccessfulEquip)
                {
                    return;
                }
                updateArmour();
                picArmour.Image = currentTarget.Image;
                currentTarget.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
                if (picArmour.Image == null)
                {
                    picArmour.MouseDown -= pic_MouseDown;
                    picArmour.MouseClick -= armour_Click;
                    picArmour.Cursor = Cursors.Default;
                    currentTarget.MouseDown += new MouseEventHandler(pic_MouseDown);
                    currentTarget.MouseClick += new MouseEventHandler(invPic_Click);
                    currentTarget.Cursor = Cursors.Hand;
                }
            }
        }

        // When you drag and drop an item (i.e. weapon) from inventory into the main hand slot
        private void mainHand_DragDrop(object sender, DragEventArgs e)
        {
            int i = Convert.ToInt32(currentSource.Name.Substring(6, 1));
            int j = Convert.ToInt32(currentSource.Name.Substring(8, currentSource.Name.Length - 8));
            playerCharacter.EquipMainHand(i, j);
            if (!playerCharacter.SuccessfulEquip)
            {
                return;
            }
            updatePlayerAttack();
            currentSource.Image = picMainHand.Image;
            picMainHand.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            if (currentSource.Image == null) /* This is not null when it should be */
            {
                currentSource.MouseDown -= pic_MouseDown;
                currentSource.MouseClick -= invPic_Click;
                currentSource.Cursor = Cursors.Default;
                picMainHand.MouseDown += new MouseEventHandler(pic_MouseDown);
                picMainHand.MouseClick += new MouseEventHandler(mainHand_Click);
                picMainHand.Cursor = Cursors.Hand;
            }
        }

        // When you drag and drop an item (armour) from inventory into the armour slot
        private void armour_DragDrop(object sender, DragEventArgs e)
        {
            int i = Convert.ToInt32(currentSource.Name.Substring(6, 1));
            int j = Convert.ToInt32(currentSource.Name.Substring(8, currentSource.Name.Length - 8));
            playerCharacter.EquipArmour(i, j);
            if (!playerCharacter.SuccessfulEquip)
            {
                return;
            }
            updateArmour();
            currentSource.Image = picArmour.Image;
            picArmour.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            if (currentSource.Image == null)
            {
                currentSource.MouseDown -= pic_MouseDown;
                currentSource.MouseClick -= invPic_Click;
                currentSource.Cursor = Cursors.Default;
                picArmour.MouseDown += new MouseEventHandler(pic_MouseDown);
                picArmour.MouseClick += new MouseEventHandler(armour_Click);
                picArmour.Cursor = Cursors.Hand;
            }
        }

        private void invPic_Click(object sender, MouseEventArgs e)
        {
            PictureBox currentPic = (PictureBox)sender;
            int i = Convert.ToInt32(currentPic.Name.Substring(6, 1));
            int j = Convert.ToInt32(currentPic.Name.Substring(8, currentPic.Name.Length - 8));
            MessageBox.Show(playerCharacter.Inventory[i, j].Name);
        }

        private void mainHand_Click(object sender, MouseEventArgs e)
        {
            MessageBox.Show(playerCharacter.MainHand.Name + "\n" + playerCharacter.MainHand.DamageToString());
        }

        private void armour_Click(object sender, MouseEventArgs e)
        {
            MessageBox.Show(playerCharacter.Armour.Name + "\n" + playerCharacter.Armour.ArmorBonus);
        }

        private void toggleVisibleAddPoints()
        {
            if (playerCharacter.AbilityPoints > 0)
            {
                btnAddStr.Visible = true;
                btnAddDex.Visible = true;
                btnAddCon.Visible = true;
                btnAddInt.Visible = true;
                btnAddWis.Visible = true;
                btnAddCha.Visible = true;
            }
            else
            {
                btnAddStr.Visible = false;
                btnAddDex.Visible = false;
                btnAddCon.Visible = false;
                btnAddInt.Visible = false;
                btnAddWis.Visible = false;
                btnAddCha.Visible = false;
            }
        }

        private void createTestCharacter()
        {
            /*playerCharacter = new Character("Nerissa", Character.Races.HalfElf, Character.Genders.Female,
                Character.Orders.Chaotic, Character.Morals.Neutral, 8, 13, 12, 14, 10, 17);
            playerCharacter = new Sorcerer(playerCharacter);
            playerCharacter.Portrait = Resources.FELSO04L;
            playerCharacter = new Character("Hluothar", Character.Races.Human, Character.Genders.Male,
                Character.Orders.Chaotic, Character.Morals.Neutral, 18, 12, 15, 9, 10, 8);
            playerCharacter = new Barbarian(playerCharacter);
            playerCharacter.Portrait = Resources.MHUBA06L;*/
            playerCharacter = new Character("Corlynna", Character.Races.Elf, Character.Genders.Female,
                Character.Orders.Chaotic, Character.Morals.Good, 15, 18, 12, 12, 13, 10);
            playerCharacter = new Ranger(playerCharacter);
            playerCharacter.Portrait = Resources.FELRA04L;
            playerCharacter.StartingInventory();
        }

        private void generateInventoryPics()
        {
            for (int i = 0; i <= invPics.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= invPics.GetUpperBound(1); j++)
                {
                    invPics[i, j] = new PictureBox();
                    invPics[i, j].BackColor = Color.Transparent;
                    invPics[i, j].BackgroundImage = Resources.BlankInventory;
                    invPics[i, j].Location = new Point(4, 4);
                    invPics[i, j].Name = "invPic" + i + "_" + j;
                    invPics[i, j].Size = new Size(44, 44);
                    invPics[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    invPics[i, j].TabIndex = 0;
                    invPics[i, j].TabStop = false;                    
                    invPics[i, j].AllowDrop = true;
                    invPics[i, j].DragEnter += new DragEventHandler(pic_DragEnter);
                    invPics[i, j].DragDrop += new DragEventHandler(pic_DragDrop);
                    if (playerCharacter.Inventory[i, j] != null)
                    {
                        invPics[i, j].Image = playerCharacter.Inventory[i, j].ThumbnailPic;
                        invPics[i, j].MouseDown += new MouseEventHandler(pic_MouseDown);
                        invPics[i, j].MouseClick += new MouseEventHandler(invPic_Click);
                        invPics[i, j].Cursor = Cursors.Hand;
                    }         
                    tableInventory.Controls.Add(invPics[i, j], j, i);
                }
            }
        }

        private void initWeaponPics()
        {
            invPics[0, 0].Image = Resources._1H_Sword;
            invPics[0, 1].Image = Resources._2H_Sword;
            invPics[0, 2].Image = Resources.Axe;
            invPics[0, 3].Image = Resources.Crossbow;
            invPics[0, 4].Image = Resources.Halberd;
            invPics[0, 5].Image = Resources.Hammer;
            invPics[0, 6].Image = Resources.Mace;
            invPics[0, 7].Image = Resources.Staff;
            for (int i = 0; i <= 7; i++)
            {
                invPics[0, i].MouseDown += new MouseEventHandler(pic_MouseDown);
                invPics[0, i].Cursor = Cursors.Hand;
            }
        }

        private void updatePlayerAttack()
        {
            boxAP.Text = playerCharacter.AttackToString();
            if (playerCharacter.MainHand == null)
            {
                boxDmg.Text = "Fist";
            }
            else
            {
                boxDmg.Text = playerCharacter.MainHand.Name;
            }
            boxDmg.Text += ": \n" + playerCharacter.DamageToString();
        }

        private void updateArmour()
        {
            if (playerCharacter.Armour == null)
            {
                boxAC.Text = "Unarmoured";
            }
            else
            {
                boxAC.Text = playerCharacter.Armour.Name;
            }
            boxAC.Text += ": \n" + Convert.ToString(playerCharacter.ArmorClass);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            createChar.Show();
        }
    }
}
