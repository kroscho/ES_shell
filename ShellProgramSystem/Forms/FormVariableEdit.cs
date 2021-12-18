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
using Rule = ShellProgramSystem.Classes.Rule;

namespace ShellProgramSystem.Forms
{
    public partial class FormVariableEdit : Form
    {
        private KnowledgeBase KnowledgeBase { get; set; }
     
        // Индекс изменяемой переменной в коллекции Variables базы знаний KnowledgeBase.
        // Если создаётся новая переменная, равен -1.
        private int EditingVariableIndex { get; set; }
 
        // Флаг, который указывает на то, были ли добавлены новые домены в процессе редактирования переменной
        public bool IsDomainsAdded { get; set; }
        private bool IsQuestionByUser { get; set; }

        // Метод обновления свойства Enabled элементов управления
        void UpdateEnabledPropertyOfControls()
        {
            // Имя переменной
            bool isNameEntered = !string.IsNullOrEmpty(textBoxVariableName.Text.Trim());
            // Текст вопроса
            bool isQuestionMustBe = radioButtonRequestedVarType.Checked || radioButtonDedRequestedVarType.Checked;
            textBoxQuestionText.Enabled = isQuestionMustBe;
            if (radioButtonDeducedVarType.Checked)
                textBoxQuestionText.Text = "";
            else
                textBoxQuestionText.Text = $"{textBoxVariableName.Text}?";
            bool isQuestionEntered = isQuestionMustBe ? (!string.IsNullOrEmpty(textBoxQuestionText.Text.Trim())) : true;
            // Тип переменной
            bool isTypeSelected = isQuestionMustBe || radioButtonDeducedVarType.Checked;
            // Домен
            bool isDomainSelected = comboBoxDomain.Items.Count != 0 && comboBoxDomain.SelectedIndex != -1;
            
            buttonOk.Enabled = (!isNameEntered || !isQuestionEntered || !isTypeSelected || !isDomainSelected) ? false : true;
        }

        // Заполнить комбобокс данными о доменах
        private void FillDomainsComboBox()
        {
            comboBoxDomain.Items.Clear();
            foreach (var domain in KnowledgeBase.Domains)
                comboBoxDomain.Items.Add(domain);
        }

        // Заполнить все поля формы данными переменной с заданным индексом
        private void FillVariableControls()
        {
            if (EditingVariableIndex == -1)
            {
                textBoxVariableName.Text = KnowledgeBase.GetNextVariableName();
                return;
            }
            Variable currentVariable = KnowledgeBase.Variables[EditingVariableIndex];
            textBoxVariableName.Text = currentVariable.Name;
            textBoxQuestionText.Text = currentVariable.QuestionText;

            switch (currentVariable.Type)
            {
                case VariableType.Requested:
                    radioButtonRequestedVarType.Checked = true;
                    break;
                case VariableType.Deduced:
                    radioButtonDeducedVarType.Checked = true;
                    break;
                case VariableType.DeducedRequested:
                    radioButtonDedRequestedVarType.Checked = true;
                    break;
                default:
                    radioButtonRequestedVarType.Checked = true;
                    break;
            }
            comboBoxDomain.SelectedItem = currentVariable.Domain;
        }

        // Конструкторы
        private void GeneralConstruct(KnowledgeBase knowledgeBase, int variableIndex, string text)
        {
            KnowledgeBase = knowledgeBase;
            EditingVariableIndex = variableIndex;
            Text = text;
            FillDomainsComboBox();
            FillVariableControls();
            UpdateEnabledPropertyOfControls();
            IsDomainsAdded = false;
        }

        public FormVariableEdit(KnowledgeBase knowledgeBase)
        {
            InitializeComponent();
            GeneralConstruct(knowledgeBase, -1, "Создание переменной");
            IsQuestionByUser = false;
        }

        public FormVariableEdit(KnowledgeBase knowledgeBase, int variableIndex)
        {
            InitializeComponent();
            GeneralConstruct(knowledgeBase, variableIndex, "Изменение переменной");
            IsQuestionByUser = true;
        }

