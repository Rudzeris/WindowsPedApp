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
        string MenuHelperText = "'Дополнительно' еще не создано, а создание уроков разрабатывается.";
        string CreateLessonText = "Выберите урок в зависимости от дидактической цели. Здесь только одна кнопка - кнопка по центру.";

        //ClassTechnicalMaps CTM = new ClassTechnicalMaps();

        char LessonPoint1X;
        char LessonPoint2X;

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
            LessonCompletePanel.Visible = false;
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

            LessonPoint21.Visible = true;
            LessonPoint22.Visible = true;
            LessonPoint23.Visible = true;
            LessonPoint24.Visible = true;
            LessonPoint25.Visible = true;
            LessonPoint26.Visible = true;

            LessonPanel2.Visible = false;
        }

        private void LessonPoint2Default()
        {
            LessonPoint2X = '#';
            LessonPoint21.BackColor = CreateLesson.BackColor;
            LessonPoint22.BackColor = CreateLesson.BackColor;
            LessonPoint23.BackColor = CreateLesson.BackColor;
            LessonPoint24.BackColor = CreateLesson.BackColor;
            LessonPoint25.BackColor = CreateLesson.BackColor;
            LessonButton1.BackColor = Color.Green;
        }

        private void ButtonMainBack(object sender, EventArgs e)
        {
            if (Text == "Instruction" || Text == "Literatures" || Text == "Menu")
            {
                OpenMainMenu();
            }else
            if (Text == "Main Menu" || Text=="Create Lesson" || Text=="Technological map" || Text == "Other" || Text == "Lesson Complete")
            {
                if (Text == "Create Lesson" && LessonPoint1X != '#')
                {
                    if (LessonPoint1X != '#' && LessonPoint2X != '#')
                    {
                        LessonPoint2Default();
                        LessonPoint2Enabled(true);
                    }
                    else
                    {
                        LessonPoint1Default();
                        LessonPoint1Enabled(true);
                    }
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
            HelperNewLocation(-30, 140);

            LessonPoint1Default();
            LessonPoint2Default();
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

        public void OpenLessonComplete(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Lesson Complete";
            LessonCompletePanel.Visible = true;
            LessonCompletePanel.Location = locationDefault;
            LessonCompletePanel.Size = new Size(sizeDefault);
            LessonCompleteRichBox.Visible = false;
            LessonCompletePictureBox.Visible = true;
        }

        public void OpenLessonPoint2X()
        {
            switch (LessonPoint1X)
            {
                case '1':
                    LessonPoint21.Text = "Урок экскурсия";
                    LessonPoint22.Text = "Инсценировка";
                    LessonPoint23.Text = "Лекция";
                    LessonPoint24.Text = "Беседа";
                    LessonPoint25.Text = "Встреча";
                    LessonPoint26.Visible = false;
                    break;
                case '2':
                    LessonPoint21.Text = "Урок-суд";
                    LessonPoint22.Text = "Экскурсия";
                    LessonPoint23.Text = "Конференция";
                    LessonPoint24.Text = "Деловая игра";
                    LessonPoint25.Visible = false;
                    LessonPoint26.Visible = false;
                    break;
                case '3':
                    LessonPoint21.Text = "Комбинированный урок";
                    LessonPoint22.Text = "Деловая игра";
                    LessonPoint23.Text = "Практикум";
                    LessonPoint24.Text = "Конкурс";
                    LessonPoint25.Text = "Диспут";
                    LessonPoint26.Text = "Викторина";
                    break;
                case '4':
                    LessonPoint21.Text = "Тест";
                    LessonPoint22.Text = "Устный опрос";
                    LessonPoint23.Text = "Викторина";
                    LessonPoint24.Text = "Коллоквиум";
                    LessonPoint25.Text = "Конкурс";
                    LessonPoint26.Visible = false;
                    break;
                case '5':
                    LessonPoint21.Text = "Зачетное занятие";
                    LessonPoint22.Text = "Экзамен";
                    LessonPoint23.Text = "Семинар";
                    LessonPoint24.Text = "Аукцион знаний";
                    LessonPoint25.Text = "Урок-конкурс";
                    LessonPoint26.Visible = false;
                    break;
            }
        }
        private void LessonPoint1Enabled(bool temp)
        {
            LessonPoint11.Enabled = temp;
            LessonPoint12.Enabled = temp;
            LessonPoint13.Enabled = temp;
            LessonPoint14.Enabled = temp;
            LessonPoint15.Enabled = temp;
        }
        private void LessonPoint2Enabled(bool temp)
        {
            LessonPoint21.Enabled = temp;
            LessonPoint22.Enabled = temp;
            LessonPoint23.Enabled = temp;
            LessonPoint24.Enabled = temp;
            LessonPoint25.Enabled = temp;
            LessonPoint26.Enabled = temp;
        }
        private void LessonPoint11_Click(object sender, EventArgs e)
        {
            LessonPoint1Default();
            LessonPoint11.BackColor=Color.Teal;
            LessonPoint1X = '1';
            LessonButton1.BackColor = Color.Green;
            LessonPoint20.Text = LessonPoint11.Text;
        }

        private void LessonPoint12_Click(object sender, EventArgs e)
        {
            LessonPoint1Default();
            LessonPoint12.BackColor = Color.Teal;
            LessonPoint1X = '2';
            LessonButton1.BackColor = Color.Green;
            LessonPoint20.Text = LessonPoint12.Text;
        }

        private void LessonPoint13_Click(object sender, EventArgs e)
        {
            LessonPoint1Default();
            LessonPoint13.BackColor = Color.Teal;
            LessonPoint1X = '3';
            LessonButton1.BackColor = Color.Green;
            LessonPoint20.Text = LessonPoint13.Text;
        }

        private void LessonPoint14_Click(object sender, EventArgs e)
        {
            LessonPoint1Default();
            LessonPoint14.BackColor = Color.Teal;
            LessonPoint1X = '4';
            LessonButton1.BackColor = Color.Green;
            LessonPoint20.Text = LessonPoint14.Text;
        }

        private void LessonPoint15_Click(object sender, EventArgs e)
        {
            LessonPoint1Default();
            LessonPoint15.BackColor = Color.Teal;
            LessonPoint1X = '5';
            LessonButton1.BackColor = Color.Green;
            LessonPoint20.Text = LessonPoint15.Text;
        }

        private void LessonButton1_Click(object sender, EventArgs e)
        {
            if (LessonPoint1X == '#') return;
            if (LessonPoint2X=='#')
            {
                LessonPanel2.Visible = true;
                MainMenuCloseHelper(sender, e);
                LessonPoint1Enabled(false);
                OpenLessonPoint2X();
            }
            else
            {
                LessonPoint2Enabled(false);
                OpenLessonComplete(sender, e);
            }

        }

        private void LessonPoint21_Click(object sender, EventArgs e)
        {
            LessonPoint2Default();
            LessonPoint21.BackColor = Color.Beige;
            LessonPoint2X = '1';
            LessonButton1.BackColor = Color.Blue;
        }

        private void LessonPoint22_Click(object sender, EventArgs e)
        {
            LessonPoint2Default();
            LessonPoint22.BackColor = Color.Beige;
            LessonPoint2X = '2';
            LessonButton1.BackColor = Color.Blue;
        }

        private void LessonPoint23_Click(object sender, EventArgs e)
        {
            LessonPoint2Default();
            LessonPoint23.BackColor = Color.Beige;
            LessonPoint2X = '3';
            LessonButton1.BackColor = Color.Blue;
        }

        private void LessonPoint24_Click(object sender, EventArgs e)
        {
            LessonPoint2Default();
            LessonPoint24.BackColor = Color.Beige;
            LessonPoint2X = '4';
            LessonButton1.BackColor = Color.Blue;
        }

        private void LessonPoint25_Click(object sender, EventArgs e)
        {
            LessonPoint2Default();
            LessonPoint25.BackColor = Color.Beige;
            LessonPoint2X = '5';
            LessonButton1.BackColor = Color.Blue;
        }

        private void LessonPoint26_Click(object sender, EventArgs e)
        {
            LessonPoint2Default();
            LessonPoint26.BackColor = Color.Beige;
            LessonPoint2X = '6';
            LessonButton1.BackColor = Color.Blue;
        }

        private void LessonStructureButton_Click(object sender, EventArgs e)
        {
            if (LessonCompletePictureBox.Visible == false)
            {
                LessonCompleteRichBox.Visible = true;
                LessonCompletePictureBox.Visible = true;
                LessonStructureButton.Text = "Скрыть структуру";
            }
            else
            {
                LessonCompletePictureBox.Visible = false;
                LessonCompleteRichBox.Visible = true;
                LessonStructureButton.Text = "Показать структуру";
            }
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