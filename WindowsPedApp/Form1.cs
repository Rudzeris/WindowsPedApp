using System.Collections.Specialized;

namespace WindowsPedApp
{
    public partial class Form1 : Form
    {
        string MainMenuHelperText = "������������! " + //��� ��������� ����� � �������� "text" � ������� ����� � ������� Enter
            "��� ���������� ����������� ���������� ��� ��������������. " +
            "��� ������� �������� � ��������� ��������� �������������� ������� ��� ���������. " +
            "��� ���������� ���������� ������� �������� ��������� �����������, " +
            "� ����� ��������� ������� ���� �� ���������� � ��������.";
        string InstructionHelperText = "����� ������ �������� ���������� ���������� � ��� �� ������������";
        string MenuHelperText = "���� ���� ���� ������, �i��� ������ ����i����. ������ ����� ������. ����!";

        public Form1()
        {
            InitializeComponent();
            Size = new Size(560, 700);


            LiteraturesRichTextBox.Text = "\t1) �����1\n" +
                "\t2) �����2\n" +
                "\t3) �����3\n" +
                "\t4) �����4\n" +
                "\t5) �����5\n" +
                "\t6) �����6\n";


            OpenMainMenu();
        }
        Point sizeDefault = new Point(520,637);
        Point locationDefault = new Point(12,12);

        private void OpenHelper(string str)
        {
            MainMenuPictureBoxHelper.Visible = true;
            MainMenuHelperLabel.Visible = true;
            MainMenuButtonCloseHelper.Visible = true;
            MainMenuHelperLabel.Text = str;
        }

        private void CloseAll()
        {
            Instruction.Visible = false;
            MainMenu.Visible = false;
            Literatures.Visible = false;
            Menu.Visible = false;
        }
        private void OpenMainMenu()
        {
            CloseAll();
            OpenHelper(MainMenuHelperText);
            MainMenu.Visible = true;
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
            OpenHelper(InstructionHelperText);
            Text = "Instruction";
            Instruction.Visible = true;
            Instruction.Size = new Size(sizeDefault);
            Instruction.Location = locationDefault;
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
            OpenHelper(MenuHelperText);
            Menu.Visible = true;
            Menu.Size = new Size(sizeDefault);
            Menu.Location = locationDefault;
            Text = "Menu";
        }
        private void MainMenuCloseHelper(object sender, EventArgs e)
        {
            MainMenuPictureBoxHelper.Visible = false;
            MainMenuHelperLabel.Visible = false;
            MainMenuButtonCloseHelper.Visible = false;
        }
    }
}