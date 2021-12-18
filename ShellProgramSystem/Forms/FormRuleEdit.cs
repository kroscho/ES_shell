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
    public partial class FormRuleEdit : Form
    {
        private KnowledgeBase KnowledgeBase { get; set; }
        private int EditingRuleIndex { get; set; }
       
        //Индекс, после которого будет вставлено новое правило
        private int InsertingIndex { get; set; }
        
        // Флаг, который указывает на то, были ли добавлены новые переменные в процессе редактирования правила
        public bool IsVariablesAdded { get; set; }

        /// Флаг, который указывает на то, были ли добавлены новые домены в процессе редактирования правила
        public bool IsDomainsAdded { get; set; }


        // Метод обновления свойства Enabled элементов управления
        void UpdateEnabledPropertyOfControls()
        {
            // Элементы управления принятия ввода
            bool isNameEntered = string.IsNullOrEmpty(textBoxRuleName.Text.Trim());
            bool isPremiseEntered = listBoxPremiseFacts.Items.Count == 0;
            bool isConclusionEntered = listBoxConclusionFacts.Items.Count == 0;

            buttonOk.Enabled = (isNameEntered || isPremiseEntered || isConclusionEntered) ? false : true;

            // Посылка
            bool isPremiseFactSelected = listBoxPremiseFacts.Items.Count != 0 && listBoxPremiseFacts.SelectedIndex != -1;
            buttonEditPremiseFact.Enabled = buttonDeletePremiseFact.Enabled = isPremiseFactSelected;
            // Заключение
            bool isConclusionFactSelected = listBoxConclusionFacts.Items.Count != 0 && listBoxConclusionFacts.SelectedIndex != -1;
            buttonEditConclusionFact.Enabled = buttonDeleteConclusionFact.Enabled = isConclusionFactSelected;
        }

        // Заполнить все поля формы данными правила с заданным индексом
        private void FillRuleControls()
        {
            if (EditingRuleIndex == -1)
            {
                textBoxRuleName.Text = KnowledgeBase.GetNextRuleName();
                return;
            }
            Rule currentRule = KnowledgeBase.Rules[EditingRuleIndex];
            textBoxRuleName.Text = currentRule.Name;
            textBoxRuleDescription.Text = currentRule.Description;
            // Посылка
            listBoxPremiseFacts.BeginUpdate();
            foreach (var fact in currentRule.Premise)
                listBoxPremiseFacts.Items.Add(fact);
            listBoxPremiseFacts.EndUpdate();
            // Заключение
            listBoxConclusionFacts.BeginUpdate();
            foreach (var fact in currentRule.Conclusion)
                listBoxConclusionFacts.Items.Add(fact);
            listBoxConclusionFacts.EndUpdate();
        }

        // ----Конструкторы
        private void GeneralConstruct(KnowledgeBase knowledgeBase, int ruleIndex, string text)
        {
            KnowledgeBase = knowledgeBase;
            EditingRuleIndex = ruleIndex;
            Text = text;
            FillRuleControls();
            UpdateEnabledPropertyOfControls();
            IsVariablesAdded = IsDomainsAdded = false;
        }

        public FormRuleEdit(int insertingIndex, KnowledgeBase knowledgeBase)
        {
            InitializeComponent();
            InsertingIndex = insertingIndex;
            GeneralConstruct(knowledgeBase, -1, "Создание правила");
        }

        public FormRuleEdit(KnowledgeBase knowledgeBase, int ruleIndex)
        {
            InitializeComponent();
            GeneralConstruct(knowledgeBase, ruleIndex, "Изменение правила");
        }


        // Обработчики событий формы

        private void buttonAddPremiseFact_Click(object sender, EventArgs e)
        {
            FormRuleFactEdit formRuleFactEdit = new FormRuleFactEdit(KnowledgeBase, RuleFactType.PremiseFact);
            if (formRuleFactEdit.ShowDialog() == DialogResult.OK)
            {
                listBoxPremiseFacts.Items.Add(formRuleFactEdit.CurrentRuleFact);
                UpdateEnabledPropertyOfControls();
            }
            IsVariablesAdded = IsVariablesAdded || formRuleFactEdit.IsVariablesAdded;
            IsDomainsAdded = IsDomainsAdded || formRuleFactEdit.IsDomainsAdded;
        }

        private void buttonEditPremiseFact_Click(object sender, EventArgs e)
        {
            int editingFactIndex = listBoxPremiseFacts.SelectedIndex;
            
            if (editingFactIndex == -1)
                return;

            RuleFact editingFact = (RuleFact)listBoxPremiseFacts.SelectedItem;
            FormRuleFactEdit formRuleFactEdit = new FormRuleFactEdit(KnowledgeBase, RuleFactType.PremiseFact, editingFact);
            if (formRuleFactEdit.ShowDialog() == DialogResult.OK)
            {
                listBoxPremiseFacts.Items[editingFactIndex] = formRuleFactEdit.CurrentRuleFact;
                UpdateEnabledPropertyOfControls();
            }
            IsVariablesAdded = IsVariablesAdded || formRuleFactEdit.IsVariablesAdded;
            IsDomainsAdded = IsDomainsAdded || formRuleFactEdit.IsDomainsAdded;
        }

        private void buttonDeletePremiseFact_Click(object sender, EventArgs e)
        {
            int deletingFactIndex = listBoxPremiseFacts.SelectedIndex;
            if (deletingFactIndex == -1)
                return;
            listBoxPremiseFacts.Items.RemoveAt(deletingFactIndex);
            UpdateEnabledPropertyOfControls();
        }

        private void buttonAddConclusionFact_Click(object sender, EventArgs e)
        {
            FormRuleFactEdit formRuleFactEdit = new FormRuleFactEdit(KnowledgeBase, RuleFactType.ConclusionFact);
            if (formRuleFactEdit.ShowDialog() == DialogResult.OK)
            {
                listBoxConclusionFacts.Items.Add(formRuleFactEdit.CurrentRuleFact);
                UpdateEnabledPropertyOfControls();
            }
            IsVariablesAdded = IsVariablesAdded || formRuleFactEdit.IsVariablesAdded;
            IsDomainsAdded = IsDomainsAdded || formRuleFactEdit.IsDomainsAdded;
        }

        private void buttonEditConclusionFact_Click(object sender, EventArgs e)
        {
            int editingFactIndex = listBoxConclusionFacts.SelectedIndex;
            if (editingFactIndex == -1)
                return;
            RuleFact editingFact = (RuleFact)listBoxConclusionFacts.SelectedItem;
            FormRuleFactEdit formRuleFactEdit = new FormRuleFactEdit(KnowledgeBase, RuleFactType.ConclusionFact, editingFact);
            if (formRuleFactEdit.ShowDialog() == DialogResult.OK)
            {
                listBoxConclusionFacts.Items[editingFactIndex] = formRuleFactEdit.CurrentRuleFact;
                UpdateEnabledPropertyOfControls();
            }
            IsVariablesAdded = IsVariablesAdded || formRuleFactEdit.IsVariablesAdded;
            IsDomainsAdded = IsDomainsAdded || formRuleFactEdit.IsDomainsAdded;
        }

        private void buttonDeleteConclusionFact_Click(object sender, EventArgs e)
        {
            int deletingFactIndex = listBoxConclusionFacts.SelectedIndex;
            if (deletingFactIndex == -1)
                return;
            listBoxConclusionFacts.Items.RemoveAt(deletingFactIndex);
            UpdateEnabledPropertyOfControls();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Rule rule;
            string ruleName = textBoxRuleName.Text.Trim().Replace('\n', ' ');
            string ruleDescription = textBoxRuleDescription.Text.Trim();
            // Проверим, существует ли правило с таким именем (помимо самого изменяемого правила). Если да, то добавить нельзя
            Rule sameNamedRule = KnowledgeBase.GetRule(ruleName);
            
            if (sameNamedRule != null)
            {
                if (EditingRuleIndex == -1 || EditingRuleIndex != -1 && sameNamedRule != KnowledgeBase.Rules[EditingRuleIndex])
                {
                    MessageBox.Show($"Правило с таким именем уже существует. Вы не можете добавить два правила с одинаковым именем.",
                                    "Действие недоступно", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (EditingRuleIndex == -1)
            {
                rule = new Rule(ruleName, listBoxPremiseFacts.Items.Cast<RuleFact>().ToList(),
                                listBoxConclusionFacts.Items.Cast<RuleFact>().ToList(), ruleDescription);
                if (InsertingIndex == -1)
                    KnowledgeBase.Rules.Add(rule);
                else
                    KnowledgeBase.Rules.Insert(InsertingIndex, rule);
            }
            else
            {
                rule = KnowledgeBase.Rules[EditingRuleIndex];
                rule.Name = ruleName;
                rule.Description = ruleDescription;
                rule.Premise = listBoxPremiseFacts.Items.Cast<RuleFact>().ToList();
                rule.Conclusion = listBoxConclusionFacts.Items.Cast<RuleFact>().ToList();
            }
            DialogResult = DialogResult.OK;
        }

        private void textBoxRuleName_TextChanged(object sender, EventArgs e)
        {
            UpdateEnabledPropertyOfControls();
        }

        private void listBoxPremiseFacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEnabledPropertyOfControls();
        }

        private void listBoxConclusionFacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEnabledPropertyOfControls();
        }

        private void textBoxRuleDescription_TextChanged(object sender, EventArgs e)
        {
            textBoxRuleDescription.Text = textBoxRuleDescription.Text;
            UpdateEnabledPropertyOfControls();
        }
    }
}
