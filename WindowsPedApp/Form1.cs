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

        string InstructionText = "Данное приложение разработано для преподавателей СПО" +
            " для повышения мотивации студентов." +
            " Главная проблема – неправильная организация учебных занятий." +
            " Современный педагог должен использовать новейшие методы и технологии обучения," +
            " отойти от “старого” к “новому”. Это приложение даст" +
            " Вам рекомендации по правильным методикам проведения занятий," +
            " расскажет о нетрадиционных формах проведения занятий." +
            " Чтобы воспользоваться приложением, Вы должны перейти на вкладку “Создать тест”," +
            " где вы ответите всего на 2 вопроса и получите свои рекомендации," +
            " в зависимости от типа и цели вашего занятия." +
            " Также вы дополнительно можете создать технологическую карту," +
            " которая поможет структурировать ваше занятие и чётко распределить цели и задачи." +
            " Также вы можете пройти тестирование, которое поможет Вам определить степень" +
            " удовлетворённости Вашей работой. Не забудьте прочитать методические приёмы во" +
            " вкладке “Дополнительно”, они помогут Вам не растеряться во время проведения занятия," +
            " а также заинтересовать молодых амбициозных студентов. “Как правильно создать и оформить" +
            " презентацию?” – на это Вы тоже найдёте ответ! Желаю Вам приятного пользования, надеюсь," +
            " что это приложение упростит Вам задачу, а студенты будут с удовольствием ходить на Ваши занятия!";
        string sw="";
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

            InstructionRichText.Text = InstructionText;

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true); // в конструкторе
            MainMenuPictureBoxHelper.BackColor = Color.Transparent;

            OpenMainMenu();
        }
        Point sizeDefault = new Point(520,637);
        Point locationDefault = new Point(12,12);

        private void OpenHelper(string str)
        {
            MainMenuPictureBoxHelper.Visible = true;
            MainMenuHelperLabel.Visible = true;
            ButtonMainMenuCloseHelper.Visible = true;
            MainMenuHelperLabel.Location = new Point(226, 230);
            ButtonMainMenuCloseHelper.Location = new Point(226, 204);
            MainMenuPictureBoxHelper.Location = new Point(389, 344);
            MainMenuHelperLabel.Text = str;
        }

        private void CloseAll()
        {
            object a=new object();
            EventArgs b = new EventArgs();
            MainMenuCloseHelper(a,b);
            Instruction.Visible = false;
            MainMenu.Visible = false;
            Literatures.Visible = false;
            Menu.Visible = false;
            StrategyCard.Visible = false;
            CreateLesson.Visible = false;
            Other.Visible = false;
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
        private void OpenMainMenuOrMenu(object sender, EventArgs e)
        {
            if (Text == "Instruction" || Text == "Literatures" || Text == "Menu")
            {
                OpenMainMenu();
            }else
            if (Text == "Main Menu" || Text=="Create Lesson" || Text=="Strategy Card" || Text == "Other")
            {
                OpenMenu(sender, e);
            }
        }
        private void OpenInstruction(object sender, EventArgs e)
        {
            CloseAll();
            OpenHelper(InstructionHelperText);
            Text = "Instruction";
            Instruction.Visible = true;
            Instruction.Size = new Size(sizeDefault);
            Instruction.Location = locationDefault;
            InstructionRichText.Size = new Size(200, 590);


            MainMenuHelperLabel.Location = new Point(280, 230);
            ButtonMainMenuCloseHelper.Location = new Point(263+260, 204);
            MainMenuPictureBoxHelper.Location = new Point(389, 344);

        }
        private void OpenLiteratures(object sender, EventArgs e)
        {
            CloseAll();
            Literatures.Visible = true;
            Literatures.Size = new Size(sizeDefault);
            Literatures.Location = locationDefault;
            Text = "Literatures";
            MainMenuCloseHelper(sender, e);
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
            ButtonMainMenuCloseHelper.Visible = false;
            InstructionRichText.Size = new Size(420, 590);

            MainMenuHelperLabel.Location = new Point(226, 230);
            ButtonMainMenuCloseHelper.Location = new Point(226, 204);
            MainMenuPictureBoxHelper.Location = new Point(389, 344);

        }
        private void OpenCreateLesson(object sender,EventArgs e)
        {
            CloseAll();
            CreateLesson.Visible = true;
            Text = "Create Lesson";
        }
        private void OpenStrategyCard(object sender,EventArgs e)
        {
            CloseAll();
            StrategyCard.Visible = true;
            Text = "Strategy Card";
        }
        private void OpenOther(object sender, EventArgs e)
        {
            CloseAll();
            Other.Visible = true;
            Text = "Other";
        }
    }
}