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
            Instruction.Visible = false;
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
            OpenMainMenu();
        }
        private void OpenInstruction(object sender, EventArgs e)
        {
            CloseAll();
            Instruction.Visible = true;
            Instruction.Size = new Size(sizeDefault);
            Instruction.Location = locationDefault;
            Text = "Instruction";
        }
        private void OpenLiteratures(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Literatures";
        }
    }
}