using System.Collections.Specialized;

namespace WindowsPedApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size(560, 700);

            CloseAll();
            OpenMainMenu();
        }
        Point sizeDefault = new Point(520,637);
        Point locationDefault = new Point(12,12);

        private void CloseAll()
        {
            MainMenu.Visible = false;
            Literatures.Visible = false;
            Menu.Visible = false;
        }
        private void OpenMainMenu()
        {
            CloseAll();
            MainMenu.Visible = true;
            //MainMenuLabel1.Text = "123\n123\n123\n123\n123\n123\n123\n123\n123\n123\n123\n123\n123\n123\n";
            MainMenu.Size = new Size(sizeDefault);
            MainMenu.Location = locationDefault;
            Text = "Main Menu";
        }
        private void OpenMainMenu(object sender, EventArgs e)
        {
            if (Text == "Main Menu")
                OpenMenu(sender, e);
            else
                OpenMainMenu();
        }
        private void OpenInstruction(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Instruction";
        }
        private void OpenLiteratures(object sender, EventArgs e)
        {
            CloseAll();
            Literatures.Visible = true;
            Literatures.Size = new Size(sizeDefault);
            Literatures.Location = locationDefault;
            Text = "Literatures";
        }
        private void MainMenuButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OpenMenu(object sender, EventArgs e)
        {
            CloseAll();
            Menu.Visible = true;
            Menu.Size = new Size(sizeDefault);
            Menu.Location = locationDefault;
            Text = "Menu";
        }
    }
}