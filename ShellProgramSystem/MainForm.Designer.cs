namespace ShellProgramSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консультацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьКонсультациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьОбъяснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageDomains = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewDomains = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddDomain = new System.Windows.Forms.Button();
            this.buttonEditDomain = new System.Windows.Forms.Button();
            this.buttonDeleteDomain = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.listBoxDomainValues = new System.Windows.Forms.ListBox();
            this.tabPageVariables = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelVariableQuestionText = new System.Windows.Forms.Label();
            this.listViewVariables = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddVariable = new System.Windows.Forms.Button();
            this.buttonEditVariable = new System.Windows.Forms.Button();
            this.buttonDeleteVariable = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBoxVariableDomainValue = new System.Windows.Forms.ListBox();
            this.tabPageRules = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxRuleConclusion = new System.Windows.Forms.ListBox();
            this.listViewRules = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddRule = new System.Windows.Forms.Button();
            this.buttonEditRule = new System.Windows.Forms.Button();
            this.buttonDeleteRule = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxRulePremise = new System.Windows.Forms.ListBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStripMain.SuspendLayout();
            this.tabPageDomains.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPageVariables.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPageRules.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.консультацияToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1120, 30);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // консультацияToolStripMenuItem
            // 
            this.консультацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьКонсультациюToolStripMenuItem,
            this.показатьОбъяснениеToolStripMenuItem});
            this.консультацияToolStripMenuItem.Name = "консультацияToolStripMenuItem";
            this.консультацияToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.консультацияToolStripMenuItem.Text = "Консультация";
            // 
            // начатьКонсультациюToolStripMenuItem
            // 
            this.начатьКонсультациюToolStripMenuItem.Name = "начатьКонсультациюToolStripMenuItem";
            this.начатьКонсультациюToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.начатьКонсультациюToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.начатьКонсультациюToolStripMenuItem.Text = "Начать консультацию";
            this.начатьКонсультациюToolStripMenuItem.Click += new System.EventHandler(this.начатьКонсультациюToolStripMenuItem_Click);
            // 
            // показатьОбъяснениеToolStripMenuItem
            // 
            this.показатьОбъяснениеToolStripMenuItem.Name = "показатьОбъяснениеToolStripMenuItem";
            this.показатьОбъяснениеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.показатьОбъяснениеToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.показатьОбъяснениеToolStripMenuItem.Text = "Показать объяснение";
            this.показатьОбъяснениеToolStripMenuItem.Click += new System.EventHandler(this.показатьОбъяснениеToolStripMenuItem_Click);
            // 
            // tabPageDomains
            // 
            this.tabPageDomains.Controls.Add(this.tableLayoutPanel5);
            this.tabPageDomains.Location = new System.Drawing.Point(4, 25);
            this.tabPageDomains.Name = "tabPageDomains";
            this.tabPageDomains.Size = new System.Drawing.Size(1112, 635);
            this.tabPageDomains.TabIndex = 2;
            this.tabPageDomains.Text = "Домены";
            this.tabPageDomains.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.95105F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.04895F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel5.Controls.Add(this.listViewDomains, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox8, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox9, 4, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.88733F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.11267F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1112, 635);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // listViewDomains
            // 
            this.listViewDomains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.tableLayoutPanel5.SetColumnSpan(this.listViewDomains, 4);
            this.listViewDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDomains.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewDomains.HideSelection = false;
            this.listViewDomains.Location = new System.Drawing.Point(3, 3);
            this.listViewDomains.Name = "listViewDomains";
            this.tableLayoutPanel5.SetRowSpan(this.listViewDomains, 5);
            this.listViewDomains.Size = new System.Drawing.Size(722, 629);
            this.listViewDomains.TabIndex = 0;
            this.listViewDomains.UseCompatibleStateImageBehavior = false;
            this.listViewDomains.View = System.Windows.Forms.View.Details;
            this.listViewDomains.SelectedIndexChanged += new System.EventHandler(this.listViewDomains_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Имя";
            this.columnHeader4.Width = 691;
            // 
            // groupBox8
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.groupBox8, 2);
            this.groupBox8.Controls.Add(this.tableLayoutPanel6);
            this.groupBox8.Location = new System.Drawing.Point(731, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(375, 119);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Редактирование";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.75719F));
            this.tableLayoutPanel6.Controls.Add(this.buttonAddDomain, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonEditDomain, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.buttonDeleteDomain, 0, 2);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 21);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(375, 99);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // buttonAddDomain
            // 
            this.buttonAddDomain.Location = new System.Drawing.Point(3, 3);
            this.buttonAddDomain.Name = "buttonAddDomain";
            this.buttonAddDomain.Size = new System.Drawing.Size(369, 26);
            this.buttonAddDomain.TabIndex = 0;
            this.buttonAddDomain.Text = "Добавить";
            this.buttonAddDomain.UseVisualStyleBackColor = true;
            this.buttonAddDomain.Click += new System.EventHandler(this.buttonAddDomain_Click);
            // 
            // buttonEditDomain
            // 
            this.buttonEditDomain.Location = new System.Drawing.Point(3, 35);
            this.buttonEditDomain.Name = "buttonEditDomain";
            this.buttonEditDomain.Size = new System.Drawing.Size(369, 26);
            this.buttonEditDomain.TabIndex = 1;
            this.buttonEditDomain.Text = "Изменить";
            this.buttonEditDomain.UseVisualStyleBackColor = true;
            this.buttonEditDomain.Click += new System.EventHandler(this.buttonEditDomain_Click);
            // 
            // buttonDeleteDomain
            // 
            this.buttonDeleteDomain.Location = new System.Drawing.Point(3, 67);
            this.buttonDeleteDomain.Name = "buttonDeleteDomain";
            this.buttonDeleteDomain.Size = new System.Drawing.Size(369, 29);
            this.buttonDeleteDomain.TabIndex = 2;
            this.buttonDeleteDomain.Text = "Удалить";
            this.buttonDeleteDomain.UseVisualStyleBackColor = true;
            this.buttonDeleteDomain.Click += new System.EventHandler(this.buttonDeleteDomain_Click);
            // 
            // groupBox9
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.groupBox9, 2);
            this.groupBox9.Controls.Add(this.listBoxDomainValues);
            this.groupBox9.Location = new System.Drawing.Point(731, 135);
            this.groupBox9.Name = "groupBox9";
            this.tableLayoutPanel5.SetRowSpan(this.groupBox9, 4);
            this.groupBox9.Size = new System.Drawing.Size(375, 490);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Значение домена";
            // 
            // listBoxDomainValues
            // 
            this.listBoxDomainValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDomainValues.FormattingEnabled = true;
            this.listBoxDomainValues.ItemHeight = 16;
            this.listBoxDomainValues.Location = new System.Drawing.Point(3, 18);
            this.listBoxDomainValues.Name = "listBoxDomainValues";
            this.listBoxDomainValues.Size = new System.Drawing.Size(369, 469);
            this.listBoxDomainValues.TabIndex = 0;
            // 
            // tabPageVariables
            // 
            this.tabPageVariables.Controls.Add(this.tableLayoutPanel3);
            this.tabPageVariables.Location = new System.Drawing.Point(4, 25);
            this.tabPageVariables.Name = "tabPageVariables";
            this.tabPageVariables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVariables.Size = new System.Drawing.Size(1112, 635);
            this.tabPageVariables.TabIndex = 1;
            this.tabPageVariables.Text = "Переменные";
            this.tabPageVariables.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.95105F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.04895F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.listViewVariables, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox6, 4, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.88733F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.11267F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1106, 629);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.groupBox4, 2);
            this.groupBox4.Controls.Add(this.labelVariableQuestionText);
            this.groupBox4.Location = new System.Drawing.Point(725, 382);
            this.groupBox4.Name = "groupBox4";
            this.tableLayoutPanel3.SetRowSpan(this.groupBox4, 2);
            this.groupBox4.Size = new System.Drawing.Size(375, 240);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Текст вопроса";
            // 
            // labelVariableQuestionText
            // 
            this.labelVariableQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVariableQuestionText.Location = new System.Drawing.Point(3, 18);
            this.labelVariableQuestionText.Name = "labelVariableQuestionText";
            this.labelVariableQuestionText.Size = new System.Drawing.Size(369, 219);
            this.labelVariableQuestionText.TabIndex = 0;
            // 
            // listViewVariables
            // 
            this.listViewVariables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.tableLayoutPanel3.SetColumnSpan(this.listViewVariables, 4);
            this.listViewVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewVariables.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewVariables.HideSelection = false;
            this.listViewVariables.Location = new System.Drawing.Point(3, 3);
            this.listViewVariables.Name = "listViewVariables";
            this.tableLayoutPanel3.SetRowSpan(this.listViewVariables, 5);
            this.listViewVariables.Size = new System.Drawing.Size(716, 623);
            this.listViewVariables.TabIndex = 0;
            this.listViewVariables.UseCompatibleStateImageBehavior = false;
            this.listViewVariables.View = System.Windows.Forms.View.Details;
            this.listViewVariables.SelectedIndexChanged += new System.EventHandler(this.listViewVariables_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 168;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Тип";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 315;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Домен";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 219;
            // 
            // groupBox5
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.groupBox5, 2);
            this.groupBox5.Controls.Add(this.tableLayoutPanel4);
            this.groupBox5.Location = new System.Drawing.Point(725, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(375, 119);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Редактирование";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.75719F));
            this.tableLayoutPanel4.Controls.Add(this.buttonAddVariable, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonEditVariable, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttonDeleteVariable, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 21);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(375, 99);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // buttonAddVariable
            // 
            this.buttonAddVariable.Location = new System.Drawing.Point(3, 3);
            this.buttonAddVariable.Name = "buttonAddVariable";
            this.buttonAddVariable.Size = new System.Drawing.Size(369, 26);
            this.buttonAddVariable.TabIndex = 0;
            this.buttonAddVariable.Text = "Добавить";
            this.buttonAddVariable.UseVisualStyleBackColor = true;
            this.buttonAddVariable.Click += new System.EventHandler(this.buttonAddVariable_Click);
            // 
            // buttonEditVariable
            // 
            this.buttonEditVariable.Location = new System.Drawing.Point(3, 35);
            this.buttonEditVariable.Name = "buttonEditVariable";
            this.buttonEditVariable.Size = new System.Drawing.Size(369, 26);
            this.buttonEditVariable.TabIndex = 1;
            this.buttonEditVariable.Text = "Изменить";
            this.buttonEditVariable.UseVisualStyleBackColor = true;
            this.buttonEditVariable.Click += new System.EventHandler(this.buttonEditVariable_Click);
            // 
            // buttonDeleteVariable
            // 
            this.buttonDeleteVariable.Location = new System.Drawing.Point(3, 67);
            this.buttonDeleteVariable.Name = "buttonDeleteVariable";
            this.buttonDeleteVariable.Size = new System.Drawing.Size(369, 29);
            this.buttonDeleteVariable.TabIndex = 2;
            this.buttonDeleteVariable.Text = "Удалить";
            this.buttonDeleteVariable.UseVisualStyleBackColor = true;
            this.buttonDeleteVariable.Click += new System.EventHandler(this.buttonDeleteVariable_Click);
            // 
            // groupBox6
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.groupBox6, 2);
            this.groupBox6.Controls.Add(this.listBoxVariableDomainValue);
            this.groupBox6.Location = new System.Drawing.Point(725, 132);
            this.groupBox6.Name = "groupBox6";
            this.tableLayoutPanel3.SetRowSpan(this.groupBox6, 2);
            this.groupBox6.Size = new System.Drawing.Size(375, 240);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Значение домена";
            // 
            // listBoxVariableDomainValue
            // 
            this.listBoxVariableDomainValue.FormattingEnabled = true;
            this.listBoxVariableDomainValue.ItemHeight = 16;
            this.listBoxVariableDomainValue.Location = new System.Drawing.Point(6, 21);
            this.listBoxVariableDomainValue.Name = "listBoxVariableDomainValue";
            this.listBoxVariableDomainValue.Size = new System.Drawing.Size(366, 212);
            this.listBoxVariableDomainValue.TabIndex = 0;
            // 
            // tabPageRules
            // 
            this.tabPageRules.Controls.Add(this.tableLayoutPanel1);
            this.tabPageRules.Location = new System.Drawing.Point(4, 25);
            this.tabPageRules.Name = "tabPageRules";
            this.tabPageRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRules.Size = new System.Drawing.Size(1112, 633);
            this.tabPageRules.TabIndex = 0;
            this.tabPageRules.Text = "Правила";
            this.tabPageRules.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.95105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.04895F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Controls.Add(this.listViewRules, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.88733F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.11267F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1106, 627);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.listBoxRuleConclusion);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(725, 380);
            this.groupBox3.Name = "groupBox3";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox3, 2);
            this.groupBox3.Size = new System.Drawing.Size(378, 244);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Заключение";
            // 
            // listBoxRuleConclusion
            // 
            this.listBoxRuleConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRuleConclusion.FormattingEnabled = true;
            this.listBoxRuleConclusion.ItemHeight = 16;
            this.listBoxRuleConclusion.Location = new System.Drawing.Point(3, 18);
            this.listBoxRuleConclusion.Name = "listBoxRuleConclusion";
            this.listBoxRuleConclusion.Size = new System.Drawing.Size(372, 223);
            this.listBoxRuleConclusion.TabIndex = 0;
            // 
            // listViewRules
            // 
            this.listViewRules.AllowDrop = true;
            this.listViewRules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderDescription});
            this.tableLayoutPanel1.SetColumnSpan(this.listViewRules, 4);
            this.listViewRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRules.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewRules.FullRowSelect = true;
            this.listViewRules.HideSelection = false;
            this.listViewRules.Location = new System.Drawing.Point(3, 3);
            this.listViewRules.Name = "listViewRules";
            this.tableLayoutPanel1.SetRowSpan(this.listViewRules, 5);
            this.listViewRules.Size = new System.Drawing.Size(716, 621);
            this.listViewRules.TabIndex = 0;
            this.listViewRules.UseCompatibleStateImageBehavior = false;
            this.listViewRules.View = System.Windows.Forms.View.Details;
            this.listViewRules.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewRules_ItemDrag);
            this.listViewRules.SelectedIndexChanged += new System.EventHandler(this.listViewRules_SelectedIndexChanged);
            this.listViewRules.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewRules_DragDrop);
            this.listViewRules.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewRules_DragEnter);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя";
            this.columnHeaderName.Width = 196;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Описание";
            this.columnHeaderDescription.Width = 509;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(725, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.75719F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAddRule, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonEditRule, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeleteRule, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(375, 99);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonAddRule
            // 
            this.buttonAddRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddRule.Location = new System.Drawing.Point(3, 3);
            this.buttonAddRule.Name = "buttonAddRule";
            this.buttonAddRule.Size = new System.Drawing.Size(369, 26);
            this.buttonAddRule.TabIndex = 0;
            this.buttonAddRule.Text = "Добавить";
            this.buttonAddRule.UseVisualStyleBackColor = true;
            this.buttonAddRule.Click += new System.EventHandler(this.buttonAddRule_Click);
            // 
            // buttonEditRule
            // 
            this.buttonEditRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditRule.Location = new System.Drawing.Point(3, 35);
            this.buttonEditRule.Name = "buttonEditRule";
            this.buttonEditRule.Size = new System.Drawing.Size(369, 26);
            this.buttonEditRule.TabIndex = 1;
            this.buttonEditRule.Text = "Изменить";
            this.buttonEditRule.UseVisualStyleBackColor = true;
            this.buttonEditRule.Click += new System.EventHandler(this.buttonEditRule_Click);
            // 
            // buttonDeleteRule
            // 
            this.buttonDeleteRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteRule.Location = new System.Drawing.Point(3, 67);
            this.buttonDeleteRule.Name = "buttonDeleteRule";
            this.buttonDeleteRule.Size = new System.Drawing.Size(369, 29);
            this.buttonDeleteRule.TabIndex = 2;
            this.buttonDeleteRule.Text = "Удалить";
            this.buttonDeleteRule.UseVisualStyleBackColor = true;
            this.buttonDeleteRule.Click += new System.EventHandler(this.buttonDeleteRule_Click);
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.listBoxRulePremise);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(725, 131);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(378, 243);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Посылка";
            // 
            // listBoxRulePremise
            // 
            this.listBoxRulePremise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRulePremise.FormattingEnabled = true;
            this.listBoxRulePremise.ItemHeight = 16;
            this.listBoxRulePremise.Location = new System.Drawing.Point(3, 18);
            this.listBoxRulePremise.Name = "listBoxRulePremise";
            this.listBoxRulePremise.Size = new System.Drawing.Size(372, 222);
            this.listBoxRulePremise.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageRules);
            this.tabControlMain.Controls.Add(this.tabPageVariables);
            this.tabControlMain.Controls.Add(this.tabPageDomains);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 30);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1120, 662);
            this.tabControlMain.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 692);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Оболочка ЭС";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabPageDomains.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tabPageVariables.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabPageRules.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem консультацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьКонсультациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьОбъяснениеToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageDomains;
        private System.Windows.Forms.TabPage tabPageVariables;
        private System.Windows.Forms.TabPage tabPageRules;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listViewRules;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonDeleteRule;
        private System.Windows.Forms.Button buttonAddRule;
        private System.Windows.Forms.Button buttonEditRule;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxRuleConclusion;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxRulePremise;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListView listViewDomains;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonAddDomain;
        private System.Windows.Forms.Button buttonEditDomain;
        private System.Windows.Forms.Button buttonDeleteDomain;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox listBoxDomainValues;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelVariableQuestionText;
        private System.Windows.Forms.ListView listViewVariables;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonAddVariable;
        private System.Windows.Forms.Button buttonEditVariable;
        private System.Windows.Forms.Button buttonDeleteVariable;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBoxVariableDomainValue;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

