namespace Pathfinder
{
    partial class CharacterSheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.updAddExp = new System.Windows.Forms.NumericUpDown();
            this.btnAddExp = new System.Windows.Forms.Button();
            this.tabCharacter = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.boxFortSave = new System.Windows.Forms.Label();
            this.boxRefSave = new System.Windows.Forms.Label();
            this.boxWillSave = new System.Windows.Forms.Label();
            this.lblFortSave = new System.Windows.Forms.Label();
            this.lblRefSave = new System.Windows.Forms.Label();
            this.lblWillSave = new System.Windows.Forms.Label();
            this.picPortrait = new System.Windows.Forms.PictureBox();
            this.boxDmg = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.boxAP = new System.Windows.Forms.Label();
            this.lblAttackBonus = new System.Windows.Forms.Label();
            this.boxAC = new System.Windows.Forms.Label();
            this.lblArmorClass = new System.Windows.Forms.Label();
            this.boxHP = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.btnAddCha = new System.Windows.Forms.Button();
            this.btnAddWis = new System.Windows.Forms.Button();
            this.btnAddInt = new System.Windows.Forms.Button();
            this.btnAddCon = new System.Windows.Forms.Button();
            this.btnAddDex = new System.Windows.Forms.Button();
            this.btnAddStr = new System.Windows.Forms.Button();
            this.boxExp = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblCharName = new System.Windows.Forms.Label();
            this.lblCharInfo = new System.Windows.Forms.Label();
            this.boxCha = new System.Windows.Forms.Label();
            this.boxWis = new System.Windows.Forms.Label();
            this.boxInt = new System.Windows.Forms.Label();
            this.boxCon = new System.Windows.Forms.Label();
            this.boxDex = new System.Windows.Forms.Label();
            this.boxStr = new System.Windows.Forms.Label();
            this.lblCharisma = new System.Windows.Forms.Label();
            this.lblWisdom = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblConstitution = new System.Windows.Forms.Label();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.lblArmour = new System.Windows.Forms.Label();
            this.lblOffHand = new System.Windows.Forms.Label();
            this.lblMainHand = new System.Windows.Forms.Label();
            this.picArmour = new System.Windows.Forms.PictureBox();
            this.picOffHand = new System.Windows.Forms.PictureBox();
            this.picMainHand = new System.Windows.Forms.PictureBox();
            this.picScaleIcon = new System.Windows.Forms.PictureBox();
            this.boxWeight = new System.Windows.Forms.Label();
            this.boxGold = new System.Windows.Forms.Label();
            this.picGoldIcon = new System.Windows.Forms.PictureBox();
            this.tableInventory = new System.Windows.Forms.TableLayoutPanel();
            this.tabSpells = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.updAddExp)).BeginInit();
            this.tabCharacter.SuspendLayout();
            this.tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortrait)).BeginInit();
            this.tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArmour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScaleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoldIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(645, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // updAddExp
            // 
            this.updAddExp.Location = new System.Drawing.Point(483, 12);
            this.updAddExp.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.updAddExp.Name = "updAddExp";
            this.updAddExp.Size = new System.Drawing.Size(75, 20);
            this.updAddExp.TabIndex = 65;
            // 
            // btnAddExp
            // 
            this.btnAddExp.Location = new System.Drawing.Point(564, 12);
            this.btnAddExp.Name = "btnAddExp";
            this.btnAddExp.Size = new System.Drawing.Size(75, 23);
            this.btnAddExp.TabIndex = 64;
            this.btnAddExp.Text = "Add Exp";
            this.btnAddExp.UseVisualStyleBackColor = true;
            this.btnAddExp.Click += new System.EventHandler(this.btnAddExp_Click);
            // 
            // tabCharacter
            // 
            this.tabCharacter.Controls.Add(this.tabProfile);
            this.tabCharacter.Controls.Add(this.tabInventory);
            this.tabCharacter.Controls.Add(this.tabSpells);
            this.tabCharacter.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCharacter.Location = new System.Drawing.Point(12, 45);
            this.tabCharacter.Name = "tabCharacter";
            this.tabCharacter.SelectedIndex = 0;
            this.tabCharacter.Size = new System.Drawing.Size(720, 655);
            this.tabCharacter.TabIndex = 90;
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.tabProfile.Controls.Add(this.boxFortSave);
            this.tabProfile.Controls.Add(this.boxRefSave);
            this.tabProfile.Controls.Add(this.boxWillSave);
            this.tabProfile.Controls.Add(this.lblFortSave);
            this.tabProfile.Controls.Add(this.lblRefSave);
            this.tabProfile.Controls.Add(this.lblWillSave);
            this.tabProfile.Controls.Add(this.picPortrait);
            this.tabProfile.Controls.Add(this.boxDmg);
            this.tabProfile.Controls.Add(this.lblDamage);
            this.tabProfile.Controls.Add(this.boxAP);
            this.tabProfile.Controls.Add(this.lblAttackBonus);
            this.tabProfile.Controls.Add(this.boxAC);
            this.tabProfile.Controls.Add(this.lblArmorClass);
            this.tabProfile.Controls.Add(this.boxHP);
            this.tabProfile.Controls.Add(this.lblHitPoints);
            this.tabProfile.Controls.Add(this.btnAddCha);
            this.tabProfile.Controls.Add(this.btnAddWis);
            this.tabProfile.Controls.Add(this.btnAddInt);
            this.tabProfile.Controls.Add(this.btnAddCon);
            this.tabProfile.Controls.Add(this.btnAddDex);
            this.tabProfile.Controls.Add(this.btnAddStr);
            this.tabProfile.Controls.Add(this.boxExp);
            this.tabProfile.Controls.Add(this.lblExperience);
            this.tabProfile.Controls.Add(this.lblCharName);
            this.tabProfile.Controls.Add(this.lblCharInfo);
            this.tabProfile.Controls.Add(this.boxCha);
            this.tabProfile.Controls.Add(this.boxWis);
            this.tabProfile.Controls.Add(this.boxInt);
            this.tabProfile.Controls.Add(this.boxCon);
            this.tabProfile.Controls.Add(this.boxDex);
            this.tabProfile.Controls.Add(this.boxStr);
            this.tabProfile.Controls.Add(this.lblCharisma);
            this.tabProfile.Controls.Add(this.lblWisdom);
            this.tabProfile.Controls.Add(this.lblIntelligence);
            this.tabProfile.Controls.Add(this.lblConstitution);
            this.tabProfile.Controls.Add(this.lblDexterity);
            this.tabProfile.Controls.Add(this.lblStrength);
            this.tabProfile.Location = new System.Drawing.Point(4, 21);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(712, 630);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile";
            // 
            // boxFortSave
            // 
            this.boxFortSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxFortSave.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFortSave.ForeColor = System.Drawing.Color.Black;
            this.boxFortSave.Location = new System.Drawing.Point(584, 154);
            this.boxFortSave.Name = "boxFortSave";
            this.boxFortSave.Size = new System.Drawing.Size(47, 20);
            this.boxFortSave.TabIndex = 124;
            this.boxFortSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxRefSave
            // 
            this.boxRefSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxRefSave.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxRefSave.ForeColor = System.Drawing.Color.Black;
            this.boxRefSave.Location = new System.Drawing.Point(584, 124);
            this.boxRefSave.Name = "boxRefSave";
            this.boxRefSave.Size = new System.Drawing.Size(47, 20);
            this.boxRefSave.TabIndex = 123;
            this.boxRefSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxWillSave
            // 
            this.boxWillSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxWillSave.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxWillSave.ForeColor = System.Drawing.Color.Black;
            this.boxWillSave.Location = new System.Drawing.Point(584, 94);
            this.boxWillSave.Name = "boxWillSave";
            this.boxWillSave.Size = new System.Drawing.Size(47, 20);
            this.boxWillSave.TabIndex = 122;
            this.boxWillSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFortSave
            // 
            this.lblFortSave.AutoSize = true;
            this.lblFortSave.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFortSave.ForeColor = System.Drawing.Color.Black;
            this.lblFortSave.Location = new System.Drawing.Point(462, 154);
            this.lblFortSave.Name = "lblFortSave";
            this.lblFortSave.Size = new System.Drawing.Size(100, 12);
            this.lblFortSave.TabIndex = 121;
            this.lblFortSave.Text = "Fortitude Save:";
            // 
            // lblRefSave
            // 
            this.lblRefSave.AutoSize = true;
            this.lblRefSave.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefSave.ForeColor = System.Drawing.Color.Black;
            this.lblRefSave.Location = new System.Drawing.Point(462, 124);
            this.lblRefSave.Name = "lblRefSave";
            this.lblRefSave.Size = new System.Drawing.Size(80, 12);
            this.lblRefSave.TabIndex = 120;
            this.lblRefSave.Text = "Reflex Save:";
            // 
            // lblWillSave
            // 
            this.lblWillSave.AutoSize = true;
            this.lblWillSave.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWillSave.ForeColor = System.Drawing.Color.Black;
            this.lblWillSave.Location = new System.Drawing.Point(462, 94);
            this.lblWillSave.Name = "lblWillSave";
            this.lblWillSave.Size = new System.Drawing.Size(67, 12);
            this.lblWillSave.TabIndex = 119;
            this.lblWillSave.Text = "Will Save:";
            // 
            // picPortrait
            // 
            this.picPortrait.BackColor = System.Drawing.Color.Transparent;
            this.picPortrait.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPortrait.Location = new System.Drawing.Point(218, 79);
            this.picPortrait.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picPortrait.Name = "picPortrait";
            this.picPortrait.Size = new System.Drawing.Size(201, 330);
            this.picPortrait.TabIndex = 118;
            this.picPortrait.TabStop = false;
            // 
            // boxDmg
            // 
            this.boxDmg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxDmg.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDmg.ForeColor = System.Drawing.Color.Black;
            this.boxDmg.Location = new System.Drawing.Point(528, 547);
            this.boxDmg.Name = "boxDmg";
            this.boxDmg.Size = new System.Drawing.Size(149, 41);
            this.boxDmg.TabIndex = 117;
            this.boxDmg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamage.ForeColor = System.Drawing.Color.Black;
            this.lblDamage.Location = new System.Drawing.Point(526, 524);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(52, 12);
            this.lblDamage.TabIndex = 116;
            this.lblDamage.Text = "Damage";
            // 
            // boxAP
            // 
            this.boxAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxAP.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAP.ForeColor = System.Drawing.Color.Black;
            this.boxAP.Location = new System.Drawing.Point(528, 488);
            this.boxAP.Name = "boxAP";
            this.boxAP.Size = new System.Drawing.Size(149, 20);
            this.boxAP.TabIndex = 115;
            this.boxAP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAttackBonus
            // 
            this.lblAttackBonus.AutoSize = true;
            this.lblAttackBonus.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttackBonus.ForeColor = System.Drawing.Color.Black;
            this.lblAttackBonus.Location = new System.Drawing.Point(526, 466);
            this.lblAttackBonus.Name = "lblAttackBonus";
            this.lblAttackBonus.Size = new System.Drawing.Size(89, 12);
            this.lblAttackBonus.TabIndex = 114;
            this.lblAttackBonus.Text = "Attack Bonus";
            // 
            // boxAC
            // 
            this.boxAC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxAC.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAC.ForeColor = System.Drawing.Color.Black;
            this.boxAC.Location = new System.Drawing.Point(18, 547);
            this.boxAC.Name = "boxAC";
            this.boxAC.Size = new System.Drawing.Size(149, 41);
            this.boxAC.TabIndex = 113;
            this.boxAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArmorClass
            // 
            this.lblArmorClass.AutoSize = true;
            this.lblArmorClass.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmorClass.ForeColor = System.Drawing.Color.Black;
            this.lblArmorClass.Location = new System.Drawing.Point(16, 524);
            this.lblArmorClass.Name = "lblArmorClass";
            this.lblArmorClass.Size = new System.Drawing.Size(83, 12);
            this.lblArmorClass.TabIndex = 112;
            this.lblArmorClass.Text = "Armor Class";
            // 
            // boxHP
            // 
            this.boxHP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxHP.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxHP.ForeColor = System.Drawing.Color.Black;
            this.boxHP.Location = new System.Drawing.Point(14, 489);
            this.boxHP.Name = "boxHP";
            this.boxHP.Size = new System.Drawing.Size(153, 20);
            this.boxHP.TabIndex = 111;
            this.boxHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHitPoints.ForeColor = System.Drawing.Color.Black;
            this.lblHitPoints.Location = new System.Drawing.Point(12, 466);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(66, 12);
            this.lblHitPoints.TabIndex = 110;
            this.lblHitPoints.Text = "Hit Points";
            // 
            // btnAddCha
            // 
            this.btnAddCha.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCha.Location = new System.Drawing.Point(164, 244);
            this.btnAddCha.Name = "btnAddCha";
            this.btnAddCha.Size = new System.Drawing.Size(24, 24);
            this.btnAddCha.TabIndex = 109;
            this.btnAddCha.Text = "↑";
            this.btnAddCha.UseVisualStyleBackColor = true;
            this.btnAddCha.Visible = false;
            this.btnAddCha.Click += new System.EventHandler(this.btnAddCha_Click);
            // 
            // btnAddWis
            // 
            this.btnAddWis.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWis.Location = new System.Drawing.Point(164, 214);
            this.btnAddWis.Name = "btnAddWis";
            this.btnAddWis.Size = new System.Drawing.Size(24, 24);
            this.btnAddWis.TabIndex = 108;
            this.btnAddWis.Text = "↑";
            this.btnAddWis.UseVisualStyleBackColor = true;
            this.btnAddWis.Visible = false;
            this.btnAddWis.Click += new System.EventHandler(this.btnAddWis_Click);
            // 
            // btnAddInt
            // 
            this.btnAddInt.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInt.Location = new System.Drawing.Point(164, 184);
            this.btnAddInt.Name = "btnAddInt";
            this.btnAddInt.Size = new System.Drawing.Size(24, 24);
            this.btnAddInt.TabIndex = 107;
            this.btnAddInt.Text = "↑";
            this.btnAddInt.UseVisualStyleBackColor = true;
            this.btnAddInt.Visible = false;
            this.btnAddInt.Click += new System.EventHandler(this.btnAddInt_Click);
            // 
            // btnAddCon
            // 
            this.btnAddCon.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCon.Location = new System.Drawing.Point(164, 154);
            this.btnAddCon.Name = "btnAddCon";
            this.btnAddCon.Size = new System.Drawing.Size(24, 24);
            this.btnAddCon.TabIndex = 106;
            this.btnAddCon.Text = "↑";
            this.btnAddCon.UseVisualStyleBackColor = true;
            this.btnAddCon.Visible = false;
            this.btnAddCon.Click += new System.EventHandler(this.btnAddCon_Click);
            // 
            // btnAddDex
            // 
            this.btnAddDex.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDex.Location = new System.Drawing.Point(164, 124);
            this.btnAddDex.Name = "btnAddDex";
            this.btnAddDex.Size = new System.Drawing.Size(24, 24);
            this.btnAddDex.TabIndex = 105;
            this.btnAddDex.Text = "↑";
            this.btnAddDex.UseVisualStyleBackColor = true;
            this.btnAddDex.Visible = false;
            this.btnAddDex.Click += new System.EventHandler(this.btnAddDex_Click);
            // 
            // btnAddStr
            // 
            this.btnAddStr.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStr.Location = new System.Drawing.Point(164, 91);
            this.btnAddStr.Name = "btnAddStr";
            this.btnAddStr.Size = new System.Drawing.Size(24, 24);
            this.btnAddStr.TabIndex = 104;
            this.btnAddStr.Text = "↑";
            this.btnAddStr.UseVisualStyleBackColor = true;
            this.btnAddStr.Visible = false;
            this.btnAddStr.Click += new System.EventHandler(this.btnAddStr_Click);
            // 
            // boxExp
            // 
            this.boxExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxExp.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxExp.ForeColor = System.Drawing.Color.Black;
            this.boxExp.Location = new System.Drawing.Point(207, 547);
            this.boxExp.Name = "boxExp";
            this.boxExp.Size = new System.Drawing.Size(212, 20);
            this.boxExp.TabIndex = 103;
            this.boxExp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperience.ForeColor = System.Drawing.Color.Black;
            this.lblExperience.Location = new System.Drawing.Point(281, 517);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(73, 12);
            this.lblExperience.TabIndex = 102;
            this.lblExperience.Text = "Experience";
            // 
            // lblCharName
            // 
            this.lblCharName.ForeColor = System.Drawing.Color.Black;
            this.lblCharName.Location = new System.Drawing.Point(203, 23);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(216, 48);
            this.lblCharName.TabIndex = 101;
            this.lblCharName.Text = "Name/Level";
            this.lblCharName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharInfo
            // 
            this.lblCharInfo.ForeColor = System.Drawing.Color.Black;
            this.lblCharInfo.Location = new System.Drawing.Point(216, 426);
            this.lblCharInfo.Name = "lblCharInfo";
            this.lblCharInfo.Size = new System.Drawing.Size(203, 82);
            this.lblCharInfo.TabIndex = 100;
            this.lblCharInfo.Text = "Race/Align/Gender";
            this.lblCharInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxCha
            // 
            this.boxCha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxCha.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCha.ForeColor = System.Drawing.Color.Black;
            this.boxCha.Location = new System.Drawing.Point(111, 244);
            this.boxCha.Name = "boxCha";
            this.boxCha.Size = new System.Drawing.Size(47, 20);
            this.boxCha.TabIndex = 99;
            this.boxCha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxWis
            // 
            this.boxWis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxWis.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxWis.ForeColor = System.Drawing.Color.Black;
            this.boxWis.Location = new System.Drawing.Point(111, 214);
            this.boxWis.Name = "boxWis";
            this.boxWis.Size = new System.Drawing.Size(47, 20);
            this.boxWis.TabIndex = 98;
            this.boxWis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxInt
            // 
            this.boxInt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxInt.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxInt.ForeColor = System.Drawing.Color.Black;
            this.boxInt.Location = new System.Drawing.Point(111, 184);
            this.boxInt.Name = "boxInt";
            this.boxInt.Size = new System.Drawing.Size(47, 20);
            this.boxInt.TabIndex = 97;
            this.boxInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxCon
            // 
            this.boxCon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxCon.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCon.ForeColor = System.Drawing.Color.Black;
            this.boxCon.Location = new System.Drawing.Point(111, 154);
            this.boxCon.Name = "boxCon";
            this.boxCon.Size = new System.Drawing.Size(47, 20);
            this.boxCon.TabIndex = 96;
            this.boxCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxDex
            // 
            this.boxDex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxDex.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDex.ForeColor = System.Drawing.Color.Black;
            this.boxDex.Location = new System.Drawing.Point(111, 124);
            this.boxDex.Name = "boxDex";
            this.boxDex.Size = new System.Drawing.Size(47, 20);
            this.boxDex.TabIndex = 95;
            this.boxDex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxStr
            // 
            this.boxStr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxStr.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStr.ForeColor = System.Drawing.Color.Black;
            this.boxStr.Location = new System.Drawing.Point(111, 94);
            this.boxStr.Name = "boxStr";
            this.boxStr.Size = new System.Drawing.Size(47, 20);
            this.boxStr.TabIndex = 94;
            this.boxStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharisma
            // 
            this.lblCharisma.AutoSize = true;
            this.lblCharisma.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharisma.ForeColor = System.Drawing.Color.Black;
            this.lblCharisma.Location = new System.Drawing.Point(12, 244);
            this.lblCharisma.Name = "lblCharisma";
            this.lblCharisma.Size = new System.Drawing.Size(64, 12);
            this.lblCharisma.TabIndex = 93;
            this.lblCharisma.Text = "Charisma:";
            // 
            // lblWisdom
            // 
            this.lblWisdom.AutoSize = true;
            this.lblWisdom.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWisdom.ForeColor = System.Drawing.Color.Black;
            this.lblWisdom.Location = new System.Drawing.Point(12, 214);
            this.lblWisdom.Name = "lblWisdom";
            this.lblWisdom.Size = new System.Drawing.Size(55, 12);
            this.lblWisdom.TabIndex = 92;
            this.lblWisdom.Text = "Wisdom:";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntelligence.ForeColor = System.Drawing.Color.Black;
            this.lblIntelligence.Location = new System.Drawing.Point(12, 184);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(85, 12);
            this.lblIntelligence.TabIndex = 91;
            this.lblIntelligence.Text = "Intelligence:";
            // 
            // lblConstitution
            // 
            this.lblConstitution.AutoSize = true;
            this.lblConstitution.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstitution.ForeColor = System.Drawing.Color.Black;
            this.lblConstitution.Location = new System.Drawing.Point(12, 154);
            this.lblConstitution.Name = "lblConstitution";
            this.lblConstitution.Size = new System.Drawing.Size(87, 12);
            this.lblConstitution.TabIndex = 90;
            this.lblConstitution.Text = "Constitution:";
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDexterity.ForeColor = System.Drawing.Color.Black;
            this.lblDexterity.Location = new System.Drawing.Point(12, 124);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(65, 12);
            this.lblDexterity.TabIndex = 89;
            this.lblDexterity.Text = "Dexterity:";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.ForeColor = System.Drawing.Color.Black;
            this.lblStrength.Location = new System.Drawing.Point(12, 94);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(65, 12);
            this.lblStrength.TabIndex = 88;
            this.lblStrength.Text = "Strength:";
            // 
            // tabInventory
            // 
            this.tabInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.tabInventory.Controls.Add(this.lblArmour);
            this.tabInventory.Controls.Add(this.lblOffHand);
            this.tabInventory.Controls.Add(this.lblMainHand);
            this.tabInventory.Controls.Add(this.picArmour);
            this.tabInventory.Controls.Add(this.picOffHand);
            this.tabInventory.Controls.Add(this.picMainHand);
            this.tabInventory.Controls.Add(this.picScaleIcon);
            this.tabInventory.Controls.Add(this.boxWeight);
            this.tabInventory.Controls.Add(this.boxGold);
            this.tabInventory.Controls.Add(this.picGoldIcon);
            this.tabInventory.Controls.Add(this.tableInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 21);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(712, 630);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            // 
            // lblArmour
            // 
            this.lblArmour.AutoSize = true;
            this.lblArmour.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmour.ForeColor = System.Drawing.Color.Black;
            this.lblArmour.Location = new System.Drawing.Point(311, 148);
            this.lblArmour.Name = "lblArmour";
            this.lblArmour.Size = new System.Drawing.Size(51, 12);
            this.lblArmour.TabIndex = 133;
            this.lblArmour.Text = "Armour";
            // 
            // lblOffHand
            // 
            this.lblOffHand.AutoSize = true;
            this.lblOffHand.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffHand.ForeColor = System.Drawing.Color.Black;
            this.lblOffHand.Location = new System.Drawing.Point(438, 148);
            this.lblOffHand.Name = "lblOffHand";
            this.lblOffHand.Size = new System.Drawing.Size(62, 12);
            this.lblOffHand.TabIndex = 132;
            this.lblOffHand.Text = "Off Hand";
            // 
            // lblMainHand
            // 
            this.lblMainHand.AutoSize = true;
            this.lblMainHand.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHand.ForeColor = System.Drawing.Color.Black;
            this.lblMainHand.Location = new System.Drawing.Point(180, 148);
            this.lblMainHand.Name = "lblMainHand";
            this.lblMainHand.Size = new System.Drawing.Size(68, 12);
            this.lblMainHand.TabIndex = 131;
            this.lblMainHand.Text = "Main Hand";
            // 
            // picArmour
            // 
            this.picArmour.BackgroundImage = global::Pathfinder.Properties.Resources.BlankInventory;
            this.picArmour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picArmour.Location = new System.Drawing.Point(313, 163);
            this.picArmour.Name = "picArmour";
            this.picArmour.Size = new System.Drawing.Size(50, 50);
            this.picArmour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArmour.TabIndex = 130;
            this.picArmour.TabStop = false;
            this.picArmour.DragDrop += new System.Windows.Forms.DragEventHandler(this.armour_DragDrop);
            this.picArmour.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic_DragEnter);
            // 
            // picOffHand
            // 
            this.picOffHand.BackgroundImage = global::Pathfinder.Properties.Resources.BlankTexture;
            this.picOffHand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picOffHand.Image = global::Pathfinder.Properties.Resources.BlankInventory;
            this.picOffHand.Location = new System.Drawing.Point(440, 163);
            this.picOffHand.Name = "picOffHand";
            this.picOffHand.Size = new System.Drawing.Size(50, 50);
            this.picOffHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOffHand.TabIndex = 129;
            this.picOffHand.TabStop = false;
            // 
            // picMainHand
            // 
            this.picMainHand.BackgroundImage = global::Pathfinder.Properties.Resources.BlankInventory;
            this.picMainHand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picMainHand.Location = new System.Drawing.Point(182, 163);
            this.picMainHand.Name = "picMainHand";
            this.picMainHand.Size = new System.Drawing.Size(50, 50);
            this.picMainHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainHand.TabIndex = 128;
            this.picMainHand.TabStop = false;
            this.picMainHand.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainHand_DragDrop);
            this.picMainHand.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic_DragEnter);
            // 
            // picScaleIcon
            // 
            this.picScaleIcon.Image = global::Pathfinder.Properties.Resources.ScaleIcon;
            this.picScaleIcon.Location = new System.Drawing.Point(409, 605);
            this.picScaleIcon.Name = "picScaleIcon";
            this.picScaleIcon.Size = new System.Drawing.Size(25, 25);
            this.picScaleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScaleIcon.TabIndex = 127;
            this.picScaleIcon.TabStop = false;
            // 
            // boxWeight
            // 
            this.boxWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxWeight.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxWeight.ForeColor = System.Drawing.Color.Black;
            this.boxWeight.Location = new System.Drawing.Point(440, 609);
            this.boxWeight.Name = "boxWeight";
            this.boxWeight.Size = new System.Drawing.Size(85, 20);
            this.boxWeight.TabIndex = 126;
            this.boxWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxGold
            // 
            this.boxGold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxGold.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxGold.ForeColor = System.Drawing.Color.Black;
            this.boxGold.Location = new System.Drawing.Point(562, 607);
            this.boxGold.Name = "boxGold";
            this.boxGold.Size = new System.Drawing.Size(142, 20);
            this.boxGold.TabIndex = 125;
            this.boxGold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picGoldIcon
            // 
            this.picGoldIcon.Image = global::Pathfinder.Properties.Resources.GoldIcon;
            this.picGoldIcon.Location = new System.Drawing.Point(531, 604);
            this.picGoldIcon.Name = "picGoldIcon";
            this.picGoldIcon.Size = new System.Drawing.Size(25, 25);
            this.picGoldIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGoldIcon.TabIndex = 1;
            this.picGoldIcon.TabStop = false;
            // 
            // tableInventory
            // 
            this.tableInventory.AutoSize = true;
            this.tableInventory.BackgroundImage = global::Pathfinder.Properties.Resources.BrownBackground;
            this.tableInventory.ColumnCount = 13;
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.ForeColor = System.Drawing.Color.Black;
            this.tableInventory.Location = new System.Drawing.Point(54, 445);
            this.tableInventory.Name = "tableInventory";
            this.tableInventory.RowCount = 3;
            this.tableInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableInventory.Size = new System.Drawing.Size(650, 154);
            this.tableInventory.TabIndex = 0;
            // 
            // tabSpells
            // 
            this.tabSpells.Location = new System.Drawing.Point(4, 21);
            this.tabSpells.Name = "tabSpells";
            this.tabSpells.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpells.Size = new System.Drawing.Size(712, 630);
            this.tabSpells.TabIndex = 2;
            this.tabSpells.Text = "Spellbook";
            this.tabSpells.UseVisualStyleBackColor = true;
            // 
            // CharacterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(745, 707);
            this.Controls.Add(this.tabCharacter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.updAddExp);
            this.Controls.Add(this.btnAddExp);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CharacterSheet";
            this.Text = "CharacterSheet";
            this.Load += new System.EventHandler(this.CharacterSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updAddExp)).EndInit();
            this.tabCharacter.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortrait)).EndInit();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArmour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScaleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoldIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.NumericUpDown updAddExp;
        internal System.Windows.Forms.Button btnAddExp;
        private System.Windows.Forms.TabControl tabCharacter;
        private System.Windows.Forms.TabPage tabProfile;
        internal System.Windows.Forms.Label boxFortSave;
        internal System.Windows.Forms.Label boxRefSave;
        internal System.Windows.Forms.Label boxWillSave;
        internal System.Windows.Forms.Label lblFortSave;
        internal System.Windows.Forms.Label lblRefSave;
        internal System.Windows.Forms.Label lblWillSave;
        private System.Windows.Forms.PictureBox picPortrait;
        internal System.Windows.Forms.Label boxDmg;
        internal System.Windows.Forms.Label lblDamage;
        internal System.Windows.Forms.Label boxAP;
        internal System.Windows.Forms.Label lblAttackBonus;
        internal System.Windows.Forms.Label boxAC;
        internal System.Windows.Forms.Label lblArmorClass;
        internal System.Windows.Forms.Label boxHP;
        internal System.Windows.Forms.Label lblHitPoints;
        internal System.Windows.Forms.Button btnAddCha;
        internal System.Windows.Forms.Button btnAddWis;
        internal System.Windows.Forms.Button btnAddInt;
        internal System.Windows.Forms.Button btnAddCon;
        internal System.Windows.Forms.Button btnAddDex;
        internal System.Windows.Forms.Button btnAddStr;
        internal System.Windows.Forms.Label boxExp;
        internal System.Windows.Forms.Label lblExperience;
        internal System.Windows.Forms.Label lblCharName;
        internal System.Windows.Forms.Label lblCharInfo;
        internal System.Windows.Forms.Label boxCha;
        internal System.Windows.Forms.Label boxWis;
        internal System.Windows.Forms.Label boxInt;
        internal System.Windows.Forms.Label boxCon;
        internal System.Windows.Forms.Label boxDex;
        internal System.Windows.Forms.Label boxStr;
        internal System.Windows.Forms.Label lblCharisma;
        internal System.Windows.Forms.Label lblWisdom;
        internal System.Windows.Forms.Label lblIntelligence;
        internal System.Windows.Forms.Label lblConstitution;
        internal System.Windows.Forms.Label lblDexterity;
        internal System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabSpells;
        private System.Windows.Forms.TableLayoutPanel tableInventory;
        private System.Windows.Forms.PictureBox picGoldIcon;
        internal System.Windows.Forms.Label boxGold;
        private System.Windows.Forms.PictureBox picScaleIcon;
        internal System.Windows.Forms.Label boxWeight;
        private System.Windows.Forms.PictureBox picMainHand;
        internal System.Windows.Forms.Label lblArmour;
        internal System.Windows.Forms.Label lblOffHand;
        internal System.Windows.Forms.Label lblMainHand;
        private System.Windows.Forms.PictureBox picArmour;
        private System.Windows.Forms.PictureBox picOffHand;
    }
}