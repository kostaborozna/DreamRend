namespace DreamRend
{
	partial class CreateAp
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
			pictureBox1 = new PictureBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			richTextBox1 = new RichTextBox();
			label4 = new Label();
			button2 = new Button();
			button3 = new Button();
			areaTextBox = new TextBox();
			roomsCountComboBox = new ComboBox();
			addrestextBox = new TextBox();
			label3 = new Label();
			label6 = new Label();
			label5 = new Label();
			costTextBox = new TextBox();
			label1 = new Label();
			label2 = new Label();
			periodComboBox = new ComboBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Location = new Point(3, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(408, 309);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(richTextBox1, 1, 5);
			tableLayoutPanel1.Controls.Add(label4, 0, 5);
			tableLayoutPanel1.Controls.Add(button2, 0, 6);
			tableLayoutPanel1.Controls.Add(button3, 1, 6);
			tableLayoutPanel1.Controls.Add(areaTextBox, 1, 4);
			tableLayoutPanel1.Controls.Add(roomsCountComboBox, 1, 2);
			tableLayoutPanel1.Controls.Add(addrestextBox, 1, 3);
			tableLayoutPanel1.Controls.Add(label3, 0, 2);
			tableLayoutPanel1.Controls.Add(label6, 0, 4);
			tableLayoutPanel1.Controls.Add(label5, 0, 3);
			tableLayoutPanel1.Controls.Add(costTextBox, 1, 1);
			tableLayoutPanel1.Controls.Add(label1, 0, 1);
			tableLayoutPanel1.Controls.Add(label2, 0, 0);
			tableLayoutPanel1.Controls.Add(periodComboBox, 1, 0);
			tableLayoutPanel1.Location = new Point(453, 12);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 7;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
			tableLayoutPanel1.Size = new Size(397, 456);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(201, 268);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(193, 59);
			richTextBox1.TabIndex = 4;
			richTextBox1.Text = "";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(3, 265);
			label4.Name = "label4";
			label4.Size = new Size(62, 15);
			label4.TabIndex = 3;
			label4.Text = "Описание";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(255, 192, 192);
			button2.Location = new Point(3, 343);
			button2.Name = "button2";
			button2.Size = new Size(192, 75);
			button2.TabIndex = 7;
			button2.Text = "Выйти";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.FromArgb(135, 203, 172);
			button3.Location = new Point(201, 343);
			button3.Name = "button3";
			button3.Size = new Size(193, 75);
			button3.TabIndex = 8;
			button3.Text = "Отправить объявление на проверку";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// areaTextBox
			// 
			areaTextBox.Location = new Point(201, 208);
			areaTextBox.Multiline = true;
			areaTextBox.Name = "areaTextBox";
			areaTextBox.PlaceholderText = "м²";
			areaTextBox.Size = new Size(193, 36);
			areaTextBox.TabIndex = 4;
			// 
			// roomsCountComboBox
			// 
			roomsCountComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			roomsCountComboBox.FormattingEnabled = true;
			roomsCountComboBox.Items.AddRange(new object[] { "Студия", "1 комната", "2 комнаты", "3 комнаты ", "4 комнаты", "5 и больше" });
			roomsCountComboBox.Location = new Point(201, 101);
			roomsCountComboBox.Name = "roomsCountComboBox";
			roomsCountComboBox.Size = new Size(178, 23);
			roomsCountComboBox.TabIndex = 6;
			// 
			// addrestextBox
			// 
			addrestextBox.Location = new Point(201, 159);
			addrestextBox.Multiline = true;
			addrestextBox.Name = "addrestextBox";
			addrestextBox.Size = new Size(193, 36);
			addrestextBox.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 98);
			label3.Name = "label3";
			label3.Size = new Size(122, 15);
			label3.TabIndex = 5;
			label3.Text = "Колличество комнат";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(3, 205);
			label6.Name = "label6";
			label6.Size = new Size(59, 15);
			label6.TabIndex = 3;
			label6.Text = "Площадь";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 156);
			label5.Name = "label5";
			label5.Size = new Size(40, 15);
			label5.TabIndex = 0;
			label5.Text = "Адрес";
			// 
			// costTextBox
			// 
			costTextBox.Dock = DockStyle.Fill;
			costTextBox.Location = new Point(201, 52);
			costTextBox.Name = "costTextBox";
			costTextBox.Size = new Size(193, 23);
			costTextBox.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 49);
			label1.Name = "label1";
			label1.Size = new Size(35, 15);
			label1.TabIndex = 0;
			label1.Text = "Цена";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(91, 15);
			label2.TabIndex = 3;
			label2.Text = "На какой срок?";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// periodComboBox
			// 
			periodComboBox.Dock = DockStyle.Left;
			periodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			periodComboBox.FormattingEnabled = true;
			periodComboBox.Items.AddRange(new object[] { "На длительный срок", "Посуточно" });
			periodComboBox.Location = new Point(201, 3);
			periodComboBox.Name = "periodComboBox";
			periodComboBox.Size = new Size(178, 23);
			periodComboBox.TabIndex = 4;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(button1, 0, 1);
			tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
			tableLayoutPanel2.Location = new Point(12, 15);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 69.637886F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30.3621178F));
			tableLayoutPanel2.Size = new Size(414, 453);
			tableLayoutPanel2.TabIndex = 2;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top;
			button1.Location = new Point(131, 318);
			button1.Name = "button1";
			button1.Size = new Size(152, 98);
			button1.TabIndex = 1;
			button1.Text = "Добавить фото на главную страницу";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// CreateAp
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1000, 614);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			Name = "CreateAp";
			Text = "CreateAp";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private TextBox costTextBox;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label2;
		private ComboBox periodComboBox;
		private Button button1;
		private Label label3;
		private ComboBox roomsCountComboBox;
		private Button button2;
		private Button button3;
		private TextBox areaTextBox;
		private TextBox addrestextBox;
		private Label label6;
		private Label label5;
		private Label label4;
		private RichTextBox richTextBox1;
	}
}