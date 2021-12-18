namespace ShellProgramSystem.Forms
{
    partial class FormDomainEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDomainName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxDomainValues = new System.Windows.Forms.ListBox();
            this.buttonDeleteDomainValue = new System.Windows.Forms.Button();
            this.textBoxNewDomainValue = new System.Windows.Forms.TextBox();
            this.buttonAddDomainValue = new System.Windows.Forms.Button();
            this.buttonChangeDomainValue = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNewDomainValue, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddDomainValue, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonChangeDomainValue, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonOK, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 8, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.48153F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.20224F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.20224F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.20224F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.20224F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.354754F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.354753F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(873, 483);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 10);
            this.groupBox1.Controls.Add(this.textBoxDomainName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Имя домена:";
            // 
            // textBoxDomainName
            // 
            this.textBoxDomainName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDomainName.Location = new System.Drawing.Point(3, 18);
            this.textBoxDomainName.Multiline = true;
            this.textBoxDomainName.Name = "textBoxDomainName";
            this.textBoxDomainName.Size = new System.Drawing.Size(861, 32);
            this.textBoxDomainName.TabIndex = 0;
            this.textBoxDomainName.TextChanged += new System.EventHandler(this.textBoxDomainName_TextChanged);
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 10);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 62);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 4);
            this.groupBox2.Size = new System.Drawing.Size(867, 338);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Допустимые значения домена:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxDomainValues, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeleteDomainValue, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.47369F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(861, 317);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listBoxDomainValues
            // 
            this.listBoxDomainValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDomainValues.FormattingEnabled = true;
            this.listBoxDomainValues.ItemHeight = 16;
            this.listBoxDomainValues.Location = new System.Drawing.Point(3, 3);
            this.listBoxDomainValues.Name = "listBoxDomainValues";
            this.listBoxDomainValues.Size = new System.Drawing.Size(855, 277);
            this.listBoxDomainValues.TabIndex = 0;
            this.listBoxDomainValues.SelectedIndexChanged += new System.EventHandler(this.listBoxDomainValues_SelectedIndexChanged);
            // 
            // buttonDeleteDomainValue
            // 
            this.buttonDeleteDomainValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteDomainValue.Location = new System.Drawing.Point(3, 286);
            this.buttonDeleteDomainValue.Name = "buttonDeleteDomainValue";
            this.buttonDeleteDomainValue.Size = new System.Drawing.Size(855, 28);
            this.buttonDeleteDomainValue.TabIndex = 1;
            this.buttonDeleteDomainValue.Text = "Удалить";
            this.buttonDeleteDomainValue.UseVisualStyleBackColor = true;
            this.buttonDeleteDomainValue.Click += new System.EventHandler(this.buttonDeleteDomainValue_Click);
            // 
            // textBoxNewDomainValue
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxNewDomainValue, 6);
            this.textBoxNewDomainValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNewDomainValue.Location = new System.Drawing.Point(3, 406);
            this.textBoxNewDomainValue.Multiline = true;
            this.textBoxNewDomainValue.Name = "textBoxNewDomainValue";
            this.textBoxNewDomainValue.Size = new System.Drawing.Size(516, 28);
            this.textBoxNewDomainValue.TabIndex = 2;
            this.textBoxNewDomainValue.TextChanged += new System.EventHandler(this.textBoxNewDomainValue_TextChanged);
            // 
            // buttonAddDomainValue
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonAddDomainValue, 2);
            this.buttonAddDomainValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddDomainValue.Location = new System.Drawing.Point(525, 406);
            this.buttonAddDomainValue.Name = "buttonAddDomainValue";
            this.buttonAddDomainValue.Size = new System.Drawing.Size(168, 28);
            this.buttonAddDomainValue.TabIndex = 3;
            this.buttonAddDomainValue.Text = "Добавить";
            this.buttonAddDomainValue.UseVisualStyleBackColor = true;
            this.buttonAddDomainValue.Click += new System.EventHandler(this.buttonAddDomainValue_Click);
            // 
            // buttonChangeDomainValue
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonChangeDomainValue, 2);
            this.buttonChangeDomainValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChangeDomainValue.Location = new System.Drawing.Point(699, 406);
            this.buttonChangeDomainValue.Name = "buttonChangeDomainValue";
            this.buttonChangeDomainValue.Size = new System.Drawing.Size(171, 28);
            this.buttonChangeDomainValue.TabIndex = 4;
            this.buttonChangeDomainValue.Text = "Изменить";
            this.buttonChangeDomainValue.UseVisualStyleBackColor = true;
            this.buttonChangeDomainValue.Click += new System.EventHandler(this.buttonChangeDomainValue_Click);
            // 
            // buttonOK
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonOK, 2);
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOK.Location = new System.Drawing.Point(525, 448);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(168, 32);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonCancel, 2);
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(699, 448);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(171, 32);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormDomainEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormDomainEdit";
            this.Text = "FormDomainEdit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDomainName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listBoxDomainValues;
        private System.Windows.Forms.Button buttonDeleteDomainValue;
        private System.Windows.Forms.TextBox textBoxNewDomainValue;
        private System.Windows.Forms.Button buttonAddDomainValue;
        private System.Windows.Forms.Button buttonChangeDomainValue;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}