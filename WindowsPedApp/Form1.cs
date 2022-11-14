using System.Collections.Specialized;

namespace WindowsPedApp
{
    public class ClassTechnicalMaps
    {
        public RichTextBox TTechnicalMap = new RichTextBox();
        public RichTextBox TTeacher = new RichTextBox();
        public RichTextBox TGroup = new RichTextBox();
        public RichTextBox TSubject = new RichTextBox();
        public RichTextBox TLessonTopic = new RichTextBox();
        public DateTimePicker TDate = new DateTimePicker();
        public RichTextBox TTask1 = new RichTextBox();
        public RichTextBox TTask2 = new RichTextBox();
        public RichTextBox TTask3 = new RichTextBox();
        public RichTextBox TResult1 = new RichTextBox();
        public RichTextBox TResult2 = new RichTextBox();
        public RichTextBox TResult3 = new RichTextBox();
        public RichTextBox TFCR1 = new RichTextBox();
        public RichTextBox TFCR2 = new RichTextBox();
        public RichTextBox TFCR3 = new RichTextBox();
        public RichTextBox TResource1 = new RichTextBox();
        public RichTextBox TResource2 = new RichTextBox();
        public RichTextBox TTAPL1 = new RichTextBox();
        public RichTextBox TTAPL2 = new RichTextBox();
        public ClassTechnicalMaps()
        {
            TTechnicalMap.Text = "";
            TTeacher.Text = "";
            TGroup.Text = "";
            TSubject.Text = "";
            TLessonTopic.Text = "";
            TDate.Text = "";
            TTask1.Text = "";
            TTask2.Text = "";
            TTask3.Text = "";
            TResult1.Text = "";
            TResult2.Text = "";
            TResult3.Text = "";
            TFCR1.Text = "";
            TFCR2.Text = "";
            TFCR3.Text = "";
            TResource1.Text = "";
            TResource2.Text = "";
            TTAPL1.Text = "";
            TTAPL2.Text = "";
        }
    };
    
    public partial class Form1 : Form
    {
        string MainMenuHelperText = "Здравствуйте! " + //Ввёл полностью текст в кавычках "text" и выбирал места и нажимал Enter
            "Это приложение разработано специально для преподавателей. " +
            "Оно поможет грамотно и интересно составить нетрадиционные занятия для студентов. " +
            "Это уникальное приложение поможет повысить мотивацию обучающихся, " +
            "а также облегчить нелёгкий труд по подготовке к занятиям.";
        string InstructionHelperText = "Здесь указан основной функционал приложения и как им пользоваться";
        string MenuHelperText = "Тебе сюда пока нельзя, вiйди отсюда розбiйник. Сверху слева кнопка. Беги!";

        ClassTechnicalMaps CTM = new ClassTechnicalMaps();

        public Form1()
        {
            InitializeComponent();
            Size = new Size(560, 700);

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
            TechnicalMap.Visible = false;
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
            if (Text == "Main Menu" || Text=="Create Lesson" || Text=="Technical map" || Text == "Other")
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
            CreateLesson.Location = locationDefault;
            CreateLesson.Size = new Size(sizeDefault);
            Text = "Create Lesson";
        }
        private void OpenTechnicalMap(object sender,EventArgs e)
        {
            CloseAll();
            TechnicalMap.Visible = true;
            TechnicalMap.Location = locationDefault;
            TechnicalMap.Size = new Size(sizeDefault);
            Text = "Technical map";
        }
        private void OpenOther(object sender, EventArgs e)
        {
            CloseAll();
            Other.Visible = true;
            Other.Location = locationDefault;
            Other.Size = new Size(sizeDefault);
            Text = "Other";
        }
    }
}