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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MainMenuLabel1 = new System.Windows.Forms.Label();
            this.MainMenuButtonExit = new System.Windows.Forms.Button();
            this.MainMenuButton2 = new System.Windows.Forms.Button();
            this.MainMenuButton1 = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.pictureBox2);
            this.MainMenu.Controls.Add(this.MainMenuLabel1);
            this.MainMenu.Controls.Add(this.MainMenuButtonExit);
            this.MainMenu.Controls.Add(this.MainMenuButton2);
            this.MainMenu.Controls.Add(this.MainMenuButton1);
            this.MainMenu.Enabled = false;
            this.MainMenu.Location = new System.Drawing.Point(12, 12);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(520, 637);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Visible = false;
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
            // MainMenuLabel1
            // 
            this.MainMenuLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenuLabel1.Location = new System.Drawing.Point(0, 0);
            this.MainMenuLabel1.Name = "MainMenuLabel1";
            this.MainMenuLabel1.Size = new System.Drawing.Size(520, 198);
            this.MainMenuLabel1.TabIndex = 4;
            this.MainMenuLabel1.Text = "label1";
            this.MainMenuLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // MainMenuButton2
            // 
            this.MainMenuButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuButton2.AutoSize = true;
            this.MainMenuButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuButton2.Location = new System.Drawing.Point(113, 540);
            this.MainMenuButton2.Name = "MainMenuButton2";
            this.MainMenuButton2.Size = new System.Drawing.Size(294, 25);
            this.MainMenuButton2.TabIndex = 2;
            this.MainMenuButton2.Text = "Список литературы";
            this.MainMenuButton2.UseVisualStyleBackColor = false;
            // 
            // MainMenuButton1
            // 
            this.MainMenuButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuButton1.AutoSize = true;
            this.MainMenuButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuButton1.Location = new System.Drawing.Point(113, 500);
            this.MainMenuButton1.Name = "MainMenuButton1";
            this.MainMenuButton1.Size = new System.Drawing.Size(294, 25);
            this.MainMenuButton1.TabIndex = 0;
            this.MainMenuButton1.Text = "Инструкция";
            this.MainMenuButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1548, 661);
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
        private Button MainMenuButton1;
        private Button MainMenuButtonExit;
        private Button MainMenuButton2;
        private Label MainMenuLabel1;
        private PictureBox pictureBox2;
    }
}