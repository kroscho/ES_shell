using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ShellProgramSystem.Forms;
using ShellProgramSystem.Classes;
using ShellProgramSystem.ShellModules;

namespace ShellProgramSystem
{
    public partial class MainForm : Form
    {
        private KnowledgeBase KnowledgeBase { get; set; }
        private ExplanationComponent prevConsultationExplanationComponent;


        private string FilePath;
        private string FileName => !string.IsNullOrEmpty(FilePath) ? Path.GetFileName(FilePath) : "Новая база знаний";

        // переменная, указывающаяя сохранены ли изменения
        private bool IsChangesSaved { get; set; }

        // Создать новую базу знаний, заполнить информацию о файле
        private void CreateNewKnowledgeBase()
        {
            KnowledgeBase = new KnowledgeBase();
            FilePath = string.Empty;
            IsChangesSaved = false;
        }

        // Обновить заголовок формы - в нём прописывается имя текущего файла
        private void UpdateFormHeader()
        {
            Text = $"Оболочка ЭС | {FileName}{(!IsChangesSaved ? "*" : "")}";
        }

        // Обновить таблицу правил
        private void UpdateRulesListView()
        {
            listViewRules.BeginUpdate();
            listViewRules.Items.Clear();
            foreach (var rule in KnowledgeBase.Rules)
            {
                ListViewItem lvi = new ListViewItem(new string[] { rule.Name, rule.GetRuleStringView() });
                listViewRules.Items.Add(lvi);
            }
            listViewRules.EndUpdate();
        }

        // Обновить таблицу переменных
        private void UpdateVariablesListView()
        {
            listViewVariables.BeginUpdate();
            listViewVariables.Items.Clear();
            foreach (var variable in KnowledgeBase.Variables)
            {
                ListViewItem lvi = new ListViewItem(new string[] { variable.Name, variable.Type.ToText(), variable.Domain.ToString() });
                listViewVariables.Items.Add(lvi);
            }
            listViewVariables.EndUpdate();
        }

        // Обновить таблицу доменов
        private void UpdateDomainsListView()
        {
            listViewDomains.BeginUpdate();
            listViewDomains.Items.Clear();
            foreach (var domain in KnowledgeBase.Domains)
            {
                ListViewItem lvi = new ListViewItem(new string[] { domain.ToString() });
                listViewDomains.Items.Add(lvi);
            }
            listViewDomains.EndUpdate();
        }

        // Обновить все таблицы
        private void UpdateAllListViews()
        {
            UpdateRulesListView();
            UpdateVariablesListView();
            UpdateDomainsListView();
        }

        // Обновить кнопки и отображение деталей для правил
        private void UpdateRuleDetails()
        {
            if (listViewRules.SelectedIndices.Count == 0)
            {
                listBoxRulePremise.Items.Clear();
                listBoxRuleConclusion.Items.Clear();
                buttonEditRule.Enabled = buttonDeleteRule.Enabled = false;
            }
            else
            {
                int selectedIndex = listViewRules.SelectedIndices[0];
                listBoxRulePremise.BeginUpdate();
                listBoxRulePremise.Items.Clear();
                foreach (var fact in KnowledgeBase.Rules[selectedIndex].Premise)
                    listBoxRulePremise.Items.Add(fact);
                listBoxRulePremise.EndUpdate();
                listBoxRuleConclusion.BeginUpdate();
                listBoxRuleConclusion.Items.Clear();
                foreach (var fact in KnowledgeBase.Rules[selectedIndex].Conclusion)
                    listBoxRuleConclusion.Items.Add(fact);
                listBoxRuleConclusion.EndUpdate();
                buttonEditRule.Enabled = buttonDeleteRule.Enabled = true;
            }
        }

