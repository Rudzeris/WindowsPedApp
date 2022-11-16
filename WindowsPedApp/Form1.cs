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
                    LessonCompleteRichBox.Text = "Это урок, на котором педагог объясняет новый материал. Он строится в соответствии с требованиями ФГОС несколько иначе, нежели прежде. \r\n• В начале следует провести этап мотивации, который, впрочем, немногим отличается от прежнего оргмомента. \r\n• Затем следует этап актуализации изученного (повторения) с попыткой решить проблемную задачу, опираясь лишь на уже известную информацию. \r\n• Вывод о необходимости еще какого-то знания и получение его тем или иным способом (например, в процессе наблюдения или эксперимента). Это так называемое первичное усвоение материала. \r\nА далее: \r\n• Этап самостоятельного осмысления; в его ходе школьники выполняют работу самостоятельно. \r\n• Проверка. Обсуждение вопроса, какое место занимает новое знание в общей системе знаний, каковы возможности его практического применения. \r\n• Инструктаж по домашнему заданию; рефлексия. Разумеется, это приблизительный план хода урока. При этом решаются различные задачи: образовательные (научить, познакомить, проанализировать и т.д.), воспитательные (формировать познавательную и творческую активность, любовь к Родине, к природе, к литературе, воспитывать упорство, любознательность и проч.) и развивающие (формировать умение анализировать, сопоставлять, читать схемы, пользоваться справочной литературой и т.п.).\r\n";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case '1':
                            LessonCompleteRichBox.Text += "Для достижения поставленных целей в современных условиях актуально проведение занятий с использованием экскурсий.\r\n Производственные или учебные экскурсии (ПЭ) - это одна из многочисленных форм профориентационной работы с учащимися. Они имеют большое образовательное, политехническое и воспитательное значение.\r\nПЭ служит формой наглядного ознакомления учащихся с техникой и технологией, организацией производства, содержанием труда, условиями труда и пр.\r\nВ основном ПЭ рассматриваются как средство формирования и развития у студентов интереса к различным профессиям. Однако ПЭ - это не только одна из форм внеурочной деятельности педагога по оказанию помощи студентам в их профессиональном самоопределении. ПЭ предусматриваются и учебными программами.\r\nОсновная цель ПЭ - расширение политехнического образования студентов . Экскурсия на какое-либо предприятие, проводимая в органичной связи с содержанием учебных дисциплин, показывает неразрывную связь теории и практики в производственной деятельности людей.\r\n\r\nЭкскурсия (от лат. excursio — прогулка, поездка) — коллективное посещение музея, достопримечательного места, выставки, предприятия и т.п.; поездка, прогулка с образовательной, научной, спортивной или увеселительной целью.\r\nУчебная экскурсия — это проведение учебного занятия в условиях производства, природы, музея с целью наблюдения и изучения студентами различных объектов и явлений действительности.\r\n Являясь самостоятельной формой обучения, экскурсия входит важной составной частью в систему учебно-воспитательной работы и вносит свой весомый вклад в формирование всесторонне развитой личности.\r\nПеред экскурсиями ставятся такие задачи: обогащать знания студентов  (на основе непосредственного восприятия, накопления наглядных представлений и фактов); устанавливать связи теорий с практикой, с жизненными явлениями и процессами; развивать творческие способности студентов (учащихся), их самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи; обогащать эстетические чувства; развивать наблюдательность, память, мышление, эмоции; активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению. Экскурсия дает широкие возможности для более полного, комплексного использования методов обучения (и в первую очередь проблемных).\r\nВажнейшее назначение учебных экскурсий заключается в выявлении жизненности и актуальности учебного материала, в закреплении и конкретизации знаний, полученных на уроках, в применении знаний и умений на практике. Наглядность — существеннейший признак учебной экскурсии: удельный вес зрительной и слуховой наглядности в получении информации на экскурсии составляет более 70 процентов. Благодаря наглядности студенты (учащиеся) быстрее усваивают знания, которые затем на учебных занятиях становятся опорным фактическим материалом при восприятии новой темы, при обобщении и формировании соответствующих выводов. Экскурсионные наблюдения используются также для проверки, исправления, уточнения уже имеющихся у студентов (учащихся) знаний и представлений, для обогащения их новыми конкретными данными. Так, на экскурсии на промышленное или сельскохозяйственное предприятие происходит наглядное знакомство с практической деятельностью людей, с непосредственным использованием научных знаний, основы которых изучаются на занятии, формируются представления о производственных процессах, организации производства, отношениях в коллективе.\r\nНаблюдая и познавая явления общественной жизни, студенты (учащиеся) сами готовятся к активному участию в различных сферах общественно полезной деятельности.\r\nСтуденты (учащиеся) должны быть осведомлены о развитии и достижениях современной науки и техники.  К сожалению не урок, не факультатив, не просмотр научно- популярного фильма или специальной телепередачи не оказывает на студентов (учащихся) такого влияния, как полное впечатлений непосредственное соприкосновение с технологическим процессом производства. Во время экскурсии студенты (учащиеся) переносят знания в новую ситуацию, открывают для себя новые способы решения познавательных задач.( см. приложение).\r\n В зависимости от типа, содержания и метода проведения экскурсии, возраста студентов (учащихся), местных условий и вида передвижения в состав экскурсионной группы может входить от десяти до сорока студентов.\r\nДлительность учебной экскурсии  определяется в зависимости от учебных задач, конкретных условий проведения.\r\nКаждая экскурсия связана с учебным материалом разных дисциплин\r\nпо профессиям.\r\nЭтапы подготовки экскурсии\r\n \r\n1.     Определение цели и задачи экскурсии.\r\n2.     Выбор темы.\r\n3.     Отбор и изучение экскурсионных объектов.\r\n4.     Составление маршрута экскурсии.\r\n5.     Разработка заданий для учащихся.\r\n6.     Составление методической разработки.\r\n Цель экскурсии: наглядное ознакомление студентов (учащихся) с техникой и технологией , организации с/х  производства.\r\nЗадачи экскурсии:\r\n1. обогащать знания студентов (учащихся) на основе непосредственного восприятия, накопления наглядных представлений и фактов;\r\n2. устанавливать связи теорий с практикой, с жизненными явлениями и процессами\r\n3. развивать творческие способности студентов (учащихся),\r\n4. развивать самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи;\r\n5. развивать наблюдательность, память, мышление, эмоции;\r\n6.активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению. \r\n В процессе подготовки экскурсии при отборе объектов проводится их оценка по следующим показателям (критериям):\r\n1.     познавательная ценность;\r\n2.     известность (популярность);\r\n3.     месторасположение.\r\nПо мере сбора сведений об объекте студентам (учащимся) рекомендуется составить портфолио, в которое вносятся следующие сведения:\r\n1.     наименование объекта;\r\n2.     завод-изготовитель;\r\n3.     техническая характеристика.\r\n4.     назначение и место в технологическом процессе;\r\n5.     особенности конструкции\r\n\r\nПроведение экскурсии.\r\nРазбивка на группы( по 4-5 человек);\r\nВыдача заданий по объектам;\r\nИнструктаж;\r\nСбор информации согласно выданным заданиям.\r\nОбработка собранного материала.\r\nПодготовка к конференции:  презентация, фильм, репортаж, фотообозрение, доклад, плакаты и т. д\r\n";
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
                    LessonCompleteRichBox.Text = "• Первый этап. Организационный этап\r\nОрганизационный этап, очень кратковременный, определяет весь психологический настрой урока. Психологический настрой проводится для создания благоприятной рабочей обстановки, чтобы обучающиеся поняли, что им рады, их ждали.\r\n• Второй этап. Проверка домашнего задания, воспроизведение и коррекция опорных знаний\r\nВыявить пробелы в знаниях и способах деятельности обучающихся.\r\n• Третий этап. Постановка цели и задач урока. Мотивация учебной деятельности \r\nЭто обязательный этап по ФГОС. На данном этапе педагогу необходимо создать проблемную ситуацию так, чтобы студенты сами назвали цель урока, а также саму тему. Результативность учебно-воспитательного процесса, состояние познавательной активности зависят от осознанности обучающегося цели деятельности.\r\nПрактические приемы: опорные схемы, диалог, мозговой штурм, мозговая атака, постановка проблемных вопросов, игровые моменты, раскрытие практической значимости темы, использование музыки и других эстетических средств.\r\n• Четвёртый этап. Первичное закрепление в знакомой ситуации\r\n• Пятый этап. Творческое применение и добывание знаний в новой ситуации (проблемные задания)\r\n• Шестой этап. Информация о домашнем задании, инструктаж по его выполнению\r\nЦель этапа: расширить и углубить знания, умения, полученные на уроке.\r\nЗадачи этапа:\r\n— разъяснить методику выполнения домашнего задания;\r\n— обобщить и систематизировать знания;\r\n— способствовать применению знаний, умений, навыков в разных условиях;\r\n— применить дифференцированный подход.\r\nДомашние задания могут быть: устными или письменными; обычными или программированными; долгосрочными или краткосрочными; требовать от студентов различных усилий мысли (репродуктивные, конструктивные, творческие).\r\n• Седьмой этап. Рефлексия (подведение итогов занятия)\r\nРефлексия — самоанализ и самооценка своей деятельности. Если говорить о рефлексии как этапе урока, то это оценивание своего состояния, эмоций, результатов своей деятельности на занятии.\r\n";
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