        // Обработчики событий формы

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxVariableName_TextChanged(object sender, EventArgs e)
        {
            if (!IsQuestionByUser)
            {
                if (radioButtonDeducedVarType.Checked)
                    textBoxQuestionText.Text = "";
                else
                    textBoxQuestionText.Text = $"{textBoxVariableName.Text}?";
                
            }
            UpdateEnabledPropertyOfControls();
        }

        private void comboBoxDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEnabledPropertyOfControls();
        }

        private void buttonAddDomain_Click(object sender, EventArgs e)
        {
            FormDomainEdit formDomainEdit = new FormDomainEdit(KnowledgeBase);
            if (formDomainEdit.ShowDialog() == DialogResult.OK)
            {
                FillDomainsComboBox();
                comboBoxDomain.SelectedIndex = comboBoxDomain.Items.Count - 1; // выбираем добавленный домен
                IsDomainsAdded = true;
            }
        }

        private void textBoxQuestionText_TextChanged(object sender, EventArgs e)
        {
            UpdateEnabledPropertyOfControls();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Variable variable;
            string variableName = textBoxVariableName.Text.Trim().Replace('\n', ' ');
            string questionText = textBoxQuestionText.Text.Trim();
            VariableType type;
            if (radioButtonRequestedVarType.Checked)
                type = VariableType.Requested;
            else if (radioButtonDeducedVarType.Checked)
                type = VariableType.Deduced;
            else if (radioButtonDedRequestedVarType.Checked)
                type = VariableType.DeducedRequested;
            else
                type = VariableType.Requested;
            // Проверим, можем ли мы изменить эту переменную
            if (EditingVariableIndex != -1)
            {
                variable = KnowledgeBase.Variables[EditingVariableIndex];
                List<Rule> rulesUsing = KnowledgeBase.GetRulesUsingVariable(variable);
                if (rulesUsing != null)
                {
                    string rulesString = KnowledgeBase.GetRulesNamesString(rulesUsing);
                    if (variable.Domain != (Domain)comboBoxDomain.SelectedItem)
                    {
                        MessageBox.Show($"Эта переменная используется правилами: {rulesString}.\nВы не можете изменить её домен.",
                                    "Действие недоступно", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (variable.Type != type)
                    {
                        MessageBox.Show($"Эта переменная используется правилами: {rulesString}.\nВы не можете изменить её тип.",
                                    "Действие недоступно", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (variable.Name != variableName || variable.QuestionText != questionText)
                    {
                        DialogResult answer =
                            MessageBox.Show($"Эта переменная используется правилами: {rulesString}.\nВы действительно хотите изменить её название/текст вопроса?",
                                                "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (answer == DialogResult.No)
                            return;
                    }
                }
            }
            // Проверим, существует ли переменная с таким именем (помимо самой изменяемой переменной). Если да - добавить нельзя
            Variable sameNamedVariable = KnowledgeBase.GetVariable(variableName);
            if (sameNamedVariable != null)
            {
                if (EditingVariableIndex == -1 || EditingVariableIndex != -1 && sameNamedVariable != KnowledgeBase.Variables[EditingVariableIndex])
                {
                    MessageBox.Show($"Переменная с таким именем уже существует. Вы не можете добавить две переменные с однинаковым именем.",
                                    "Действие недоступно", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (EditingVariableIndex == -1)
            {
                variable = new Variable(variableName, (Domain)comboBoxDomain.SelectedItem, type, questionText);
                KnowledgeBase.Variables.Add(variable);
            }
            else
            {
                variable = KnowledgeBase.Variables[EditingVariableIndex];
                variable.Name = variableName;
                variable.QuestionText = questionText;
                variable.Type = type;
                variable.Domain = (Domain)comboBoxDomain.SelectedItem;
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void radioButtonRequestedVarType_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEnabledPropertyOfControls();
        }

        private void radioButtonDeducedVarType_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEnabledPropertyOfControls();
        }

        private void radioButtonDedRequestedVarType_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEnabledPropertyOfControls();
        }
    }
}
