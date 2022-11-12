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
            this.MainMenu = new System.Windows.Forms.Panel();
            this.MainMenuNameProg = new System.Windows.Forms.Label();
            this.MainMenuButtonExit = new System.Windows.Forms.Button();
            this.MainMenuButtonLiteratures = new System.Windows.Forms.Button();
            this.MainMenuButtonInstruction = new System.Windows.Forms.Button();
            this.MainMenuButtonCloseHelper = new System.Windows.Forms.Button();
            this.MainMenuHelperLabel = new System.Windows.Forms.Label();
            this.MainMenuPictureBoxHelper = new System.Windows.Forms.PictureBox();
            this.Literatures = new System.Windows.Forms.Panel();
            this.LiteraturesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Panel();
            this.Other = new System.Windows.Forms.Button();
            this.CreateTechnicalMap = new System.Windows.Forms.Button();
            this.CreateLesson = new System.Windows.Forms.Button();
            this.Instruction = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuPictureBoxHelper)).BeginInit();
            this.Literatures.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.MainMenuNameProg);
            this.MainMenu.Controls.Add(this.MainMenuButtonExit);
            this.MainMenu.Controls.Add(this.MainMenuButtonLiteratures);
            this.MainMenu.Controls.Add(this.MainMenuButtonInstruction);
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
            // MainMenuButtonExit
            // 
            this.MainMenuButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuButtonExit.AutoSize = true;
            this.MainMenuButtonExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuButtonExit.Location = new System.Drawing.Point(113, 580);
            this.MainMenuButtonExit.Name = "MainMenuButtonExit";
            this.MainMenuButtonExit.Size = new System.Drawing.Size(294, 25);
            this.MainMenuButtonExit.TabIndex = 3;
            this.MainMenuButtonExit.Tag = "Button";
            this.MainMenuButtonExit.Text = "Выход";
            this.MainMenuButtonExit.UseVisualStyleBackColor = false;
            this.MainMenuButtonExit.Click += new System.EventHandler(this.MainMenuButtonExit_Click);
            // 
            // MainMenuButtonLiteratures
            // 
            this.MainMenuButtonLiteratures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuButtonLiteratures.AutoSize = true;
            this.MainMenuButtonLiteratures.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuButtonLiteratures.Location = new System.Drawing.Point(113, 540);
            this.MainMenuButtonLiteratures.Name = "MainMenuButtonLiteratures";
            this.MainMenuButtonLiteratures.Size = new System.Drawing.Size(294, 25);
            this.MainMenuButtonLiteratures.TabIndex = 2;
            this.MainMenuButtonLiteratures.Tag = "Button";
            this.MainMenuButtonLiteratures.Text = "Список литературы";
            this.MainMenuButtonLiteratures.UseVisualStyleBackColor = false;
            this.MainMenuButtonLiteratures.Click += new System.EventHandler(this.OpenLiteratures);
            // 
            // MainMenuButtonInstruction
            // 
            this.MainMenuButtonInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuButtonInstruction.AutoSize = true;
            this.MainMenuButtonInstruction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuButtonInstruction.Location = new System.Drawing.Point(113, 500);
            this.MainMenuButtonInstruction.Name = "MainMenuButtonInstruction";
            this.MainMenuButtonInstruction.Size = new System.Drawing.Size(294, 25);
            this.MainMenuButtonInstruction.TabIndex = 0;
            this.MainMenuButtonInstruction.Tag = "Button";
            this.MainMenuButtonInstruction.Text = "Инструкция";
            this.MainMenuButtonInstruction.UseVisualStyleBackColor = false;
            this.MainMenuButtonInstruction.Click += new System.EventHandler(this.OpenInstruction);
            // 
            // MainMenuButtonCloseHelper
            // 
            this.MainMenuButtonCloseHelper.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuButtonCloseHelper.FlatAppearance.BorderSize = 0;
            this.MainMenuButtonCloseHelper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuButtonCloseHelper.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuButtonCloseHelper.Location = new System.Drawing.Point(226, 204);
            this.MainMenuButtonCloseHelper.Name = "MainMenuButtonCloseHelper";
            this.MainMenuButtonCloseHelper.Size = new System.Drawing.Size(23, 23);
            this.MainMenuButtonCloseHelper.TabIndex = 6;
            this.MainMenuButtonCloseHelper.Tag = "Button";
            this.MainMenuButtonCloseHelper.Text = "X";
            this.MainMenuButtonCloseHelper.UseVisualStyleBackColor = false;
            this.MainMenuButtonCloseHelper.Click += new System.EventHandler(this.MainMenuCloseHelper);
            // 
            // MainMenuHelperLabel
            // 
            this.MainMenuHelperLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuHelperLabel.Location = new System.Drawing.Point(226, 230);
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
            this.MainMenuPictureBoxHelper.Location = new System.Drawing.Point(389, 344);
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
            this.LiteraturesRichTextBox.Text = "";
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
            this.ButtonHome.Click += new System.EventHandler(this.OpenMainMenu);
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.Other);
            this.Menu.Controls.Add(this.CreateTechnicalMap);
            this.Menu.Controls.Add(this.CreateLesson);
            this.Menu.Location = new System.Drawing.Point(540, 12);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(520, 637);
            this.Menu.TabIndex = 3;
            // 
            // Other
            // 
            this.Other.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Other.AutoSize = true;
            this.Other.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Other.Location = new System.Drawing.Point(113, 580);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(294, 25);
            this.Other.TabIndex = 3;
            this.Other.Tag = "Button";
            this.Other.Text = "Дополнительно";
            this.Other.UseVisualStyleBackColor = false;
            // 
            // CreateTechnicalMap
            // 
            this.CreateTechnicalMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateTechnicalMap.AutoSize = true;
            this.CreateTechnicalMap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CreateTechnicalMap.Location = new System.Drawing.Point(113, 540);
            this.CreateTechnicalMap.Name = "CreateTechnicalMap";
            this.CreateTechnicalMap.Size = new System.Drawing.Size(294, 25);
            this.CreateTechnicalMap.TabIndex = 2;
            this.CreateTechnicalMap.Tag = "Button";
            this.CreateTechnicalMap.Text = "Создать технологическую карту";
            this.CreateTechnicalMap.UseVisualStyleBackColor = false;
            // 
            // CreateLesson
            // 
            this.CreateLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateLesson.AutoSize = true;
            this.CreateLesson.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CreateLesson.Location = new System.Drawing.Point(113, 500);
            this.CreateLesson.Name = "CreateLesson";
            this.CreateLesson.Size = new System.Drawing.Size(294, 25);
            this.CreateLesson.TabIndex = 0;
            this.CreateLesson.Tag = "Button";
            this.CreateLesson.Text = "Создать урок";
            this.CreateLesson.UseVisualStyleBackColor = false;
            // 
            // Instruction
            // 
            this.Instruction.Location = new System.Drawing.Point(540, 12);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(520, 637);
            this.Instruction.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1370, 661);
            this.Controls.Add(this.MainMenuHelperLabel);
            this.Controls.Add(this.MainMenuPictureBoxHelper);
            this.Controls.Add(this.MainMenuButtonCloseHelper);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Literatures);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Instruction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuPictureBoxHelper)).EndInit();
            this.Literatures.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainMenu;
        private Button MainMenuButtonInstruction;
        private Button MainMenuButtonExit;
        private Button MainMenuButtonLiteratures;
        private PictureBox MainMenuPictureBoxHelper;
        private Label MainMenuHelperLabel;
        private Panel Literatures;
        private Label MainMenuNameProg;
        private Button ButtonHome;
        private Panel Menu;
        private Button CreateTechnicalMap;
        private Button CreateLesson;
        private Button Other;
        private RichTextBox LiteraturesRichTextBox;
        private Button MainMenuButtonCloseHelper;
        private Panel Instruction;
    }
}