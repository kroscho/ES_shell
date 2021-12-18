using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShellProgramSystem.Forms;
using ShellProgramSystem.Classes;

namespace ShellProgramSystem.Forms
{
    public partial class FormRuleFactEdit : Form
    {
        private KnowledgeBase KnowledgeBase { get; set; }

        // Копия изменяемого факта и результат работы формы после нажатия кнопки "ОК"
        public RuleFact CurrentRuleFact { get; private set; }
        private RuleFactType FactType { get; set; }

        /// Флаг, который указывает на то, были ли добавлены новые переменные в процессе редактирования факта правила
        public bool IsVariablesAdded { get; set; }
   
        // Флаг, который указывает на то, были ли добавлены новые домены в процессе редактирования факта правила
        public bool IsDomainsAdded { get; set; }

        // Заполнить комбобокс операций
        void FillOperationCombobox()
        {
            comboBoxOperation.Items.Clear();
            comboBoxOperation.Items.Add(OperationExtensions.ToText(Operation.Equal));
            comboBoxOperation.SelectedIndex = 0;
            comboBoxOperation.Enabled = false;
            // Пока у нас одна операция - равенство
        }

        // Метод обновления свойства Enabled элементов управления
        void UpdateEnabledPropertyOfControls()
        {
            // Переменная
            bool isVariableSelected = comboBoxVariable.Items.Count != 0 && comboBoxVariable.SelectedIndex != -1;
            // Операция
            bool isOperationSelected = comboBoxOperation.Items.Count != 0 && comboBoxOperation.SelectedIndex != -1;
            // Значение
            bool isValueSelected = comboBoxValue.Items.Count != 0 && comboBoxValue.SelectedIndex != -1;

            buttonOK.Enabled = (!isVariableSelected || !isOperationSelected || !isValueSelected) ? false : true;
        }

        // Заполнить комбобокс данными о переменных
        // selectCurrentVariable - выбирается ли текущая переменная, установленная в факте
        private void FillVariableComboBox()
        {
            comboBoxVariable.Items.Clear();
            // Если это факт заключения, то можно использовать только выводимые переменные (и выводимо-запрашиваемые)
            foreach (var variable in KnowledgeBase.Variables)
                if (FactType == RuleFactType.ConclusionFact)
                {
                    if (variable.Type == VariableType.Deduced || variable.Type == VariableType.DeducedRequested)
                        comboBoxVariable.Items.Add(variable);
                }
                else
                {
                    comboBoxVariable.Items.Add(variable);
                }
        }

        // Заполнить комбобокс значений на основе выбранной переменной и её домена
        // selectCurrentVariable - выбирается ли текущая переменная, установленная в факте
        private void FillValuesCombobox()
        {
            if (comboBoxVariable.SelectedIndex == -1)
                return;
            comboBoxValue.Items.Clear();
            Variable selectedVariable = (Variable)comboBoxVariable.SelectedItem;
            foreach (var value in selectedVariable.Domain.Values)
                comboBoxValue.Items.Add(value);
        }

        // Заполнить все поля формы данными факта
        private void ChoiceCurrentRuleFactData()
        {
            if (CurrentRuleFact == null)
                return;
            comboBoxVariable.SelectedItem = CurrentRuleFact.Variable;
            comboBoxOperation.SelectedIndex = 0; // пока у нас только одна операция
            comboBoxValue.SelectedItem = CurrentRuleFact.Value;
        }

        // Конструкторы
        private void GeneralConstruct(KnowledgeBase knowledgeBase, RuleFactType factType, RuleFact fact, string text)
        {
            KnowledgeBase = knowledgeBase;
            CurrentRuleFact = fact != null ? (RuleFact)fact.Clone() : null;
            FactType = factType;
            Text = text;
            FillVariableComboBox();
            FillOperationCombobox();
            FillValuesCombobox();
            ChoiceCurrentRuleFactData();
            UpdateEnabledPropertyOfControls();
            IsVariablesAdded = IsDomainsAdded = false;
        }

        public FormRuleFactEdit(KnowledgeBase knowledgeBase, RuleFactType factType)
        {
            InitializeComponent();
            string text = "Название формы";
            if (factType == RuleFactType.PremiseFact)
                text = "Создание факта посылки";
            else if (factType == RuleFactType.ConclusionFact)
                text = "Создание факта заключения";
            GeneralConstruct(knowledgeBase, factType, null, text);
        }

        public FormRuleFactEdit(KnowledgeBase knowledgeBase, RuleFactType factType, RuleFact fact)
        {
            InitializeComponent();
            string text = "Название формы";
            if (factType == RuleFactType.PremiseFact)
                text = "Изменение факта посылки";
            else if (factType == RuleFactType.ConclusionFact)
                text = "Изменение факта заключения";
            GeneralConstruct(knowledgeBase, factType, fact, text);
        }


        // Обработчики событий формы
        private void comboBoxVariable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentRuleFact != null)
                CurrentRuleFact.Variable = (Variable)comboBoxVariable.SelectedItem;
            FillValuesCombobox();
            UpdateEnabledPropertyOfControls();
        }

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Других операций пока нет
            UpdateEnabledPropertyOfControls();
        }

        private void comboBoxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentRuleFact != null)
                CurrentRuleFact.Value = (DomainValue)comboBoxValue.SelectedItem;
            UpdateEnabledPropertyOfControls();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboBoxVariable.SelectedIndex == -1 || comboBoxOperation.SelectedIndex == -1 || comboBoxValue.SelectedIndex == -1)
                return;
            if (CurrentRuleFact == null)
            {
                CurrentRuleFact =
                    new RuleFact((Variable)comboBoxVariable.SelectedItem,
                        OperationExtensions.FromText((string)comboBoxOperation.SelectedItem), (DomainValue)comboBoxValue.SelectedItem);
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonAddVariable_Click(object sender, EventArgs e)
        {
            FormVariableEdit formVariableEdit = new FormVariableEdit(KnowledgeBase);
            DialogResult dlgRes = formVariableEdit.ShowDialog();
            FillVariableComboBox();
            if (dlgRes == DialogResult.OK)
            {
                // Если при добавлении заключения была добавлена запрашиваемая переменная, мы её в combobox не выбираем - её там нет.
                // А иначе - выбираем добавленную переменную (последнюю).
                if (FactType != RuleFactType.ConclusionFact || KnowledgeBase.Variables[KnowledgeBase.Variables.Count - 1].Type != VariableType.Requested)
                    comboBoxVariable.SelectedIndex = comboBoxVariable.Items.Count - 1;
                IsVariablesAdded = true;
            }
            IsDomainsAdded = IsDomainsAdded || formVariableEdit.IsDomainsAdded;
        }
    }
}
