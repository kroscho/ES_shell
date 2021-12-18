namespace ShellProgramSystem.Forms
{
    partial class FormRuleEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxPremiseFacts = new System.Windows.Forms.ListBox();
            this.listBoxConclusionFacts = new System.Windows.Forms.ListBox();
            this.buttonAddPremiseFact = new System.Windows.Forms.Button();
            this.buttonEditPremiseFact = new System.Windows.Forms.Button();
            this.buttonDeletePremiseFact = new System.Windows.Forms.Button();
            this.buttonAddConclusionFact = new System.Windows.Forms.Button();
            this.buttonEditConclusionFact = new System.Windows.Forms.Button();
            this.buttonDeleteConclusionFact = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRuleName = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxRuleDescription = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOk, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 8, 8);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 436);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 10);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 56);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 4);
            this.groupBox2.Size = new System.Drawing.Size(893, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Домен:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.64539F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35461F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxPremiseFacts, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxConclusionFacts, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddPremiseFact, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonEditPremiseFact, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeletePremiseFact, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddConclusionFact, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonEditConclusionFact, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeleteConclusionFact, 6, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(887, 171);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listBoxPremiseFacts
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.listBoxPremiseFacts, 3);
            this.listBoxPremiseFacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPremiseFacts.FormattingEnabled = true;
            this.listBoxPremiseFacts.ItemHeight = 16;
            this.listBoxPremiseFacts.Location = new System.Drawing.Point(3, 3);
            this.listBoxPremiseFacts.Name = "listBoxPremiseFacts";
            this.listBoxPremiseFacts.Size = new System.Drawing.Size(426, 134);
            this.listBoxPremiseFacts.TabIndex = 0;
            this.listBoxPremiseFacts.SelectedIndexChanged += new System.EventHandler(this.listBoxPremiseFacts_SelectedIndexChanged);
            // 
            // listBoxConclusionFacts
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.listBoxConclusionFacts, 3);
            this.listBoxConclusionFacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxConclusionFacts.FormattingEnabled = true;
            this.listBoxConclusionFacts.HorizontalScrollbar = true;
            this.listBoxConclusionFacts.ItemHeight = 16;
            this.listBoxConclusionFacts.Location = new System.Drawing.Point(452, 3);
            this.listBoxConclusionFacts.Name = "listBoxConclusionFacts";
            this.listBoxConclusionFacts.Size = new System.Drawing.Size(432, 134);
            this.listBoxConclusionFacts.TabIndex = 1;
            this.listBoxConclusionFacts.SelectedIndexChanged += new System.EventHandler(this.listBoxConclusionFacts_SelectedIndexChanged);
            // 
            // buttonAddPremiseFact
            // 
            this.buttonAddPremiseFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddPremiseFact.Location = new System.Drawing.Point(3, 143);
            this.buttonAddPremiseFact.Name = "buttonAddPremiseFact";
            this.buttonAddPremiseFact.Size = new System.Drawing.Size(134, 25);
            this.buttonAddPremiseFact.TabIndex = 2;
            this.buttonAddPremiseFact.Text = "Добавить";
            this.buttonAddPremiseFact.UseVisualStyleBackColor = true;
            this.buttonAddPremiseFact.Click += new System.EventHandler(this.buttonAddPremiseFact_Click);
            // 
            // buttonEditPremiseFact
            // 
            this.buttonEditPremiseFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditPremiseFact.Location = new System.Drawing.Point(143, 143);
            this.buttonEditPremiseFact.Name = "buttonEditPremiseFact";
            this.buttonEditPremiseFact.Size = new System.Drawing.Size(137, 25);
            this.buttonEditPremiseFact.TabIndex = 3;
            this.buttonEditPremiseFact.Text = "Изменить";
            this.buttonEditPremiseFact.UseVisualStyleBackColor = true;
            this.buttonEditPremiseFact.Click += new System.EventHandler(this.buttonEditPremiseFact_Click);
            // 
            // buttonDeletePremiseFact
            // 
            this.buttonDeletePremiseFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeletePremiseFact.Location = new System.Drawing.Point(286, 143);
            this.buttonDeletePremiseFact.Name = "buttonDeletePremiseFact";
            this.buttonDeletePremiseFact.Size = new System.Drawing.Size(143, 25);
            this.buttonDeletePremiseFact.TabIndex = 4;
            this.buttonDeletePremiseFact.Text = "Удалить";
            this.buttonDeletePremiseFact.UseVisualStyleBackColor = true;
            this.buttonDeletePremiseFact.Click += new System.EventHandler(this.buttonDeletePremiseFact_Click);
            // 
            // buttonAddConclusionFact
            // 
            this.buttonAddConclusionFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddConclusionFact.Location = new System.Drawing.Point(452, 143);
            this.buttonAddConclusionFact.Name = "buttonAddConclusionFact";
            this.buttonAddConclusionFact.Size = new System.Drawing.Size(139, 25);
            this.buttonAddConclusionFact.TabIndex = 5;
            this.buttonAddConclusionFact.Text = "Добавить";
            this.buttonAddConclusionFact.UseVisualStyleBackColor = true;
            this.buttonAddConclusionFact.Click += new System.EventHandler(this.buttonAddConclusionFact_Click);
            // 
            // buttonEditConclusionFact
            // 
            this.buttonEditConclusionFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditConclusionFact.Location = new System.Drawing.Point(597, 143);
            this.buttonEditConclusionFact.Name = "buttonEditConclusionFact";
            this.buttonEditConclusionFact.Size = new System.Drawing.Size(156, 25);
            this.buttonEditConclusionFact.TabIndex = 6;
            this.buttonEditConclusionFact.Text = "Изменить";
            this.buttonEditConclusionFact.UseVisualStyleBackColor = true;
            this.buttonEditConclusionFact.Click += new System.EventHandler(this.buttonEditConclusionFact_Click);
            // 
            // buttonDeleteConclusionFact
            // 
            this.buttonDeleteConclusionFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteConclusionFact.Location = new System.Drawing.Point(759, 143);
            this.buttonDeleteConclusionFact.Name = "buttonDeleteConclusionFact";
            this.buttonDeleteConclusionFact.Size = new System.Drawing.Size(125, 25);
            this.buttonDeleteConclusionFact.TabIndex = 7;
            this.buttonDeleteConclusionFact.Text = "Удалить";
            this.buttonDeleteConclusionFact.UseVisualStyleBackColor = true;
            this.buttonDeleteConclusionFact.Click += new System.EventHandler(this.buttonDeleteConclusionFact_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 10);
            this.groupBox1.Controls.Add(this.textBoxRuleName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Имя правила:";
            // 
            // textBoxRuleName
            // 
            this.textBoxRuleName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxRuleName.Location = new System.Drawing.Point(3, 22);
            this.textBoxRuleName.Name = "textBoxRuleName";
            this.textBoxRuleName.Size = new System.Drawing.Size(887, 22);
            this.textBoxRuleName.TabIndex = 0;
            this.textBoxRuleName.TextChanged += new System.EventHandler(this.textBoxRuleName_TextChanged);
            // 
            // buttonOk
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonOk, 2);
            this.buttonOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOk.Location = new System.Drawing.Point(519, 404);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(188, 29);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonCancel, 2);
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCancel.Location = new System.Drawing.Point(713, 404);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(183, 29);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 10);
            this.groupBox3.Controls.Add(this.textBoxRuleDescription);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 254);
            this.groupBox3.Name = "groupBox3";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox3, 3);
            this.groupBox3.Size = new System.Drawing.Size(893, 144);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пояснение:";
            // 
            // textBoxRuleDescription
            // 
            this.textBoxRuleDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRuleDescription.Location = new System.Drawing.Point(3, 18);
            this.textBoxRuleDescription.Multiline = true;
            this.textBoxRuleDescription.Name = "textBoxRuleDescription";
            this.textBoxRuleDescription.Size = new System.Drawing.Size(887, 123);
            this.textBoxRuleDescription.TabIndex = 0;
            this.textBoxRuleDescription.TextChanged += new System.EventHandler(this.textBoxRuleDescription_TextChanged);
            // 
            // FormRuleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 436);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormRuleEdit";
            this.Text = "FormRuleEdit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listBoxPremiseFacts;
        private System.Windows.Forms.ListBox listBoxConclusionFacts;
        private System.Windows.Forms.Button buttonAddPremiseFact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRuleName;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEditPremiseFact;
        private System.Windows.Forms.Button buttonDeletePremiseFact;
        private System.Windows.Forms.Button buttonAddConclusionFact;
        private System.Windows.Forms.Button buttonEditConclusionFact;
        private System.Windows.Forms.Button buttonDeleteConclusionFact;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxRuleDescription;
    }
}