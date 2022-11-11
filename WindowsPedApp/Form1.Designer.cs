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
            this.MainMenuLabel2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MainMenuNameProg = new System.Windows.Forms.Label();
            this.MainMenuButtonExit = new System.Windows.Forms.Button();
            this.MainMenuButtonLiteratures = new System.Windows.Forms.Button();
            this.MainMenuButtonInstruction = new System.Windows.Forms.Button();
            this.Literatures = new System.Windows.Forms.Panel();
            this.LiteraturesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Panel();
            this.Other = new System.Windows.Forms.Button();
            this.CreateTechnicalMap = new System.Windows.Forms.Button();
            this.CreateLesson = new System.Windows.Forms.Button();
            this.MaiMenu2Label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Literatures.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.MainMenuLabel2);
            this.MainMenu.Controls.Add(this.pictureBox2);
            this.MainMenu.Controls.Add(this.MainMenuNameProg);
            this.MainMenu.Controls.Add(this.MainMenuButtonExit);
            this.MainMenu.Controls.Add(this.MainMenuButtonLiteratures);
            this.MainMenu.Controls.Add(this.MainMenuButtonInstruction);
            this.MainMenu.Location = new System.Drawing.Point(540, 12);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(520, 637);
            this.MainMenu.TabIndex = 0;
            // 
            // MainMenuLabel2
            // 
            this.MainMenuLabel2.Location = new System.Drawing.Point(226, 230);
            this.MainMenuLabel2.Name = "MainMenuLabel2";
            this.MainMenuLabel2.Size = new System.Drawing.Size(263, 111);
            this.MainMenuLabel2.TabIndex = 5;
            this.MainMenuLabel2.Text = resources.GetString("MainMenuLabel2.Text");
            this.MainMenuLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.BackgroundImage = global::WindowsPedApp.Resources.Resource1.Helper;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(371, 344);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // MainMenuNameProg
            // 
            this.MainMenuNameProg.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.MainMenuButtonInstruction.Text = "Инструкция";
            this.MainMenuButtonInstruction.UseVisualStyleBackColor = false;
            this.MainMenuButtonInstruction.Click += new System.EventHandler(this.OpenInstruction);
            // 
            // Literatures
            // 
            this.Literatures.Controls.Add(this.LiteraturesRichTextBox);
            this.Literatures.Location = new System.Drawing.Point(532, 12);
            this.Literatures.Name = "Literatures";
            this.Literatures.Size = new System.Drawing.Size(520, 637);
            this.Literatures.TabIndex = 1;
            // 
            // LiteraturesRichTextBox
            // 
            this.LiteraturesRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LiteraturesRichTextBox.Location = new System.Drawing.Point(10, 10);
            this.LiteraturesRichTextBox.Name = "LiteraturesRichTextBox";
            this.LiteraturesRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LiteraturesRichTextBox.Size = new System.Drawing.Size(500, 617);
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
            this.ButtonHome.UseVisualStyleBackColor = false;
            this.ButtonHome.Click += new System.EventHandler(this.OpenMainMenu);
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.Other);
            this.Menu.Controls.Add(this.CreateTechnicalMap);
            this.Menu.Controls.Add(this.CreateLesson);
            this.Menu.Controls.Add(this.MaiMenu2Label2);
            this.Menu.Controls.Add(this.pictureBox1);
            this.Menu.Controls.Add(this.label2);
            this.Menu.Location = new System.Drawing.Point(12, 12);
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
            this.CreateLesson.Text = "Создать урок";
            this.CreateLesson.UseVisualStyleBackColor = false;
            // 
            // MaiMenu2Label2
            // 
            this.MaiMenu2Label2.Location = new System.Drawing.Point(226, 230);
            this.MaiMenu2Label2.Name = "MaiMenu2Label2";
            this.MaiMenu2Label2.Size = new System.Drawing.Size(263, 111);
            this.MaiMenu2Label2.TabIndex = 5;
            this.MaiMenu2Label2.Text = "MainMenu2Labe2";
            this.MaiMenu2Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = global::WindowsPedApp.Resources.Resource1.Helper;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(371, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название приложения";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1370, 661);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Literatures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Literatures.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainMenu;
        private Button MainMenuButtonInstruction;
        private Button MainMenuButtonExit;
        private Button MainMenuButtonLiteratures;
        private PictureBox pictureBox2;
        private Label MainMenuLabel2;
        private Panel Literatures;
        private Label MainMenuNameProg;
        private Button ButtonHome;
        private RichTextBox LiteraturesRichTextBox;
        private Panel Menu;
        private Label MaiMenu2Label2;
        private PictureBox pictureBox1;
        private Label label2;
        private Button CreateTechnicalMap;
        private Button CreateLesson;
        private Button Other;
    }
}