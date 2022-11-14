namespace WindowsPedApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainMenu = new System.Windows.Forms.Panel();
            this.MainMenuNameProg = new System.Windows.Forms.Label();
            this.ButtonMainMenuExit = new System.Windows.Forms.Button();
            this.ButtonMainMenuLiteratures = new System.Windows.Forms.Button();
            this.ButtonMainMenuInstruction = new System.Windows.Forms.Button();
            this.ButtonMainMenuCloseHelper = new System.Windows.Forms.Button();
            this.MainMenuHelperLabel = new System.Windows.Forms.Label();
            this.MainMenuPictureBoxHelper = new System.Windows.Forms.PictureBox();
            this.Literatures = new System.Windows.Forms.Panel();
            this.LiteraturesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Panel();
            this.ButtonOther = new System.Windows.Forms.Button();
            this.ButtonCreateTechnicalMap = new System.Windows.Forms.Button();
            this.ButtonCreateLesson = new System.Windows.Forms.Button();
            this.Instruction = new System.Windows.Forms.Panel();
            this.InstructionRichText = new System.Windows.Forms.RichTextBox();
            this.StrategyCard = new System.Windows.Forms.Panel();
            this.Other = new System.Windows.Forms.Panel();
            this.CreateLesson = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuPictureBoxHelper)).BeginInit();
            this.Literatures.SuspendLayout();
            this.Menu.SuspendLayout();
            this.Instruction.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.MainMenuNameProg);
            this.MainMenu.Controls.Add(this.ButtonMainMenuExit);
            this.MainMenu.Controls.Add(this.ButtonMainMenuLiteratures);
            this.MainMenu.Controls.Add(this.ButtonMainMenuInstruction);
            this.MainMenu.Location = new System.Drawing.Point(540, 12);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(520, 637);
            this.MainMenu.TabIndex = 0;
            // 
            // MainMenuNameProg
            // 
            this.MainMenuNameProg.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenuNameProg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuNameProg.Location = new System.Drawing.Point(0, 0);
            this.MainMenuNameProg.Name = "MainMenuNameProg";
            this.MainMenuNameProg.Size = new System.Drawing.Size(520, 47);
            this.MainMenuNameProg.TabIndex = 4;
            this.MainMenuNameProg.Text = "Название приложения";
            this.MainMenuNameProg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonMainMenuExit
            // 
            this.ButtonMainMenuExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMainMenuExit.AutoSize = true;
            this.ButtonMainMenuExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonMainMenuExit.Location = new System.Drawing.Point(113, 580);
            this.ButtonMainMenuExit.Name = "ButtonMainMenuExit";
            this.ButtonMainMenuExit.Size = new System.Drawing.Size(294, 25);
            this.ButtonMainMenuExit.TabIndex = 3;
            this.ButtonMainMenuExit.Tag = "Button";
            this.ButtonMainMenuExit.Text = "Выход";
            this.ButtonMainMenuExit.UseVisualStyleBackColor = false;
            this.ButtonMainMenuExit.Click += new System.EventHandler(this.MainMenuButtonExit_Click);
            // 
            // ButtonMainMenuLiteratures
            // 
            this.ButtonMainMenuLiteratures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMainMenuLiteratures.AutoSize = true;
            this.ButtonMainMenuLiteratures.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonMainMenuLiteratures.Location = new System.Drawing.Point(113, 540);
            this.ButtonMainMenuLiteratures.Name = "ButtonMainMenuLiteratures";
            this.ButtonMainMenuLiteratures.Size = new System.Drawing.Size(294, 25);
            this.ButtonMainMenuLiteratures.TabIndex = 2;
            this.ButtonMainMenuLiteratures.Tag = "Button";
            this.ButtonMainMenuLiteratures.Text = "Список литературы";
            this.ButtonMainMenuLiteratures.UseVisualStyleBackColor = false;
            this.ButtonMainMenuLiteratures.Click += new System.EventHandler(this.OpenLiteratures);
            // 
            // ButtonMainMenuInstruction
            // 
            this.ButtonMainMenuInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMainMenuInstruction.AutoSize = true;
            this.ButtonMainMenuInstruction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonMainMenuInstruction.Location = new System.Drawing.Point(113, 500);
            this.ButtonMainMenuInstruction.Name = "ButtonMainMenuInstruction";
            this.ButtonMainMenuInstruction.Size = new System.Drawing.Size(294, 25);
            this.ButtonMainMenuInstruction.TabIndex = 0;
            this.ButtonMainMenuInstruction.Tag = "Button";
            this.ButtonMainMenuInstruction.Text = "Инструкция";
            this.ButtonMainMenuInstruction.UseVisualStyleBackColor = false;
            this.ButtonMainMenuInstruction.Click += new System.EventHandler(this.OpenInstruction);
            // 
            // ButtonMainMenuCloseHelper
            // 
            this.ButtonMainMenuCloseHelper.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonMainMenuCloseHelper.FlatAppearance.BorderSize = 0;
            this.ButtonMainMenuCloseHelper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMainMenuCloseHelper.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonMainMenuCloseHelper.Location = new System.Drawing.Point(746, 204);
            this.ButtonMainMenuCloseHelper.Name = "ButtonMainMenuCloseHelper";
            this.ButtonMainMenuCloseHelper.Size = new System.Drawing.Size(23, 23);
            this.ButtonMainMenuCloseHelper.TabIndex = 6;
            this.ButtonMainMenuCloseHelper.Tag = "Button";
            this.ButtonMainMenuCloseHelper.Text = "X";
            this.ButtonMainMenuCloseHelper.UseVisualStyleBackColor = false;
            this.ButtonMainMenuCloseHelper.Click += new System.EventHandler(this.MainMenuCloseHelper);
            // 
            // MainMenuHelperLabel
            // 
            this.MainMenuHelperLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuHelperLabel.Location = new System.Drawing.Point(746, 230);
            this.MainMenuHelperLabel.Name = "MainMenuHelperLabel";
            this.MainMenuHelperLabel.Size = new System.Drawing.Size(263, 111);
            this.MainMenuHelperLabel.TabIndex = 5;
            this.MainMenuHelperLabel.Text = "Тут будет текст";
            this.MainMenuHelperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuPictureBoxHelper
            // 
            this.MainMenuPictureBoxHelper.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuPictureBoxHelper.BackgroundImage = global::WindowsPedApp.Resources.Resource1.Helper;
            this.MainMenuPictureBoxHelper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuPictureBoxHelper.InitialImage = null;
            this.MainMenuPictureBoxHelper.Location = new System.Drawing.Point(909, 344);
            this.MainMenuPictureBoxHelper.Name = "MainMenuPictureBoxHelper";
            this.MainMenuPictureBoxHelper.Size = new System.Drawing.Size(100, 100);
            this.MainMenuPictureBoxHelper.TabIndex = 1;
            this.MainMenuPictureBoxHelper.TabStop = false;
            // 
            // Literatures
            // 
            this.Literatures.Controls.Add(this.LiteraturesRichTextBox);
            this.Literatures.Location = new System.Drawing.Point(540, 12);
            this.Literatures.Name = "Literatures";
            this.Literatures.Size = new System.Drawing.Size(520, 637);
            this.Literatures.TabIndex = 1;
            // 
            // LiteraturesRichTextBox
            // 
            this.LiteraturesRichTextBox.AcceptsTab = true;
            this.LiteraturesRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LiteraturesRichTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LiteraturesRichTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LiteraturesRichTextBox.Location = new System.Drawing.Point(50, 36);
            this.LiteraturesRichTextBox.Name = "LiteraturesRichTextBox";
            this.LiteraturesRichTextBox.ReadOnly = true;
            this.LiteraturesRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LiteraturesRichTextBox.Size = new System.Drawing.Size(420, 590);
            this.LiteraturesRichTextBox.TabIndex = 0;
            this.LiteraturesRichTextBox.Text = resources.GetString("LiteraturesRichTextBox.Text");
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonHome.Location = new System.Drawing.Point(12, 12);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(30, 30);
            this.ButtonHome.TabIndex = 2;
            this.ButtonHome.Tag = "Button";
            this.ButtonHome.UseVisualStyleBackColor = false;
            this.ButtonHome.Click += new System.EventHandler(this.OpenMainMenuOrMenu);
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.ButtonOther);
            this.Menu.Controls.Add(this.ButtonCreateTechnicalMap);
            this.Menu.Controls.Add(this.ButtonCreateLesson);
            this.Menu.Location = new System.Drawing.Point(540, 12);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(520, 637);
            this.Menu.TabIndex = 3;
            // 
            // ButtonOther
            // 
            this.ButtonOther.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonOther.AutoSize = true;
            this.ButtonOther.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonOther.Location = new System.Drawing.Point(113, 580);
            this.ButtonOther.Name = "ButtonOther";
            this.ButtonOther.Size = new System.Drawing.Size(294, 25);
            this.ButtonOther.TabIndex = 3;
            this.ButtonOther.Tag = "Button";
            this.ButtonOther.Text = "Дополнительно";
            this.ButtonOther.UseVisualStyleBackColor = false;
            this.ButtonOther.Click += new System.EventHandler(this.OpenOther);
            // 
            // ButtonCreateTechnicalMap
            // 
            this.ButtonCreateTechnicalMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCreateTechnicalMap.AutoSize = true;
            this.ButtonCreateTechnicalMap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonCreateTechnicalMap.Location = new System.Drawing.Point(113, 540);
            this.ButtonCreateTechnicalMap.Name = "ButtonCreateTechnicalMap";
            this.ButtonCreateTechnicalMap.Size = new System.Drawing.Size(294, 25);
            this.ButtonCreateTechnicalMap.TabIndex = 2;
            this.ButtonCreateTechnicalMap.Tag = "Button";
            this.ButtonCreateTechnicalMap.Text = "Создать технологическую карту";
            this.ButtonCreateTechnicalMap.UseVisualStyleBackColor = false;
            this.ButtonCreateTechnicalMap.Click += new System.EventHandler(this.OpenStrategyCard);
            // 
            // ButtonCreateLesson
            // 
            this.ButtonCreateLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCreateLesson.AutoSize = true;
            this.ButtonCreateLesson.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonCreateLesson.Location = new System.Drawing.Point(113, 500);
            this.ButtonCreateLesson.Name = "ButtonCreateLesson";
            this.ButtonCreateLesson.Size = new System.Drawing.Size(294, 25);
            this.ButtonCreateLesson.TabIndex = 0;
            this.ButtonCreateLesson.Tag = "Button";
            this.ButtonCreateLesson.Text = "Создать урок";
            this.ButtonCreateLesson.UseVisualStyleBackColor = false;
            this.ButtonCreateLesson.Click += new System.EventHandler(this.OpenCreateLesson);
            // 
            // Instruction
            // 
            this.Instruction.Controls.Add(this.InstructionRichText);
            this.Instruction.Location = new System.Drawing.Point(540, 12);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(520, 637);
            this.Instruction.TabIndex = 4;
            // 
            // InstructionRichText
            // 
            this.InstructionRichText.AcceptsTab = true;
            this.InstructionRichText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InstructionRichText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InstructionRichText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstructionRichText.Location = new System.Drawing.Point(50, 36);
            this.InstructionRichText.Name = "InstructionRichText";
            this.InstructionRichText.ReadOnly = true;
            this.InstructionRichText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.InstructionRichText.Size = new System.Drawing.Size(420, 590);
            this.InstructionRichText.TabIndex = 1;
            this.InstructionRichText.Text = "";
            // 
            // StrategyCard
            // 
            this.StrategyCard.Location = new System.Drawing.Point(540, 12);
            this.StrategyCard.Name = "StrategyCard";
            this.StrategyCard.Size = new System.Drawing.Size(520, 637);
            this.StrategyCard.TabIndex = 7;
            // 
            // Other
            // 
            this.Other.Location = new System.Drawing.Point(12, 12);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(520, 637);
            this.Other.TabIndex = 8;
            // 
            // CreateLesson
            // 
            this.CreateLesson.Location = new System.Drawing.Point(540, 12);
            this.CreateLesson.Name = "CreateLesson";
            this.CreateLesson.Size = new System.Drawing.Size(520, 637);
            this.CreateLesson.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1370, 661);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.MainMenuHelperLabel);
            this.Controls.Add(this.MainMenuPictureBoxHelper);
            this.Controls.Add(this.ButtonMainMenuCloseHelper);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.Literatures);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.StrategyCard);
            this.Controls.Add(this.CreateLesson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuPictureBoxHelper)).EndInit();
            this.Literatures.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Instruction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainMenu;
        private Button ButtonMainMenuInstruction;
        private Button ButtonMainMenuExit;
        private Button ButtonMainMenuLiteratures;
        private PictureBox MainMenuPictureBoxHelper;
        private Label MainMenuHelperLabel;
        private Panel Literatures;
        private Label MainMenuNameProg;
        private Button ButtonHome;
        private Panel Menu;
        private Button ButtonCreateTechnicalMap;
        private Button ButtonCreateLesson;
        private Button ButtonOther;
        private RichTextBox LiteraturesRichTextBox;
        private Button ButtonMainMenuCloseHelper;
        private Panel Instruction;
        private RichTextBox InstructionRichText;
        private Panel StrategyCard;
        private Panel Other;
        private Panel CreateLesson;
    }
}