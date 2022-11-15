using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsPedApp
{
    
    public partial class Form1 : Form
    {
        string MainMenuHelperText = "Здравствуйте! " + //Ввёл полностью текст в кавычках "text" и выбирал места и нажимал Enter
            "Это приложение разработано специально для преподавателей. " +
            "Оно поможет грамотно и интересно составить нетрадиционные занятия для студентов. " +
            "Это уникальное приложение поможет повысить мотивацию обучающихся, " +
            "а также облегчить нелёгкий труд по подготовке к занятиям.";
        string InstructionHelperText = "Здесь указан основной функционал приложения и как им пользоваться.";
        string MenuHelperText = "Тебе сюда пока нельзя, вiйди отсюда розбiйник. Сверху слева кнопка. Беги!";
        string CreateLessonText = "Выберите урок в зависимости от дидактической цели. Здесь только одна кнопка - кнопка по центру.";

        //ClassTechnicalMaps CTM = new ClassTechnicalMaps();

        char LessonPoint1X;

        public Form1()
        {
            InitializeComponent();
            Size = new Size(560, 700);

            LessonPoint11.SelectionAlignment = HorizontalAlignment.Center;
            LessonPoint12.SelectionAlignment = HorizontalAlignment.Center;
            LessonPoint13.SelectionAlignment = HorizontalAlignment.Center;
            LessonPoint14.SelectionAlignment = HorizontalAlignment.Center;
            LessonPoint15.SelectionAlignment = HorizontalAlignment.Center;

            OpenMainMenu();
        }
        Point sizeDefault = new Point(520,637);
        Point locationDefault = new Point(12,12);

        private void HelperNewLocation(int x,int y)
        {
            HelperLabel.Location = new Point(HelperLabel.Location.X + x, HelperLabel.Location.Y+ y);
            HelperButtonClose.Location = new Point(HelperButtonClose.Location.X+ x, HelperButtonClose.Location.Y+ y);
            HelperPictureBox.Location = new Point(HelperPictureBox.Location.X+ x, HelperPictureBox.Location.Y+ y);
        }

        private void OpenHelper(string str)
        {
            HelperPictureBox.Visible = true;
            HelperLabel.Visible = true;
            HelperButtonClose.Visible = true;
            HelperLabel.Location = new Point(226, 230);
            HelperLabel.Size = new Size(270,120);
            HelperButtonClose.Location = new Point(226, 204);
            HelperPictureBox.Location = new Point(389, 344);
            HelperLabel.Text = str;

            switch (Text)
            {
                case "Main Menu":
                    HelperPictureBox.BackColor = MainMenu.BackColor;
                    HelperLabel.BackColor = MainMenu.BackColor;
                    HelperButtonClose.BackColor = MainMenu.BackColor;
                    break;
                case "Menu":
                    HelperPictureBox.BackColor = Menu.BackColor;
                    HelperLabel.BackColor = Menu.BackColor;
                    HelperButtonClose.BackColor = Menu.BackColor;
                    break;
                case "Instruction":
                    HelperPictureBox.BackColor = Instruction.BackColor;
                    HelperLabel.BackColor = Instruction.BackColor;
                    HelperButtonClose.BackColor = Instruction.BackColor;
                    break;
                case "Literatures":
                    HelperPictureBox.BackColor = Literatures.BackColor;
                    HelperLabel.BackColor = Literatures.BackColor;
                    HelperButtonClose.BackColor = Literatures.BackColor;
                    break;
                case "Create Lesson":
                    HelperPictureBox.BackColor = CreateLesson.BackColor;
                    HelperLabel.BackColor = CreateLesson.BackColor;
                    HelperButtonClose.BackColor = CreateLesson.BackColor;
                    break;
                case "Technological map":
                    HelperPictureBox.BackColor = TechnologicalMap.BackColor;
                    HelperLabel.BackColor = TechnologicalMap.BackColor;
                    HelperButtonClose.BackColor = TechnologicalMap.BackColor;
                    break;
                case "Other":
                    HelperPictureBox.BackColor = Other.BackColor;
                    HelperLabel.BackColor = Other.BackColor;
                    HelperButtonClose.BackColor = Other.BackColor;
                    break;
            };
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
            TechnologicalMap.Visible = false;
            CreateLesson.Visible = false;
            Other.Visible = false;
            LessonPanel2.Visible = false;
        }
        private void OpenMainMenu()
        {
            Text = "Main Menu";
            CloseAll();
            OpenHelper(MainMenuHelperText);
            int xy = 100;
            HelperLabel.Size = new Size(HelperLabel.Size.Width, HelperLabel.Size.Height+xy);
            HelperLabel.Location = new Point(HelperLabel.Location.X, HelperLabel.Location.Y-xy);
            HelperButtonClose.Location = new Point(HelperButtonClose.Location.X, HelperButtonClose.Location.Y - xy);
            MainMenu.Visible = true;
            MainMenu.Size = new Size(sizeDefault);
            MainMenu.Location = locationDefault;
        }

        private void LessonPoint1Default()
        {
            LessonPoint1X = '#';
            LessonPoint11.BackColor = CreateLesson.BackColor;
            LessonPoint12.BackColor = CreateLesson.BackColor;
            LessonPoint13.BackColor = CreateLesson.BackColor;
            LessonPoint14.BackColor = CreateLesson.BackColor;
            LessonPoint15.BackColor = CreateLesson.BackColor;
            LessonButton1.BackColor = Color.Red;
            LessonPanel2.Visible = false;
        }

        private void OpenMainMenuOrMenu(object sender, EventArgs e)
        {
            if (Text == "Instruction" || Text == "Literatures" || Text == "Menu")
            {
                OpenMainMenu();
            }else
            if (Text == "Main Menu" || Text=="Create Lesson" || Text=="Technological map" || Text == "Other")
            {
                if (Text == "Create Lesson" && LessonPoint1X != '#')
                {
                    LessonPoint1Default();
                }
                else
                    OpenMenu(sender, e);
            }
        }
        private void OpenInstruction(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Instruction";
            OpenHelper(InstructionHelperText);
            Instruction.Visible = true;
            Instruction.Size = new Size(sizeDefault);
            Instruction.Location = locationDefault;
            InstructionRichText.Size = new Size(200, 590);


            HelperLabel.Location = new Point(280, 230);
            HelperButtonClose.Location = new Point(263+260, 204);
            HelperPictureBox.Location = new Point(389, 344);

        }
        private void OpenLiteratures(object sender, EventArgs e)
        {
            Text = "Literatures";
            CloseAll();
            Literatures.Visible = true;
            Literatures.Size = new Size(sizeDefault);
            Literatures.Location = locationDefault;
            MainMenuCloseHelper(sender, e);
        }
        private void MainMenuButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OpenMenu(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Menu";
            OpenHelper(MenuHelperText);
            Menu.Visible = true;
            Menu.Size = new Size(sizeDefault);
            Menu.Location = locationDefault;
        }
        private void MainMenuCloseHelper(object sender, EventArgs e)
        {
            HelperPictureBox.Visible = false;
            HelperLabel.Visible = false;
            HelperButtonClose.Visible = false;
            InstructionRichText.Size = new Size(420, 590);

            HelperLabel.Location = new Point(226, 230);
            HelperButtonClose.Location = new Point(226, 204);
            HelperPictureBox.Location = new Point(389, 344);

        }
        private void OpenCreateLesson(object sender,EventArgs e)
        {
            CloseAll();
            Text = "Create Lesson";
            CreateLesson.Visible = true;
            CreateLesson.Location = locationDefault;
            CreateLesson.Size = new Size(sizeDefault);

            OpenHelper(CreateLessonText);
            HelperLabel.Location = new Point(280, 230);
            HelperButtonClose.Location = new Point(263 + 260, 204);
            HelperPictureBox.Location = new Point(389, 344);
            HelperNewLocation(-50, 100);

            LessonPoint1Default();
        }
        private void OpenTechnologicalMap(object sender,EventArgs e)
        {
            CloseAll();
            Text = "Technological map";
            TechnologicalMap.Visible = true;
            TechnologicalMap.Location = locationDefault;
            TechnologicalMap.Size = new Size(sizeDefault);
        }
        private void OpenOther(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Other";
            Other.Visible = true;
            Other.Location = locationDefault;
            Other.Size = new Size(sizeDefault);
        }

        public void OpenLessonPoint2X()
        {
            switch (LessonPoint1X)
            {
                case '1':

                    break;
                case '2':

                    break;
                case '3':

                    break;
                case '4':

                    break;
                case '5':

                    break;
            }
        }
        private void LessonPoint11_Click(object sender, EventArgs e)
        {
            LessonPoint1Default();
            LessonPoint11.BackColor=Color.Teal;
            LessonPoint1X = '1';
            LessonButton1.BackColor = Color.Green;
        }

        private void LessonPoint12_Click(object sender, EventArgs e)
        {
            LessonPoint1Default();
            LessonPoint12.BackColor = Color.Teal;
            LessonPoint1X = '2';
            LessonButton1.BackColor = Color.Green;
        }

        private void LessonPoint13_Click(object sender, EventArgs e)
        {
            LessonPoint1Default();
            LessonPoint13.BackColor = Color.Teal;
            LessonPoint1X = '3';
            LessonButton1.BackColor = Color.Green;
        }

        private void LessonPoint14_Click(object sender, EventArgs e)
        {
            LessonPoint1Default();
            LessonPoint14.BackColor = Color.Teal;
            LessonPoint1X = '4';
            LessonButton1.BackColor = Color.Green;
        }

        private void LessonPoint15_Click(object sender, EventArgs e)
        {
            LessonPoint1Default();
            LessonPoint15.BackColor = Color.Teal;
            LessonPoint1X = '5';
            LessonButton1.BackColor = Color.Green;
        }

        private void LessonButton1_Click(object sender, EventArgs e)
        {
            LessonPanel2.Visible = true;

        }

        //public class ClassTechnicalMaps
        //{
        //    public RichTextBox TTechnicalMap = new RichTextBox();
        //    public RichTextBox TTeacher = new RichTextBox();
        //    public RichTextBox TGroup = new RichTextBox();
        //    public RichTextBox TSubject = new RichTextBox();
        //    public RichTextBox TLessonTopic = new RichTextBox();
        //    public DateTimePicker TDate = new DateTimePicker();
        //    public RichTextBox TTask1 = new RichTextBox();
        //    public RichTextBox TTask2 = new RichTextBox();
        //    public RichTextBox TTask3 = new RichTextBox();
        //    public RichTextBox TResult1 = new RichTextBox();
        //    public RichTextBox TResult2 = new RichTextBox();
        //    public RichTextBox TResult3 = new RichTextBox();
        //    public RichTextBox TFCR1 = new RichTextBox();
        //    public RichTextBox TFCR2 = new RichTextBox();
        //    public RichTextBox TFCR3 = new RichTextBox();
        //    public RichTextBox TResource1 = new RichTextBox();
        //    public RichTextBox TResource2 = new RichTextBox();
        //    public RichTextBox TTAPL1 = new RichTextBox();
        //    public RichTextBox TTAPL2 = new RichTextBox();
        //    public ClassTechnicalMaps()
        //    {
        //        TTechnicalMap.Text = "";
        //        TTeacher.Text = "";
        //        TGroup.Text = "";
        //        TSubject.Text = "";
        //        TLessonTopic.Text = "";
        //        TDate.Text = "";
        //        TTask1.Text = "";
        //        TTask2.Text = "";
        //        TTask3.Text = "";
        //        TResult1.Text = "";
        //        TResult2.Text = "";
        //        TResult3.Text = "";
        //        TFCR1.Text = "";
        //        TFCR2.Text = "";
        //        TFCR3.Text = "";
        //        TResource1.Text = "";
        //        TResource2.Text = "";
        //        TTAPL1.Text = "";
        //        TTAPL2.Text = "";
        //    }
        //};
    }
}