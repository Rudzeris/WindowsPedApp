using System.Collections.Specialized;

namespace WindowsPedApp
{
    public partial class Form1 : Form
    {
        string MainMenuHelperText = "Здравствуйте! " + //Ввёл полностью текст в кавычках "text" и выбирал места и нажимал Enter
            "Это приложение разработано специально для преподавателей. " +
            "Оно поможет грамотно и интересно составить нетрадиционные занятия для студентов. " +
            "Это уникальное приложение поможет повысить мотивацию обучающихся, " +
            "а также облегчить нелёгкий труд по подготовке к занятиям.";
        string InstructionHelperText = "Здесь указан основной функционал приложения и как им пользоваться";
        string MenuHelperText = "Тебе сюда пока нельзя, вiйди отсюда розбiйник. Сверху слева кнопка. Беги!";

        public Form1()
        {
            InitializeComponent();
            Size = new Size(560, 700);


            LiteraturesRichTextBox.Text = "\t1) Книга1\n" +
                "\t2) Книга2\n" +
                "\t3) Книга3\n" +
                "\t4) Книга4\n" +
                "\t5) Книга5\n" +
                "\t6) Книга6\n";


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