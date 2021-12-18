using System;
using System.Windows.Forms;
using ShellProgramSystem.ShellModules;

namespace ShellProgramSystem.Forms
{
    public partial class FormExplanation : Form
    {
        // Конструкторы        
        public FormExplanation()
        {
            InitializeComponent();
        }

        // Конструктор, инициализирующий форму объяснением консультации, представленной её рабочей памятью
        /// <param name="explanationComponent">Объяснительная компонента консультации, объяснение которой необходимо представить</param>
        public FormExplanation(ExplanationComponent explanationComponent)
        {
            InitializeComponent();
            // Строим TreeView сработавших правил - добавляем в него корневую вершину построенного дерево
            treeViewRules.Nodes.Add(explanationComponent.RulesTreeRoot);
            // Строим таблицу ListView переменных и их значений на основании построенного списка
            foreach (var fact in explanationComponent.VariablesValuesList)
            {
                ListViewItem lvi = new ListViewItem(new string[] { fact.Variable.ToString(), fact.Value.ToString() });
                listViewVariables.Items.Add(lvi);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