        // Обновить кнопки и отображение деталей для переменных
        private void UpdateVariableDetails()
        {
            if (listViewVariables.SelectedIndices.Count == 0)
            {
                listBoxVariableDomainValue.Items.Clear();
                labelVariableQuestionText.Text = "";
                buttonEditVariable.Enabled = buttonDeleteVariable.Enabled = false;
            }
            else
            {
                int selectedIndex = listViewVariables.SelectedIndices[0];
                listBoxVariableDomainValue.BeginUpdate();
                listBoxVariableDomainValue.Items.Clear();
                foreach (var domainValue in KnowledgeBase.Variables[selectedIndex].Domain.Values)
                    listBoxVariableDomainValue.Items.Add(domainValue);
                listBoxVariableDomainValue.EndUpdate();
                if (KnowledgeBase.Variables[selectedIndex].Type == VariableType.Deduced)
                    labelVariableQuestionText.Text = "";
                else
                    labelVariableQuestionText.Text = KnowledgeBase.Variables[selectedIndex].QuestionText;
                buttonEditVariable.Enabled = buttonDeleteVariable.Enabled = true;
            }
        }

        // Обновить кнопки и отображение деталей для доменов
        private void UpdateDomainDetails()
        {
            if (listViewDomains.SelectedIndices.Count == 0)
            {
                listBoxDomainValues.Items.Clear();
                buttonEditDomain.Enabled = buttonDeleteDomain.Enabled = false;
            }
            else
            {
                int selectedIndex = listViewDomains.SelectedIndices[0];
                listBoxDomainValues.BeginUpdate();
                listBoxDomainValues.Items.Clear();
                foreach (var domainValue in KnowledgeBase.Domains[selectedIndex].Values)
                    listBoxDomainValues.Items.Add(domainValue);
                listBoxDomainValues.EndUpdate();
                buttonEditDomain.Enabled = buttonDeleteDomain.Enabled = true;
            }
        }

        // Обновить все кнопки и всю детальную информацию объектов
        private void UpdateAllDetails()
        {
            UpdateRuleDetails();
            UpdateVariableDetails();
            UpdateDomainDetails();
        }

        // Обновить все кнопки и всю детальную информацию правил
        private void UpdateAllOfRules()
        {
            UpdateRulesListView();
            UpdateRuleDetails();
        }

        // Обновить все кнопки и всю детальную информацию переменных
        private void UpdateAllOfVariables()
        {
            UpdateVariablesListView();
            UpdateVariableDetails();
        }

        // Обновить все кнопки и всю детальную информацию доменов
        private void UpdateAllOfDomains()
        {
            UpdateDomainsListView();
            UpdateDomainDetails();
        }

        // Конструктор
        public MainForm()
        {
            InitializeComponent();
            CreateNewKnowledgeBase();
            // Консультаций ещё не было => объяснений нет
           // prevConsultationExplanationComponent = null;
            UpdateFormHeader();
            UpdateAllListViews();
            UpdateAllDetails();
        }

        // обработчики событий

        private void listViewRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRuleDetails();
        }

