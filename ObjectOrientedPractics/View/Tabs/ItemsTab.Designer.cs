namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            ItemsListBox = new ListBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            InfoBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            NameBox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            IdBox = new TextBox();
            CostBox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel5);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel4);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel3);
            splitContainer1.Size = new Size(939, 663);
            splitContainer1.SplitterDistance = 426;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ItemsListBox, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.517134F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95.4828644F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.Size = new Size(426, 663);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ItemsListBox
            // 
            ItemsListBox.BorderStyle = BorderStyle.FixedSingle;
            ItemsListBox.Dock = DockStyle.Fill;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(3, 30);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(420, 566);
            ItemsListBox.TabIndex = 2;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(420, 27);
            label1.TabIndex = 1;
            label1.Text = "Items";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.3630562F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.6369438F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel2.Controls.Add(button2, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 602);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(420, 58);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(158, 3);
            button2.Name = "button2";
            button2.Size = new Size(153, 52);
            button2.TabIndex = 2;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(149, 52);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(InfoBox, 0, 3);
            tableLayoutPanel5.Controls.Add(label6, 0, 2);
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Controls.Add(NameBox, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 151);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 83.6F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 264F));
            tableLayoutPanel5.Size = new Size(509, 512);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // InfoBox
            // 
            InfoBox.BorderStyle = BorderStyle.FixedSingle;
            InfoBox.Dock = DockStyle.Fill;
            InfoBox.Location = new Point(3, 250);
            InfoBox.Multiline = true;
            InfoBox.Name = "InfoBox";
            InfoBox.Size = new Size(503, 259);
            InfoBox.TabIndex = 6;
            InfoBox.TextChanged += InfoBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 212);
            label6.Name = "label6";
            label6.Size = new Size(503, 35);
            label6.TabIndex = 5;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(503, 34);
            label5.TabIndex = 3;
            label5.Text = "Name:";
            // 
            // NameBox
            // 
            NameBox.BorderStyle = BorderStyle.FixedSingle;
            NameBox.Dock = DockStyle.Fill;
            NameBox.Location = new Point(3, 37);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(503, 172);
            NameBox.TabIndex = 4;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.21611F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.78389F));
            tableLayoutPanel4.Controls.Add(label4, 0, 1);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(IdBox, 1, 0);
            tableLayoutPanel4.Controls.Add(CostBox, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 49);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(509, 102);
            tableLayoutPanel4.TabIndex = 1;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 51);
            label4.Name = "label4";
            label4.Size = new Size(46, 51);
            label4.TabIndex = 2;
            label4.Text = "Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 51);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // IdBox
            // 
            IdBox.BorderStyle = BorderStyle.FixedSingle;
            IdBox.Dock = DockStyle.Left;
            IdBox.Location = new Point(55, 3);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(169, 27);
            IdBox.TabIndex = 3;
            // 
            // CostBox
            // 
            CostBox.BorderStyle = BorderStyle.FixedSingle;
            CostBox.Dock = DockStyle.Left;
            CostBox.Location = new Point(55, 54);
            CostBox.Name = "CostBox";
            CostBox.Size = new Size(169, 27);
            CostBox.TabIndex = 4;
            CostBox.TextChanged += CostBox_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(509, 49);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(503, 49);
            label2.TabIndex = 1;
            label2.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ItemsTab";
            Size = new Size(939, 663);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private Label label1;
        private ListBox ItemsListBox;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label5;
        private TextBox NameBox;
        private TextBox IdBox;
        private TextBox CostBox;
        private TextBox InfoBox;
        private Label label6;
    }
}
