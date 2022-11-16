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
            TestPanel.Visible = false;
            MethodicalPanel.Visible = false;
            MethodicalTextPanel.Visible = false;
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
            }
            else
            if (Text == "Main Menu" || Text == "Create Lesson" || Text == "Technological map" || Text == "Other" || Text == "Lesson Complete")
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
            else
                if (Text == "Test")
            {

                if (TestButtonResult.BackColor != Color.Blue)
                {
                    OpenOther(sender, e);
                }
                else
                {
                    OpenTest(sender, e);
                }
            }
            else if (Text == "Methodical receptions")
            {
                OpenOther(sender, e);
            }else if (Text == "Methodical reception")
            {
                OpenMethodical(sender,e);
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


            LessonPoint2Default();
            LessonPoint1Default();
            LessonPoint1Enabled(true);
            LessonPoint2Enabled(true);
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

            CreateLessonRichTextBox();

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

        private void CreateLessonRichTextBox()
        {
            LessonCompleteRichBox.Text = "\t\tВаша рекомендация по созданию урока"; // Начальная инфа
            string text1 = "\n\n"; // 2 отступа вниз после каждого выбора

            // Информация под конец.
            string OsnInf = "";

            switch (LessonPoint1X)
            {
                case '1':
                    LessonCompleteRichBox.Text = "Это урок, на котором педагог объясняет новый материал. Он строится в соответствии с требованиями ФГОС несколько иначе, нежели прежде. \n\t• В начале следует провести этап мотивации, который, впрочем, немногим отличается от прежнего оргмомента. \n\t• Затем следует этап актуализации изученного (повторения) с попыткой решить проблемную задачу, опираясь лишь на уже известную информацию. \n\t• Вывод о необходимости еще какого-то знания и получение его тем или иным способом (например, в процессе наблюдения или эксперимента). Это так называемое первичное усвоение материала. \n\tА далее: \n\t• Этап самостоятельного осмысления; в его ходе школьники выполняют работу самостоятельно. \n\t• Проверка. Обсуждение вопроса, какое место занимает новое знание в общей системе знаний, каковы возможности его практического применения. \n\t• Инструктаж по домашнему заданию; рефлексия. Разумеется, это приблизительный план хода урока. При этом решаются различные задачи: образовательные (научить, познакомить, проанализировать и т.д.), воспитательные (формировать познавательную и творческую активность, любовь к Родине, к природе, к литературе, воспитывать упорство, любознательность и проч.) и развивающие (формировать умение анализировать, сопоставлять, читать схемы, пользоваться справочной литературой и т.п.).\n\t";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case '1':
                            LessonCompleteRichBox.Text += "Для достижения поставленных целей в современных условиях актуально проведение занятий с использованием экскурсий.\n\t Производственные или учебные экскурсии (ПЭ) - это одна из многочисленных форм профориентационной работы с учащимися. Они имеют большое образовательное, политехническое и воспитательное значение.\n\tПЭ служит формой наглядного ознакомления учащихся с техникой и технологией, организацией производства, содержанием труда, условиями труда и пр.\n\tВ основном ПЭ рассматриваются как средство формирования и развития у студентов интереса к различным профессиям. Однако ПЭ - это не только одна из форм внеурочной деятельности педагога по оказанию помощи студентам в их профессиональном самоопределении. ПЭ предусматриваются и учебными программами.\n\tОсновная цель ПЭ - расширение политехнического образования студентов . Экскурсия на какое-либо предприятие, проводимая в органичной связи с содержанием учебных дисциплин, показывает неразрывную связь теории и практики в производственной деятельности людей.\n\t\n\tЭкскурсия (от лат. excursio — прогулка, поездка) — коллективное посещение музея, достопримечательного места, выставки, предприятия и т.п.; поездка, прогулка с образовательной, научной, спортивной или увеселительной целью.\n\tУчебная экскурсия — это проведение учебного занятия в условиях производства, природы, музея с целью наблюдения и изучения студентами различных объектов и явлений действительности.\n\t Являясь самостоятельной формой обучения, экскурсия входит важной составной частью в систему учебно-воспитательной работы и вносит свой весомый вклад в формирование всесторонне развитой личности.\n\tПеред экскурсиями ставятся такие задачи: обогащать знания студентов  (на основе непосредственного восприятия, накопления наглядных представлений и фактов); устанавливать связи теорий с практикой, с жизненными явлениями и процессами; развивать творческие способности студентов (учащихся), их самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи; обогащать эстетические чувства; развивать наблюдательность, память, мышление, эмоции; активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению. Экскурсия дает широкие возможности для более полного, комплексного использования методов обучения (и в первую очередь проблемных).\n\tВажнейшее назначение учебных экскурсий заключается в выявлении жизненности и актуальности учебного материала, в закреплении и конкретизации знаний, полученных на уроках, в применении знаний и умений на практике. Наглядность — существеннейший признак учебной экскурсии: удельный вес зрительной и слуховой наглядности в получении информации на экскурсии составляет более 70 процентов. Благодаря наглядности студенты (учащиеся) быстрее усваивают знания, которые затем на учебных занятиях становятся опорным фактическим материалом при восприятии новой темы, при обобщении и формировании соответствующих выводов. Экскурсионные наблюдения используются также для проверки, исправления, уточнения уже имеющихся у студентов (учащихся) знаний и представлений, для обогащения их новыми конкретными данными. Так, на экскурсии на промышленное или сельскохозяйственное предприятие происходит наглядное знакомство с практической деятельностью людей, с непосредственным использованием научных знаний, основы которых изучаются на занятии, формируются представления о производственных процессах, организации производства, отношениях в коллективе.\n\tНаблюдая и познавая явления общественной жизни, студенты (учащиеся) сами готовятся к активному участию в различных сферах общественно полезной деятельности.\n\tСтуденты (учащиеся) должны быть осведомлены о развитии и достижениях современной науки и техники.  К сожалению не урок, не факультатив, не просмотр научно- популярного фильма или специальной телепередачи не оказывает на студентов (учащихся) такого влияния, как полное впечатлений непосредственное соприкосновение с технологическим процессом производства. Во время экскурсии студенты (учащиеся) переносят знания в новую ситуацию, открывают для себя новые способы решения познавательных задач.( см. приложение).\n\t В зависимости от типа, содержания и метода проведения экскурсии, возраста студентов (учащихся), местных условий и вида передвижения в состав экскурсионной группы может входить от десяти до сорока студентов.\n\tДлительность учебной экскурсии  определяется в зависимости от учебных задач, конкретных условий проведения.\n\tКаждая экскурсия связана с учебным материалом разных дисциплин\n\tпо профессиям.\n\tЭтапы подготовки экскурсии\n\t \t\n1.     Определение цели и задачи экскурсии.\t\n2.     Выбор темы.\t\n3.     Отбор и изучение экскурсионных объектов.\t\n4.     Составление маршрута экскурсии.\t\n5.     Разработка заданий для учащихся.\t\n6.     Составление методической разработки.\n\t Цель экскурсии: наглядное ознакомление студентов (учащихся) с техникой и технологией , организации с/х  производства.\n\tЗадачи экскурсии:\t\n1. обогащать знания студентов (учащихся) на основе непосредственного восприятия, накопления наглядных представлений и фактов;\t\n2. устанавливать связи теорий с практикой, с жизненными явлениями и процессами\t\n3. развивать творческие способности студентов (учащихся),\t\n4. развивать самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи;\t\n5. развивать наблюдательность, память, мышление, эмоции;\t\n6.активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению. \n\t В процессе подготовки экскурсии при отборе объектов проводится их оценка по следующим показателям (критериям):\t\n1.     познавательная ценность;\t\n2.     известность (популярность);\t\n3.     месторасположение.\n\tПо мере сбора сведений об объекте студентам (учащимся) рекомендуется составить портфолио, в которое вносятся следующие сведения:\t\n1.     наименование объекта;\t\n2.     завод-изготовитель;\t\n3.     техническая характеристика.\t\n4.     назначение и место в технологическом процессе;\t\n5.     особенности конструкции\n\t\n\tПроведение экскурсии.\n\tРазбивка на группы( по 4-5 человек);\n\tВыдача заданий по объектам;\n\tИнструктаж;\n\tСбор информации согласно выданным заданиям.\n\tОбработка собранного материала.\n\tПодготовка к конференции:  презентация, фильм, репортаж, фотообозрение, доклад, плакаты и т. д\n\t";
                            break;
                        case '2':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '3':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '4':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '5':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '6':
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
                case '2':
                    LessonCompleteRichBox.Text = "• Первый этап. Организационный этап\n\tОрганизационный этап, очень кратковременный, определяет весь психологический настрой урока. Психологический настрой проводится для создания благоприятной рабочей обстановки, чтобы обучающиеся поняли, что им рады, их ждали.\n\t• Второй этап. Проверка домашнего задания, воспроизведение и коррекция опорных знаний\n\tВыявить пробелы в знаниях и способах деятельности обучающихся.\n\t• Третий этап. Постановка цели и задач урока. Мотивация учебной деятельности \n\tЭто обязательный этап по ФГОС. На данном этапе педагогу необходимо создать проблемную ситуацию так, чтобы студенты сами назвали цель урока, а также саму тему. Результативность учебно-воспитательного процесса, состояние познавательной активности зависят от осознанности обучающегося цели деятельности.\n\tПрактические приемы: опорные схемы, диалог, мозговой штурм, мозговая атака, постановка проблемных вопросов, игровые моменты, раскрытие практической значимости темы, использование музыки и других эстетических средств.\n\t• Четвёртый этап. Первичное закрепление в знакомой ситуации\n\t• Пятый этап. Творческое применение и добывание знаний в новой ситуации (проблемные задания)\n\t• Шестой этап. Информация о домашнем задании, инструктаж по его выполнению\n\tЦель этапа: расширить и углубить знания, умения, полученные на уроке.\n\tЗадачи этапа:\n\t— разъяснить методику выполнения домашнего задания;\n\t— обобщить и систематизировать знания;\n\t— способствовать применению знаний, умений, навыков в разных условиях;\n\t— применить дифференцированный подход.\n\tДомашние задания могут быть: устными или письменными; обычными или программированными; долгосрочными или краткосрочными; требовать от студентов различных усилий мысли (репродуктивные, конструктивные, творческие).\n\t• Седьмой этап. Рефлексия (подведение итогов занятия)\n\tРефлексия — самоанализ и самооценка своей деятельности. Если говорить о рефлексии как этапе урока, то это оценивание своего состояния, эмоций, результатов своей деятельности на занятии.\n\t";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case '1':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '2':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '3':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '4':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '5':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '6':
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
                case '3':
                    LessonCompleteRichBox.Text = "";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case '1':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '2':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '3':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '4':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '5':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '6':
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
                case '4':
                    LessonCompleteRichBox.Text = "";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case '1':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '2':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '3':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '4':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '5':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '6':
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
                case '5':
                    LessonCompleteRichBox.Text = "";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case '1':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '2':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '3':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '4':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '5':
                            LessonCompleteRichBox.Text += "";
                            break;
                        case '6':
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
            }
            LessonCompleteRichBox.Text += text1;
            LessonCompleteRichBox.Text += OsnInf;
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
                LessonCompleteRichBox.Visible = false;
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

        private void TestRadioDefault()
        {
            RadioTB11.Checked = false;
            RadioTB12.Checked = false;
            RadioTB21.Checked = false;
            RadioTB22.Checked = false;
            RadioTB31.Checked = false;
            RadioTB32.Checked = false;
            RadioTB41.Checked = false;
            RadioTB42.Checked = false;
            RadioTB51.Checked = false;
            RadioTB52.Checked = false;
            RadioTB61.Checked = false;
            RadioTB62.Checked = false;
            RadioTB71.Checked = false;
            RadioTB72.Checked = false;
            RadioTB81.Checked = false;
            RadioTB82.Checked = false;
            RadioTB91.Checked = false;
            RadioTB92.Checked = false;
            RadioTB101.Checked = false;
            RadioTB102.Checked = false;
        }

        private void OpenTest(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Test";
            TestPanel.Visible = true;
            TestPanel.Location = locationDefault;
            TestPanel.Size = new Size(sizeDefault);
            TestRadioDefault();
            RadioTBChecked();
        }

        private void OpenMethodical(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Methodical receptions";
            MethodicalPanel.Visible = true;
            MethodicalPanel.Location = locationDefault;
            MethodicalPanel.Size = new Size(sizeDefault);
        }

        private void OpenMethodicalReception()
        {
            CloseAll();
            Text = "Methodical reception";
            MethodicalTextPanel.Visible = true;
            MethodicalTextPanel.Location = locationDefault;
            MethodicalTextPanel.Size = new Size(sizeDefault);
        }

        private void OpenPresent(object sender, EventArgs e)
        {

        }

        private void OpenMotivation(object sender, EventArgs e)
        {

        }

        private void TestResult()
        {
            int k = 0;
            if (RadioTB11.Checked == true) k++;
            if (RadioTB21.Checked == true) k++;
            if (RadioTB31.Checked == true) k++;
            if (RadioTB41.Checked == true) k++;
            if (RadioTB51.Checked == true) k++;
            if (RadioTB61.Checked == true) k++;
            if (RadioTB71.Checked == true) k++;
            if (RadioTB81.Checked == true) k++;
            if (RadioTB91.Checked == true) k++;
            if (RadioTB101.Checked == true) k++;

            if (k >= 8)
            {
                TestBoxResult.Text = "Результат: Вы удовлетворены работой";
            }
            else
            {
                if (k >= 5)
                {
                    TestBoxResult.Text = "Результат: Есть что-то, что вам не понравилось в работе.";
                }
                else
                {
                    TestBoxResult.Text = "Результат: Вам ничего не нравится в работе";
                }
            }
        }

        private void RadioTBChecked()
        {
            int k = 0;
            if(RadioTB11.Checked == true) k++;
            else if(RadioTB12.Checked == true) k++;
            if(RadioTB21.Checked == true) k++;
            else if(RadioTB22.Checked == true) k++;
            if(RadioTB31.Checked == true) k++;
            else if(RadioTB32.Checked == true) k++;
            if(RadioTB41.Checked == true) k++;
            else if(RadioTB42.Checked == true) k++;
            if(RadioTB51.Checked == true) k++;
            else if (RadioTB52.Checked == true) k++;
            if(RadioTB61.Checked == true) k++;
            else if (RadioTB62.Checked == true) k++;
            if(RadioTB71.Checked == true) k++;
            else if (RadioTB72.Checked == true) k++;
            if(RadioTB81.Checked == true) k++;
            else if (RadioTB82.Checked == true) k++;
            if(RadioTB91.Checked == true) k++;
            else if (RadioTB92.Checked == true) k++;
            if(RadioTB101.Checked ==true) k++;
            else if (RadioTB102.Checked == true) k++;

            if (k == 10) TestButtonResult.BackColor = Color.Green;
            else TestButtonResult.BackColor = Color.Red;
        }

        private void RadioTB_Сhecked(object sender, EventArgs e)
        {
            RadioTBChecked();
        }

        private void TestButtonResult_Click(object sender, EventArgs e)
        {
            if (TestButtonResult.BackColor == Color.Green)
            {
                TestResult();
                TestButtonResult.BackColor = Color.Blue;
            }
        }

        private void MethodicalButton1_Click(object sender, EventArgs e)
        {
            OpenMethodicalReception();
            MethodicalTextBox.Text = "\t«ФАНТАСТИЧЕСКАЯ ДОБАВКА» \n\tПреподаватель дополняет реальную ситуацию фантастикой. Вы можете переносить учебную ситуацию на фантастическую планету; перенести реального или литературного героя во времени; рассмотреть изучаемую ситуацию с необычной точки зрения, например, глазами инопланетянина или древнего грека… \n\t«ЭМОЦИОНАЛЬНОЕ ВХОЖДЕНИЕ В УРОК» \n\tПреподаватель начинает урок с \"настройки\". Например, знакомим с планом урока. Это лучше делать в полушуточной манере. Например, так: \"Сначала мы вместе восхитимся глубокими знаниями — а для этого проведем маленький устный опрос. Потом попробуем ответить на вопрос... (звучит тема урока в вопросной форме). Затем потренируем мозги — порешаем задачи. И, наконец, вытащим из тайников памяти кое-что ценное... (называется тема повторения)\". Если есть техническая возможность, хорошей настройкой на урок будет короткая музыкальная фраза. \n\t«ТЕАТРАЛИЗАЦИЯ» \n\tЗнание на время игры становится нашим пространством. Мы погружены в него со всеми своими эмоциями. И замечаем то, что недоступно холодному наблюдателю со стороны. Разыгрывается сценка на учебную тему. \n\t«ПОСЛОВИЦА-ПОГОВОРКА» \n\tПреподаватель начинает урок с пословицы или поговорки, относящейся к теме урока. \n\t«ВЫСКАЗЫВАНИЯ ВЕЛИКИХ» \n\tПреподаватель начинает урок с высказывания выдающегося человека (людей), относящегося к теме урока. \n\t«ЭПИГРАФ» \n\tПреподаватель начинает урок с эпиграфа к данной теме. \n\t«ПРОБЛЕМНАЯ СИТУАЦИЯ»\n\tСоздаётся ситуация противоречия между известным и неизвестным. Последовательность применения данного приема такова: \n\t– Самостоятельное решение \n\t– Коллективная проверка результатов \n\t– Выявление причин разногласий результатов или затруднений выполнения \n\t– Постановка цели урока. \n\t\n\t«ПРОБЛЕМА ПРЕДЫДУЩЕГО УРОКА» \n\tВ конце урока обучающимся предлагается задание, в ходе которого должны возникнуть трудности с выполнением, из-за недостаточности знаний или недостаточностью времени, что подразумевает продолжение работы на следующем уроке. Таким образом, тему урока можно сформулировать накануне, а на следующем уроке лишь восстановить в памяти и обосновать. \n\t«ИНТЕЛЛЕКТУАЛЬНАЯ РАЗМИНКА» \n\tМожно начать урок с интеллектуальной разминки — два-три не слишком сложных вопроса на размышление. С традиционного устного короткого опроса — простого опроса, ибо основная его цель — настроить обучающегося на работу, а не устроить ему стресс с головомойкой.\n\t «НЕСТАНДАРТНЫЙ ВХОД В УРОК» \n\tУниверсальный прием, направленный на включении в активную мыследеятельность с первых минут урока. Преподаватель начинает урок с противоречивого факта, который трудно объяснить на основе имеющихся знаний. \n\t«АССОЦИАТИВНЫЙ РЯД» \n\tК теме или конкретному понятию урока нужно выписать в столбик слова-ассоциации. Выход будет следующим: \n\t• если ряд получился сравнительно правильным и достаточным, дать задание составить определение, используя записанные слова; \n\t• затем выслушать, сравнить со словарным вариантом, можно добавить новые слова в ассоциативный ряд;\n\t • оставить запись на доске, объяснить новую тему, в конце урока вернуться, что-либо добавить или стереть.\n\t";
        }

        private void MethodicalButton2_Click(object sender, EventArgs e)
        {
            OpenMethodicalReception();
            MethodicalTextBox.Text = "";
        }

        private void MethodicalButton3_Click(object sender, EventArgs e)
        {
            OpenMethodicalReception();
            MethodicalTextBox.Text = "";
        }

        private void MethodicalButton4_Click(object sender, EventArgs e)
        {
            CloseAll();
            OpenMethodicalReception();
            MethodicalTextBox.Text = "";
        }

        private void MethodicalButton5_Click(object sender, EventArgs e)
        {
            OpenMethodicalReception();
            MethodicalTextBox.Text = "";
        }

        private void MethodicalButton6_Click(object sender, EventArgs e)
        {
            CloseAll();
            OpenMethodicalReception();
            MethodicalTextBox.Text = "";
        }

        private void MethodicalButton7_Click(object sender, EventArgs e)
        {
            OpenMethodicalReception();
            MethodicalTextBox.Text = "";
        }

        private void MethodicalButton8_Click(object sender, EventArgs e)
        {
            OpenMethodicalReception();
            MethodicalTextBox.Text = "";
        }

        private void MethodicalButton9_Click(object sender, EventArgs e)
        {
            OpenMethodicalReception();
            MethodicalTextBox.Text = "";
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