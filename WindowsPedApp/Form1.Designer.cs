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
            this.Instruction = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // Instruction
            // 
            this.Instruction.Location = new System.Drawing.Point(12, 12);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(520, 637);
            this.Instruction.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1548, 661);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainMenu;
        private Button MainMenuButtonInstruction;
        private Button MainMenuButtonExit;
        private Button MainMenuButtonLiteratures;
        private PictureBox pictureBox2;
        private Label MainMenuLabel2;
        private Panel Instruction;
        private Label MainMenuNameProg;
        private Button ButtonHome;
    }
}