namespace Character_Sheet_Generator
{
    partial class Character_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Character_Generator));
            this.FighterGenerator = new System.Windows.Forms.Button();
            this.luckBox = new System.Windows.Forms.TextBox();
            this.chaBox = new System.Windows.Forms.TextBox();
            this.strBox = new System.Windows.Forms.TextBox();
            this.Gold = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HeirarchyList = new System.Windows.Forms.ListBox();
            this.JobListBox = new System.Windows.Forms.ListBox();
            this.WizardGenerator = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.intBox = new System.Windows.Forms.TextBox();
            this.dexBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wisBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FighterGenerator
            // 
            this.FighterGenerator.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FighterGenerator.ForeColor = System.Drawing.Color.Black;
            this.FighterGenerator.Location = new System.Drawing.Point(12, 170);
            this.FighterGenerator.Name = "FighterGenerator";
            this.FighterGenerator.Size = new System.Drawing.Size(92, 22);
            this.FighterGenerator.TabIndex = 3;
            this.FighterGenerator.Text = "Select Fighter";
            this.FighterGenerator.UseVisualStyleBackColor = false;
            this.FighterGenerator.Click += new System.EventHandler(this.FighterGenerator_Click_1);
            // 
            // luckBox
            // 
            this.luckBox.Location = new System.Drawing.Point(91, 171);
            this.luckBox.Name = "luckBox";
            this.luckBox.ReadOnly = true;
            this.luckBox.Size = new System.Drawing.Size(100, 20);
            this.luckBox.TabIndex = 5;
            // 
            // chaBox
            // 
            this.chaBox.Location = new System.Drawing.Point(91, 29);
            this.chaBox.Name = "chaBox";
            this.chaBox.ReadOnly = true;
            this.chaBox.Size = new System.Drawing.Size(100, 20);
            this.chaBox.TabIndex = 6;
            // 
            // strBox
            // 
            this.strBox.Location = new System.Drawing.Point(91, 85);
            this.strBox.Name = "strBox";
            this.strBox.ReadOnly = true;
            this.strBox.Size = new System.Drawing.Size(100, 20);
            this.strBox.TabIndex = 7;
            // 
            // Gold
            // 
            this.Gold.AutoSize = true;
            this.Gold.Location = new System.Drawing.Point(6, 60);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(45, 13);
            this.Gold.TabIndex = 8;
            this.Gold.Text = "Wisdom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Strength";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Intelligence";
            // 
            // HeirarchyList
            // 
            this.HeirarchyList.FormattingEnabled = true;
            this.HeirarchyList.Location = new System.Drawing.Point(12, 92);
            this.HeirarchyList.Name = "HeirarchyList";
            this.HeirarchyList.Size = new System.Drawing.Size(92, 43);
            this.HeirarchyList.TabIndex = 13;
            // 
            // JobListBox
            // 
            this.JobListBox.FormattingEnabled = true;
            this.JobListBox.Location = new System.Drawing.Point(132, 92);
            this.JobListBox.Name = "JobListBox";
            this.JobListBox.Size = new System.Drawing.Size(92, 43);
            this.JobListBox.TabIndex = 0;
            this.JobListBox.SelectedIndexChanged += new System.EventHandler(this.JobListBox_SelectedIndexChanged);
            // 
            // WizardGenerator
            // 
            this.WizardGenerator.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WizardGenerator.ForeColor = System.Drawing.Color.Black;
            this.WizardGenerator.Location = new System.Drawing.Point(132, 170);
            this.WizardGenerator.Name = "WizardGenerator";
            this.WizardGenerator.Size = new System.Drawing.Size(92, 22);
            this.WizardGenerator.TabIndex = 13;
            this.WizardGenerator.Text = "Select Wizard";
            this.WizardGenerator.UseVisualStyleBackColor = false;
            this.WizardGenerator.Click += new System.EventHandler(this.WizardGenerator_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.intBox);
            this.groupBox1.Controls.Add(this.dexBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.wisBox);
            this.groupBox1.Controls.Add(this.chaBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.strBox);
            this.groupBox1.Controls.Add(this.luckBox);
            this.groupBox1.Controls.Add(this.Gold);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(484, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 194);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Luck";
            // 
            // intBox
            // 
            this.intBox.Location = new System.Drawing.Point(91, 113);
            this.intBox.Name = "intBox";
            this.intBox.ReadOnly = true;
            this.intBox.Size = new System.Drawing.Size(100, 20);
            this.intBox.TabIndex = 15;
            // 
            // dexBox
            // 
            this.dexBox.Location = new System.Drawing.Point(91, 144);
            this.dexBox.Name = "dexBox";
            this.dexBox.ReadOnly = true;
            this.dexBox.Size = new System.Drawing.Size(100, 20);
            this.dexBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dexterity";
            // 
            // wisBox
            // 
            this.wisBox.Location = new System.Drawing.Point(91, 57);
            this.wisBox.Name = "wisBox";
            this.wisBox.ReadOnly = true;
            this.wisBox.Size = new System.Drawing.Size(100, 20);
            this.wisBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Charisma";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(53, 20);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 15;
            this.nameBox.Text = "Magnus";
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(110, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "or";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(9, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Heirarchy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(129, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Job";
            // 
            // Character_Generator
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 539);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.JobListBox);
            this.Controls.Add(this.HeirarchyList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WizardGenerator);
            this.Controls.Add(this.FighterGenerator);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Character_Generator";
            this.Text = "Character Generation";
            this.Load += new System.EventHandler(this.Character_Generator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FighterGenerator;
        private System.Windows.Forms.TextBox luckBox;
        private System.Windows.Forms.TextBox chaBox;
        private System.Windows.Forms.TextBox strBox;
        private System.Windows.Forms.Label Gold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox HeirarchyList;
        private System.Windows.Forms.ListBox JobListBox;
        private System.Windows.Forms.Button WizardGenerator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox wisBox;
        private System.Windows.Forms.TextBox dexBox;
        private System.Windows.Forms.TextBox intBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

