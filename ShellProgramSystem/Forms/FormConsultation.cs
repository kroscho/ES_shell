using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShellProgramSystem.Classes;
using ShellProgramSystem.ShellModules;

namespace ShellProgramSystem.Forms
{
    public partial class FormConsultation : Form
    {
        // ----Атрибуты формы
        private ComboBox comboBoxAnswers;
        private Button buttonSendAnswer;
        private Button buttonNewConsultation;
        private Button buttonShowExplanation;


        // ----Атрибуты
        private KnowledgeBase knowledgeBase;
        private InferenceMachine inferenceMachine;
        public ExplanationComponent ExplanationComponent { get; set; }


        // ----Конструкторы
        private void GeneralConstruct()
        {
            // Создаём кнопки и комбобокс (они будут попеременно скрываться, поэтому так)
            // Комбобокс для ответов (первоначально выключен - доступен только при ответе)
            comboBoxAnswers = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Dock = DockStyle.Fill,
                Enabled = false
            };
            tableLayoutPanel1.Controls.Add(comboBoxAnswers, 0, 1);
            tableLayoutPanel1.SetColumnSpan(comboBoxAnswers, 3);
            // Кнопка для ответов (первоначально выключен - доступен только при ответе)
            buttonSendAnswer = new Button
            {
                Text = "Ответить",
                Dock = DockStyle.Fill,
                Enabled = false
            };
            tableLayoutPanel1.Controls.Add(buttonSendAnswer, 3, 1);
            // Кнопка для новой консультации (первоначально скрыта)
            buttonNewConsultation = new Button
            {
                Text = "Начать новую консультацию",
                Dock = DockStyle.Fill,
                Visible = false,
            };
            buttonNewConsultation.Click += OnButtonNewConsultationClick;
            tableLayoutPanel1.Controls.Add(buttonNewConsultation, 0, 1);
            tableLayoutPanel1.SetColumnSpan(buttonNewConsultation, 2);
            // Кнопка для отображения объяснения
            buttonShowExplanation = new Button
            {
                Text = "Показать объяснение",
                Dock = DockStyle.Fill,
                Visible = false
            };
            buttonShowExplanation.Click += OnButtonShowExplanationClick;
            tableLayoutPanel1.Controls.Add(buttonShowExplanation, 2, 1);
            tableLayoutPanel1.SetColumnSpan(buttonShowExplanation, 2);
        }

        // Конструктор по умолчанию
        public FormConsultation()
        {
            InitializeComponent();
            // Создаём кнопки и комбобокс
            GeneralConstruct();
        }

        /// <summary>
        /// Конструктор, создающий форму для консультации и начинающий новую консультацию
        /// </summary>
        /// <param name="knowledgeBase">База знаний, на основании которой будет проводиться консультация</param>
        public FormConsultation(KnowledgeBase knowledgeBase)
        {
            InitializeComponent();
            // Создаём кнопки и комбобокс
            GeneralConstruct();
            // Создаём машину логического вывода
            this.knowledgeBase = knowledgeBase;
            inferenceMachine = new InferenceMachine(knowledgeBase, this);
            // Обнуляем переменную с объяснительной компонентой
            ExplanationComponent = null;
            // Начинаем консультацию
            StartConsultation();
        }