        private void listViewVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVariableDetails();
        }

        private void listViewDomains_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDomainDetails();
        }

        private void buttonAddRule_Click(object sender, EventArgs e)
        {
            // Правило вставляется после выбранного в таблице, либо в конец
            int insertingIndex = listViewRules.SelectedIndices.Count != 0 ? listViewRules.SelectedIndices[0] + 1 : -1;
            if (insertingIndex >= listViewRules.Items.Count)
                insertingIndex = -1;
            FormRuleEdit formRuleEdit = new FormRuleEdit(insertingIndex, KnowledgeBase);
            formRuleEdit.ShowDialog();
            // Обновляем нужные элементы управления
            if (formRuleEdit.IsDomainsAdded)
            {
                UpdateAllOfDomains();
                IsChangesSaved = false;
            }
            if (formRuleEdit.IsVariablesAdded)
            {
                UpdateAllOfVariables();
                IsChangesSaved = false;
            }
            if (formRuleEdit.DialogResult == DialogResult.OK)
            {
                UpdateAllOfRules();
                IsChangesSaved = false;
            }
            // Обновляем заголовок формы в зависимости от того, были ли изменения
            UpdateFormHeader();
        }

        private void buttonEditRule_Click(object sender, EventArgs e)
        {
            if (listViewRules.SelectedIndices.Count == 0)
                return;
            int selectedIndex = listViewRules.SelectedIndices[0];
            FormRuleEdit formRuleEdit = new FormRuleEdit(KnowledgeBase, selectedIndex);
            formRuleEdit.ShowDialog();
            // Обновляем нужные элементы управления
            if (formRuleEdit.IsDomainsAdded)
            {
                UpdateAllOfDomains();
                IsChangesSaved = false;
            }
            if (formRuleEdit.IsVariablesAdded)
            {
                UpdateAllOfVariables();
                IsChangesSaved = false;
            }
            if (formRuleEdit.DialogResult == DialogResult.OK)
            {
                UpdateAllOfRules();
                IsChangesSaved = false;
            }
            // Обновляем заголовок формы в зависимости от того, были ли изменения
            UpdateFormHeader();
        }

        private void buttonDeleteRule_Click(object sender, EventArgs e)
        {
            if (listViewRules.SelectedIndices.Count == 0)
                return;
            int selectedIndex = listViewRules.SelectedIndices[0];
            KnowledgeBase.Rules.RemoveAt(selectedIndex);
            listViewRules.Items.RemoveAt(selectedIndex);
            UpdateRuleDetails();
            // Отмечаем, что база знаний была изменена и обновляем заголовок формы
            if (IsChangesSaved)
            {
                IsChangesSaved = false;
                UpdateFormHeader();
            }
        }

        private void buttonAddVariable_Click(object sender, EventArgs e)
        {
            FormVariableEdit formVariableEdit = new FormVariableEdit(KnowledgeBase);
            formVariableEdit.ShowDialog();
            // Обновляем нужные элементы управления
            if (formVariableEdit.IsDomainsAdded)
            {
                UpdateAllOfDomains();
                IsChangesSaved = false;
            }
            if (formVariableEdit.DialogResult == DialogResult.OK)
            {
                UpdateAllOfVariables();
                IsChangesSaved = false;
            }
            // Обновляем заголовок формы в зависимости от того, были ли изменения
            UpdateFormHeader();
        }

        private void buttonEditVariable_Click(object sender, EventArgs e)
        {
            if (listViewVariables.SelectedIndices.Count == 0)
                return;
            int selectedIndex = listViewVariables.SelectedIndices[0];
            FormVariableEdit formVariableEdit = new FormVariableEdit(KnowledgeBase, selectedIndex);
            formVariableEdit.ShowDialog();
            // Обновляем нужные элементы управления
            if (formVariableEdit.IsDomainsAdded)
            {
                UpdateAllOfDomains();
                IsChangesSaved = false;
            }
            if (formVariableEdit.DialogResult == DialogResult.OK)
            {
                UpdateAllOfVariables();
                UpdateAllOfRules();
                IsChangesSaved = false;
            }
            // Обновляем заголовок формы в зависимости от того, были ли изменения
            UpdateFormHeader();
        }

        private void buttonDeleteVariable_Click(object sender, EventArgs e)
        {
            if (listViewVariables.SelectedIndices.Count == 0)
                return;
            int selectedIndex = listViewVariables.SelectedIndices[0];
            // Проверяем, можно ли удалять
            Variable deletingVariable = KnowledgeBase.Variables[selectedIndex];
            List<Classes.Rule> rulesUsing = KnowledgeBase.GetRulesUsingVariable(deletingVariable);
            if (rulesUsing != null)
            {
                MessageBox.Show($"Эта переменная используется правилами: {KnowledgeBase.GetRulesNamesString(rulesUsing)}.\nВы не можете удалить её.",
                            "Действие недоступно", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Если всё нормально - удаляем
            KnowledgeBase.Variables.RemoveAt(selectedIndex);
            listViewVariables.Items.RemoveAt(selectedIndex);
            UpdateVariableDetails();
            // Отмечаем, что база знаний была изменена и обновляем заголовок формы
            if (IsChangesSaved)
            {
                IsChangesSaved = false;
                UpdateFormHeader();
            }
        }

        private void buttonAddDomain_Click(object sender, EventArgs e)
        {
            FormDomainEdit formDomainEdit = new FormDomainEdit(KnowledgeBase);
            formDomainEdit.ShowDialog();
            if (formDomainEdit.DialogResult == DialogResult.OK)
            {
                UpdateAllOfDomains();
                // Отмечаем, что база знаний была изменена, и обновляем заголовок формы
                if (IsChangesSaved)
                {
                    IsChangesSaved = false;
                    UpdateFormHeader();
                }
            }
        }

        private void buttonEditDomain_Click(object sender, EventArgs e)
        {
            if (listViewDomains.SelectedIndices.Count == 0)
                return;
            int selectedIndex = listViewDomains.SelectedIndices[0];
            FormDomainEdit formDomainEdit = new FormDomainEdit(KnowledgeBase, selectedIndex);
            formDomainEdit.ShowDialog();
            if (formDomainEdit.DialogResult == DialogResult.OK)
            {
                UpdateAllOfDomains();
                UpdateAllOfVariables();
                UpdateAllOfRules();
                // Отмечаем, что база знаний была изменена, и обновляем заголовок формы
                if (IsChangesSaved)
                {
                    IsChangesSaved = false;
                    UpdateFormHeader();
                }
            }
        }

        private void buttonDeleteDomain_Click(object sender, EventArgs e)
        {
            if (listViewDomains.SelectedIndices.Count == 0)
                return;
            int selectedIndex = listViewDomains.SelectedIndices[0];
            // Проверяем, Можно ли удалять домен
            Domain deletingDomain = KnowledgeBase.Domains[selectedIndex];
            List<Variable> variablesUsing = KnowledgeBase.GetVariablesUsingDomain(deletingDomain);
            if (variablesUsing != null)
            {
                MessageBox.Show($"Этот домен используется переменными: {KnowledgeBase.GetVariablesNamesString(variablesUsing)}.\nВы не можете его удалить.",
                                      "Действие недоступно", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Если всё нормально - удаляем
            KnowledgeBase.Domains.RemoveAt(selectedIndex);
            listViewDomains.Items.RemoveAt(selectedIndex);
            UpdateDomainDetails();
            // Отмечаем, что база знаний была изменена, и обновляем заголовок формы
            if (IsChangesSaved)
            {
                IsChangesSaved = false;
                UpdateFormHeader();
            }
        }

        // Вызывается, когда пользователь начинает тащить выбранные элементы
        private void listViewRules_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        // Drag'n'Drop для таблицы правил

        // Вызывается, когда перетаскиваемый элемент попадает в клиентскую область экрана
        private void listViewRules_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewRules.DoDragDrop(listViewRules.SelectedItems, DragDropEffects.Move);
        }

        // Вызывается, когда пользователь после перетаскивания отпускает ЛКМ
        private void listViewRules_DragDrop(object sender, DragEventArgs e)
        {
            // Если ничего не было выделено - ничего и не перетаскивалось
            if (listViewRules.SelectedItems.Count == 0)
                return;

            // Получаем объект, находящийся в точке, на которой пользователь отпустил ЛКМ (куда хочет перетащить)
            Point dropPoint = listViewRules.PointToClient(new Point(e.X, e.Y));
            ListViewItem itemOnDrop = listViewRules.GetItemAt(dropPoint.X, dropPoint.Y);
            // Если в точке назначения ничего нет, то и перетаскивать некуда
            if (itemOnDrop == null)
                return;

            // Отмечаем, что база знаний была изменена
            if (IsChangesSaved)
            {
                IsChangesSaved = false;
                UpdateFormHeader();
            }

            // Получаем все выделенные объекты - это те объекты, которые нужно перетащить
            int itemOnDropIndex = itemOnDrop.Index;
            ListViewItem[] selectedItems = new ListViewItem[listViewRules.SelectedItems.Count];
            for (int i = 0; i < listViewRules.SelectedItems.Count; i++)
                selectedItems[i] = listViewRules.SelectedItems[i];

            int curInsertIndex = itemOnDropIndex; // индекс, в который будем вставлять следующий перетаскиваемый объект
            // Перетаскиваем 
            listViewRules.BeginUpdate();
            foreach (var item in selectedItems)
            {
                // Если перетащить надо объект, в который перетаскиваем - всё, конец
                if (item.Index == itemOnDropIndex)
                    break;
                // Получаем новый индекс объекта. 
                // Если объект стоит выше места вставки, вставляем его в само место вставки. Если ниже - вставляем после последнего вставленного значения
                int newItemIndex;
                if (item.Index < itemOnDropIndex)
                    newItemIndex = itemOnDropIndex;
                else
                    newItemIndex = curInsertIndex;
                // Удаляем объект из старого места и вставляем в новый. Делаем зеракльные действия для базы знаний
                Classes.Rule rule = KnowledgeBase.Rules[item.Index];
                KnowledgeBase.Rules.RemoveAt(item.Index);
                listViewRules.Items.RemoveAt(item.Index);
                KnowledgeBase.Rules.Insert(newItemIndex, rule);
                listViewRules.Items.Insert(newItemIndex, item);
                // Так как следующий объект нужно будет вставлять ниже, увеличиваем индекс вставки
                curInsertIndex++;
            }
            listViewRules.EndUpdate();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewKnowledgeBase();
            UpdateFormHeader();
            UpdateAllListViews();
            UpdateAllDetails();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "jss files (*.jss)|*.jss";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog1.FileName;
                FileManager.Open(FilePath, KnowledgeBase);
            }
            UpdateAllListViews();
            UpdateAllDetails();
            // Сохраняем информацию об открытом файле и говорим, что все изменения сохранены
            IsChangesSaved = true;
            UpdateFormHeader();
            /*
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Открыть базу знаний",
                Filter = "Adept knowledge base(*.akb)|*.akb",
                AddExtension = true,
                CheckFileExists = true,
                CheckPathExists = true
            };
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var serializer = new KnowledgeBaseXmlSerializer();
            var knowledgeBase = serializer.Deserialize(fileDialog.FileName, out string errorMessage);
            if (knowledgeBase == null)
            {
                MessageBox.Show(errorMessage, "Ошибка при чтении базы знаний", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            KnowledgeBase = knowledgeBase;
            UpdateAllListViews();
            UpdateAllDetails();
            // Сохраняем информацию об открытом файле и говорим, что все изменения сохранены
            IsChangesSaved = true;
            FilePath = fileDialog.FileName;
            UpdateFormHeader();
            */
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsChangesSaved)
                return;
            if (string.IsNullOrEmpty(FilePath))
                сохранитьКакToolStripMenuItem_Click(sender, e);
            else
            {                
                FileManager.Save(FilePath, KnowledgeBase);                
                // Отмечаем, что изменения были сохранены
                IsChangesSaved = true;
                UpdateFormHeader();
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "jss files (*.jss)|*.jss";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = saveFileDialog1.FileName;
                FileManager.Save(FilePath, KnowledgeBase);
            }
            // Отмечаем, что изменения были сохранены
            IsChangesSaved = true;
            UpdateFormHeader();          
            }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsChangesSaved)
            {
                DialogResult dlgRes = MessageBox.Show("Изменения, внесённые в базу знаний, не были сохранены. Вы хотите сохранить их перед выходом?",
                    "Завершение работы приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dlgRes == DialogResult.Yes)
                    сохранитьToolStripMenuItem_Click(sender, e);
            }
        }

        private void начатьКонсультациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KnowledgeBase.Rules.Count == 0)
            {
                MessageBox.Show("Текущая база знаний не является полной (отсутствуют правила). Проведение консультации при имеющейся базе знаний невозможно.",
                    "Начать консультацию", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var formConsultation = new FormConsultation(KnowledgeBase);
            formConsultation.ShowDialog();
            // Если была завершённая консультация, сохраняем её объяснительную компоненту
            if (formConsultation.ExplanationComponent != null)
                prevConsultationExplanationComponent = formConsultation.ExplanationComponent;
        }

        private void показатьОбъяснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (prevConsultationExplanationComponent == null)
            {
                MessageBox.Show("Вы ещё не проводили консультаций, поэтому объяснения отсутствуют.",
                    "Показать объяснение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormExplanation formExplanation = new FormExplanation(prevConsultationExplanationComponent);
            formExplanation.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
