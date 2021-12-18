using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ShellProgramSystem.Classes;
using Rule = ShellProgramSystem.Classes.Rule;

namespace ShellProgramSystem.Forms
{
    public partial class FormDomainEdit : Form
    {
        private KnowledgeBase KnowledgeBase { get; set; }
        
        // Индекс изменяемого домена в коллекции Domains базы знаний KnowledgeBase.
        // Если создаётся новый домен, равен -1.
        private int EditingDomainIndex { get; set; }
        private Dictionary<DomainValue, DomainValue> CopyOriginalDomainValuePairs { get; set; }

        // Метод обновления свойства Enabled элементов управления
        void UpdateEnabledPropertyOfControls()
        {
            string domainName = textBoxDomainName.Text.Trim();
            bool isNameEntered = !string.IsNullOrEmpty(domainName);
            // Элементы управления редактирования значения
            bool isValueSelected = listBoxDomainValues.Items.Count != 0 && listBoxDomainValues.SelectedIndex != -1;
            buttonDeleteDomainValue.Enabled = buttonChangeDomainValue.Enabled = isValueSelected;
            // Элементы управления добавлением значения
            string newDomainValue = textBoxNewDomainValue.Text.Trim();
            bool isNewValueEntered = !string.IsNullOrEmpty(newDomainValue);
            buttonAddDomainValue.Enabled = buttonChangeDomainValue.Enabled = isNewValueEntered;
            // Элементы управления принятия ввода
            bool isCanBeSaved = isNameEntered && listBoxDomainValues.Items.Count != 0;
            buttonOK.Enabled = isCanBeSaved;
        }

        // Заполнить все поля формы данными домена с заданным индексом
        private void FillDomainControls()
        {
            if (EditingDomainIndex == -1)
            {
                textBoxDomainName.Text = KnowledgeBase.GetNextDomainName();
                CopyOriginalDomainValuePairs = null;
                return;
            }
            Domain currentDomain = KnowledgeBase.Domains[EditingDomainIndex]; // домен, который мы изменяем
            // Запоняем поля формы данными. Значения домена копируем, при этом для каждой копии в словарь сохраняем оригинал.
            // Это понадобится, потому что сами оригиналы мы менять не можем - на них могут ссылаться правила. 
            // Нужно резервное копировние на случай отмены изменений.
            CopyOriginalDomainValuePairs = new Dictionary<DomainValue, DomainValue>();
            listBoxDomainValues.BeginUpdate();
            foreach (var value in currentDomain.Values)
            {
                DomainValue valueCopy = (DomainValue)value.Clone();
                CopyOriginalDomainValuePairs[valueCopy] = value;
                listBoxDomainValues.Items.Add(valueCopy);
            }
            listBoxDomainValues.EndUpdate();
            textBoxDomainName.Text = currentDomain.Name;
        }

        // ----Конструкторы
        private void GeneralConstruct(KnowledgeBase knowledgeBase, int domainIndex, string text)
        {
            KnowledgeBase = knowledgeBase;
            EditingDomainIndex = domainIndex;
            Text = text;
            FillDomainControls();
            UpdateEnabledPropertyOfControls();
        }

        public FormDomainEdit(KnowledgeBase knowledgeBase)
        {
            InitializeComponent();
            GeneralConstruct(knowledgeBase, -1, "Создание домена");
        }

        public FormDomainEdit(KnowledgeBase knowledgeBase, int domainIndex)
        {
            InitializeComponent();
            GeneralConstruct(knowledgeBase, domainIndex, "Изменение домена");
        }