        // ----Приватные методы
        // Метод для размещения нового сообщения в чате
        private void SendMessageToChat(string message, MessageType type)
        {
            // В зависимости от отправителя сообщения меняем цвет сообщения и имя самого отправителя
            string sender;
            Color backColor = Color.Empty;
            if (type == MessageType.User)
            {
                sender = "Вы";
                backColor = Color.LightSkyBlue;
            }
            else
            {
                sender = "Система";
                if (type == MessageType.SystemStandard)
                    backColor = Color.Gainsboro;
                else if (type == MessageType.SystemSuccess)
                    backColor = Color.PaleGreen;
                else if (type == MessageType.SystemFailed)
                    backColor = Color.Pink;
            }
            // Создаём сообщение-лейбл и добавляем его в чат-панель
            Label messageLabel = new Label
            {
                Text = $"{sender}:\n{message}",
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 11),
                BackColor = backColor,
                Margin = (type == MessageType.User) ? new Padding(235, 5, 15, 5) : new Padding(15, 5, 15, 5),
                BorderStyle = BorderStyle.FixedSingle
            };
            flowLayoutPanelChat.Controls.Add(messageLabel);
            // Прокручиваем "чат" вниз - чтобы были видны последние сообщения
            flowLayoutPanelChat.VerticalScroll.Value = flowLayoutPanelChat.VerticalScroll.Maximum;
        }

        // Метод смены отображаемых кнопок (кнопки консультации на кнопки завершения консультации, и наоборот)
        private void ChangeVisibleControls(bool isConsultation)
        {
            comboBoxAnswers.Visible = buttonSendAnswer.Visible = isConsultation;
            buttonNewConsultation.Visible = buttonShowExplanation.Visible = !isConsultation;
        }

        // Метод для блокировки/разблокировки кнопок консультации (кнопки ответа и комбобокса с вариантами)
        private void EnableConsultationControls(bool isEnabled)
        {
            comboBoxAnswers.Enabled = buttonSendAnswer.Enabled = isEnabled;
        }


        // Методы для проведения консультации

        /// Инициализировать новую консультацию
        private void InitializeNewConsultation(string message = null)
        {
            // Чистим чат
            flowLayoutPanelChat.Controls.Clear();
            // Если есть какое-то сообщение, отправляем его в чат
            if (message != null)
                SendMessageToChat(message, MessageType.SystemStandard);
            // Добавляем кнопки для вопросов и убираем кнопки показа объяснений и начала новой консультации
            ChangeVisibleControls(true);
            // Блокируем кнопки для вопросов
            EnableConsultationControls(false);
        }

        // Начать новую консультацию
        public async void StartConsultation()
        {
            InitializeNewConsultation();
            // Спрашиваем переменную цели - она может быть только выводимой переменной
            var deducedVariables = knowledgeBase.Variables.Where(v => v.Type == VariableType.Deduced).ToList<object>();
            Variable goalVariable = (Variable)await GetAnswerAsync("Какова цель консультации?", deducedVariables);
            DomainValue goalValue = await inferenceMachine.StartConsultation(goalVariable);
            // Создаём объяснительную компоненту для завершившейся консультации, которая строит её объяснение
            ExplanationComponent = new ExplanationComponent(inferenceMachine.WorkingMemory);
            if (goalValue != null)
                SendMessageToChat($"{goalVariable.Name}: {goalValue}", MessageType.SystemSuccess);
            else
                SendMessageToChat("Цель консультации достигнуть не удалось. Попробовать снова?", MessageType.SystemFailed);
            ChangeVisibleControls(false);
        }

        // Метод для задания вопроса пользователю и получения ответа (одного из доступных).
        // * Необходимо использовать только как асинхронный метод. Синхронное использование
        // приведёт к состоянию блокировки основого потока программы

        /// <param name="question">Вопрос, который будет напечатан пользователю в чате</param>
        /// <param name="answerOptions">Все возможные варианты ответов, из которых будет выбирать пользователь</param>
        /// <returns>Выбранный ответ</returns>
        public async Task<object> GetAnswerAsync(string question, List<object> answerOptions)
        {
            if (answerOptions.Count == 0)
                throw new ArgumentException("Вопрос должен иметь по крайней мере один возможный ответ!");
            // Очищаем комбобокс с ответами и заполяем его заданными ответами, выбираем в нём первый ответ
            comboBoxAnswers.Items.Clear();
            foreach (var option in answerOptions)
                comboBoxAnswers.Items.Add(option);
            comboBoxAnswers.SelectedIndex = 0;
            // Отправляем вопрос в чат
            SendMessageToChat(question, MessageType.SystemStandard);
            // Разблокируем комбобокс и кнопку отправки ответа
            EnableConsultationControls(true);
            // Запускаем задачу ожидания ответа пользователя и дожидаемся её завершения
            await Task.Run(() => {
                // Создаём событие, флаг которого опущен
                AutoResetEvent arEvent = new AutoResetEvent(false);
                // При нажатии кнопки будем поднимать флаг события
                EventHandler handler = (sender, args) => {
                    arEvent.Set();
                };
                buttonSendAnswer.Click += handler;
                // Ждём поднятия флага
                arEvent.WaitOne();
                buttonSendAnswer.Click -= handler;
            });
            // Получаем данный ответ
            object answer = comboBoxAnswers.SelectedItem;
            // Отправляем ответ в чат
            SendMessageToChat(answer.ToString(), MessageType.User);
            // Чистим комбобокс с ответами
            comboBoxAnswers.Items.Clear();
            // Блокируем все кнопки консультации до следующего вопроса
            EnableConsultationControls(false);
            // Возвращаем полученный ответ
            return answer;
        }

        // ----Обработчики событий нажатия кнопок для показа объяснения и начала новой консультации
        private void OnButtonNewConsultationClick(object sender, EventArgs args)
        {
            StartConsultation();
        }

        private void OnButtonShowExplanationClick(object sender, EventArgs args)
        {
            FormExplanation formExplanation = new FormExplanation(ExplanationComponent);
            formExplanation.ShowDialog();
        }
    }
}
