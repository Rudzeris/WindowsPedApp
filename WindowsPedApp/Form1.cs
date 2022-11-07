using System.Collections.Specialized;

namespace WindowsPedApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenMainMenu();
            Size = new Size(560, 700);
        }
        Point sizeDefault = new Point(520,637);
        Point locationDefault = new Point(12,12);
        private void OpenMainMenu()
        {
            MainMenu.Enabled = true;
            MainMenu.Visible = true;
            //MainMenuLabel1.Text = "123\n123\n123\n123\n123\n123\n123\n123\n123\n123\n123\n123\n123\n123\n";
            MainMenu.Size = new Size(sizeDefault);
        }

    }
}