        private void buttonDeleteDomainValue_Click(object sender, EventArgs e)
        {
            int deletingValueIndex = listBoxDomainValues.SelectedIndex;
            if (deletingValueIndex == -1)
                return;
            // Проверяем, используется ли оригинал удаляемого значения домена (если для него есть оригинал) в правилах. Если что - удалить нельзя
            if (EditingDomainIndex != -1)
            {
                DomainValue deletingValue = (DomainValue)listBoxDomainValues.Items[deletingValueIndex];
                if (CopyOriginalDomainValuePairs.TryGetValue(deletingValue, out DomainValue originalDeletingValue))
                {
                    List<Classes.Rule> rulesUsing = KnowledgeBase.GetRulesUsingDomainValue(originalDeletingValue);
                    if (rulesUsing != null)
                    {
                        MessageBox.Show($"Это значение домена используется в правилах: {KnowledgeBase.GetRulesNamesString(rulesUsing)}.\nВы не можете его удалить.",
                                        "Действие недоступно", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            listBoxDomainValues.Items.RemoveAt(deletingValueIndex);
            // Состояние элементов управления обновится самостоятельно за счёт других событий
        }

        private void buttonAddDomainValue_Click(object sender, EventArgs e)
        {
            string addingValue = textBoxNewDomainValue.Text.Trim().Replace('\n', ' ');
            if (string.IsNullOrEmpty(addingValue))
                return;
            // Проверяем, есть ли уже такое значение в домене. Если да, добавить нельзя
            foreach (DomainValue domainValue in listBoxDomainValues.Items)
            {
                if (domainValue.Value == addingValue)
                {
                    MessageBox.Show($"Такое значение домена уже существует. Вы не можете добавить два одинаковых значения.",
                                "Действие недоступно", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            listBoxDomainValues.Items.Add(new DomainValue(addingValue));
            textBoxNewDomainValue.Clear();
            // Состояние элементов управления обновится самостоятельно за счёт других событий
        }

        private void buttonChangeDomainValue_Click(object sender, EventArgs e)
        {
            int changingValueIndex = listBoxDomainValues.SelectedIndex;
            string newValue = textBoxNewDomainValue.Text.Trim().Replace('\n', ' ');
            if (string.IsNullOrEmpty(newValue) || changingValueIndex == -1)
                return;
            // Проверяем, есть ли уже такое значение в домене. Если да, добавить нельзя
            foreach (DomainValue domainValue in listBoxDomainValues.Items)
            {
                if (domainValue.Value == newValue)
                {
                    MessageBox.Show($"Такое значение домена уже существует. Вы не можете добавить два одинаковых значения.",
                                "Действие недоступно", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            // Проверяем, используется ли это значение в правилах
            if (EditingDomainIndex != -1)
            {
                DomainValue changingValue = (DomainValue)listBoxDomainValues.Items[changingValueIndex];
                if (CopyOriginalDomainValuePairs.TryGetValue(changingValue, out DomainValue originalChangingValue))
                {
                    List<Rule> rulesUsing = KnowledgeBase.GetRulesUsingDomainValue(originalChangingValue);
                    if (rulesUsing != null)
                    {
                        DialogResult answer =
                            MessageBox.Show($"Это значение домена используется в правилах: {KnowledgeBase.GetRulesNamesString(rulesUsing)}.\nВы действительно хотите его изменить?",
                                            "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (answer == DialogResult.No)
                            return;
                    }
                }
            }
            // Чтобы изменение элемента listBox отобразилось, мы говорим, что обновляем его, и просто перерисваиваем тот же элемент,
            // но с изменённым значением
            ((DomainValue)listBoxDomainValues.Items[changingValueIndex]).Value = newValue;
            listBoxDomainValues.Items[changingValueIndex] = listBoxDomainValues.Items[changingValueIndex];
            // И чистим введённое значение
            textBoxNewDomainValue.Clear();
            // Состояние элементов управления обновится самостоятельно за счёт событий изменения selectedIndex'ов
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Domain domain;
            string domainName = textBoxDomainName.Text.Trim().Replace('\n', ' ');
            // Проверим, можем ли мы переименовать используемый домен
            if (EditingDomainIndex != -1)
            {
                domain = KnowledgeBase.Domains[EditingDomainIndex];
                List<Variable> variablesUsing = KnowledgeBase.GetVariablesUsingDomain(domain);
                if (variablesUsing != null && domain.Name != domainName)
                {
                    DialogResult answer =
                        MessageBox.Show($"Этот домен используется переменными: {KnowledgeBase.GetVariablesNamesString(variablesUsing)}.\nВы действительно хотите его переименовать?",
                                            "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (answer == DialogResult.No)
                        return;
                }
            }
            // Проверим, существует ли домен с таким именем (помиомо самого изменяемого домена). Если да - второй добавить нельзя
            Domain sameNamedDomain = KnowledgeBase.GetDomain(domainName);
            if (sameNamedDomain != null)
            {
                if (EditingDomainIndex == -1 || EditingDomainIndex != -1 && sameNamedDomain != KnowledgeBase.Domains[EditingDomainIndex])
                {
                    MessageBox.Show($"Домен с таким именем уже существует. Вы не можете добавить два домена с одинаковым именем.",
                                    "Действие недоступно", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (EditingDomainIndex == -1)
            {
                domain = new Domain(domainName, listBoxDomainValues.Items.Cast<DomainValue>().ToList());
                KnowledgeBase.Domains.Add(domain);
            }
            else
            {
                domain = KnowledgeBase.Domains[EditingDomainIndex];
                domain.Name = domainName;
                // Заменяем все копии существующих значений оригинальными объектами, при этом меняя их значение.
                // Нам важно сохранить именно оригинальные объекты, поскольку на них могут ссылаться правила
                List<DomainValue> domainValues = new List<DomainValue>(listBoxDomainValues.Items.Count);
                foreach (DomainValue value in listBoxDomainValues.Items)
                {
                    if (CopyOriginalDomainValuePairs.TryGetValue(value, out DomainValue originalDomainValue))
                    {
                        originalDomainValue.Value = value.Value;
                        domainValues.Add(originalDomainValue);
                    }
                    // Если это не изменённый старый объект, а новый объект, то он так и остаётся
                    else
                    {
                        domainValues.Add(value);
                    }
                }
                domain.Values = domainValues;
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxDomainName_TextChanged(object sender, EventArgs e)
        {
            UpdateEnabledPropertyOfControls();
        }

        private void listBoxDomainValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEnabledPropertyOfControls();
        }

        private void textBoxNewDomainValue_TextChanged(object sender, EventArgs e)
        {
            UpdateEnabledPropertyOfControls();
        }

        // ----Обработчики событий формы

    }
}
