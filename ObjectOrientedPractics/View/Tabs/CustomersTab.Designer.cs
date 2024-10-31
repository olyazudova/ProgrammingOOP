namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            label1 = new Label();
            CustomersListBox = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel4 = new TableLayoutPanel();
            AddressBox = new TextBox();
            FullNameBox = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            IdBox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(872, 604);
            splitContainer1.SplitterDistance = 397;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(CustomersListBox, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.5289855F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95.4710159F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.Size = new Size(397, 604);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(391, 24);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // CustomersListBox
            // 
            CustomersListBox.BorderStyle = BorderStyle.FixedSingle;
            CustomersListBox.Dock = DockStyle.Fill;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(3, 27);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(391, 510);
            CustomersListBox.TabIndex = 1;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.145298F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.854702F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 543);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.Size = new Size(391, 58);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(144, 3);
            button2.Name = "button2";
            button2.Size = new Size(139, 52);
            button2.TabIndex = 1;
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
            button1.Size = new Size(135, 52);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel4);
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel3);
            splitContainer2.Size = new Size(471, 604);
            splitContainer2.SplitterDistance = 396;
            splitContainer2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.84058F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.1594238F));
            tableLayoutPanel4.Controls.Add(AddressBox, 1, 2);
            tableLayoutPanel4.Controls.Add(FullNameBox, 1, 1);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(label5, 0, 2);
            tableLayoutPanel4.Controls.Add(label4, 0, 1);
            tableLayoutPanel4.Controls.Add(IdBox, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 45);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5346527F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 53.4653473F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 230F));
            tableLayoutPanel4.Size = new Size(471, 351);
            tableLayoutPanel4.TabIndex = 1;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // AddressBox
            // 
            AddressBox.BorderStyle = BorderStyle.FixedSingle;
            AddressBox.Dock = DockStyle.Fill;
            AddressBox.Location = new Point(91, 123);
            AddressBox.Multiline = true;
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(377, 225);
            AddressBox.TabIndex = 5;
            AddressBox.TextChanged += textBox3_TextChanged;
            // 
            // FullNameBox
            // 
            FullNameBox.BorderStyle = BorderStyle.FixedSingle;
            FullNameBox.Dock = DockStyle.Fill;
            FullNameBox.Location = new Point(91, 59);
            FullNameBox.Name = "FullNameBox";
            FullNameBox.Size = new Size(377, 27);
            FullNameBox.TabIndex = 4;
            FullNameBox.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 56);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 120);
            label5.Name = "label5";
            label5.Size = new Size(82, 231);
            label5.TabIndex = 2;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 56);
            label4.Name = "label4";
            label4.Size = new Size(82, 64);
            label4.TabIndex = 1;
            label4.Text = "Full Name:";
            // 
            // IdBox
            // 
            IdBox.BorderStyle = BorderStyle.FixedSingle;
            IdBox.Dock = DockStyle.Left;
            IdBox.Location = new Point(91, 3);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(125, 27);
            IdBox.TabIndex = 3;
            IdBox.TextChanged += textBox1_TextChanged_1;
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
            tableLayoutPanel3.Size = new Size(471, 45);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(465, 45);
            label2.TabIndex = 0;
            label2.Text = "Selected Customer";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CustomersTab";
            Size = new Size(872, 604);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ListBox CustomersListBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Label label5;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TextBox AddressBox;
        private TextBox FullNameBox;
        private TextBox IdBox;
    }
}
