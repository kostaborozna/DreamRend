﻿namespace DreamRend
{
	partial class Registration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
			label1 = new Label();
			emailTextBox = new TextBox();
			MnameTextBox = new TextBox();
			label2 = new Label();
			FnametextBox = new TextBox();
			label3 = new Label();
			passwordTextBox = new TextBox();
			label5 = new Label();
			button1 = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			numbertextBox = new TextBox();
			label4 = new Label();
			comboBox1 = new ComboBox();
			label6 = new Label();
			iconButton2 = new FontAwesome.Sharp.IconButton();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft JhengHei UI", 12F);
			label1.Location = new Point(4, 0);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(83, 30);
			label1.TabIndex = 0;
			label1.Text = "Почта";
			// 
			// emailTextBox
			// 
			emailTextBox.Font = new Font("Microsoft JhengHei UI", 12F);
			emailTextBox.Location = new Point(427, 5);
			emailTextBox.Margin = new Padding(4, 5, 4, 5);
			emailTextBox.Name = "emailTextBox";
			emailTextBox.Size = new Size(414, 38);
			emailTextBox.TabIndex = 1;
			// 
			// MnameTextBox
			// 
			MnameTextBox.Font = new Font("Microsoft JhengHei UI", 12F);
			MnameTextBox.Location = new Point(427, 5);
			MnameTextBox.Margin = new Padding(4, 5, 4, 5);
			MnameTextBox.Name = "MnameTextBox";
			MnameTextBox.Size = new Size(414, 38);
			MnameTextBox.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft JhengHei UI", 12F);
			label2.Location = new Point(4, 0);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(123, 30);
			label2.TabIndex = 3;
			label2.Text = "Фамилия";
			// 
			// FnametextBox
			// 
			FnametextBox.Font = new Font("Microsoft JhengHei UI", 12F);
			FnametextBox.Location = new Point(427, 99);
			FnametextBox.Margin = new Padding(4, 5, 4, 5);
			FnametextBox.Name = "FnametextBox";
			FnametextBox.Size = new Size(414, 38);
			FnametextBox.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft JhengHei UI", 12F);
			label3.Location = new Point(4, 94);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(63, 30);
			label3.TabIndex = 5;
			label3.Text = "Имя";
			// 
			// passwordTextBox
			// 
			passwordTextBox.Font = new Font("Microsoft JhengHei UI", 12F);
			passwordTextBox.Location = new Point(427, 112);
			passwordTextBox.Margin = new Padding(4, 5, 4, 5);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.PasswordChar = '•';
			passwordTextBox.Size = new Size(414, 38);
			passwordTextBox.TabIndex = 9;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft JhengHei UI", 12F);
			label5.Location = new Point(4, 107);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(99, 30);
			label5.TabIndex = 10;
			label5.Text = "Пароль";
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(0, 122, 174);
			button1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
			button1.ForeColor = SystemColors.Control;
			button1.Location = new Point(327, 647);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(364, 102);
			button1.TabIndex = 11;
			button1.Text = "Зарегистрироваться";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(emailTextBox, 1, 0);
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(label5, 0, 1);
			tableLayoutPanel1.Controls.Add(passwordTextBox, 1, 1);
			tableLayoutPanel1.Font = new Font("Microsoft JhengHei UI", 12F);
			tableLayoutPanel1.Location = new Point(86, 33);
			tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(847, 215);
			tableLayoutPanel1.TabIndex = 12;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(numbertextBox, 0, 3);
			tableLayoutPanel2.Controls.Add(label4, 0, 2);
			tableLayoutPanel2.Controls.Add(label2, 0, 0);
			tableLayoutPanel2.Controls.Add(label3, 0, 1);
			tableLayoutPanel2.Controls.Add(FnametextBox, 1, 1);
			tableLayoutPanel2.Controls.Add(MnameTextBox, 1, 0);
			tableLayoutPanel2.Controls.Add(comboBox1, 1, 2);
			tableLayoutPanel2.Controls.Add(label6, 0, 3);
			tableLayoutPanel2.Font = new Font("Microsoft JhengHei UI", 12F);
			tableLayoutPanel2.Location = new Point(86, 258);
			tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 4;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.Size = new Size(847, 378);
			tableLayoutPanel2.TabIndex = 13;
			// 
			// numbertextBox
			// 
			numbertextBox.Font = new Font("Microsoft JhengHei UI", 12F);
			numbertextBox.Location = new Point(427, 287);
			numbertextBox.Margin = new Padding(4, 5, 4, 5);
			numbertextBox.Name = "numbertextBox";
			numbertextBox.Size = new Size(414, 38);
			numbertextBox.TabIndex = 10;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft JhengHei UI", 12F);
			label4.Location = new Point(4, 188);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(172, 30);
			label4.TabIndex = 7;
			label4.Text = "Способ связи";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "По номеру телефона", "Социальные сети" });
			comboBox1.Location = new Point(427, 193);
			comboBox1.Margin = new Padding(4, 5, 4, 5);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(414, 38);
			comboBox1.TabIndex = 8;
			comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Microsoft JhengHei UI", 12F);
			label6.Location = new Point(4, 282);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(190, 30);
			label6.TabIndex = 9;
			label6.Text = "{indexOfChose}";
			// 
			// iconButton2
			// 
			iconButton2.FlatAppearance.BorderSize = 0;
			iconButton2.FlatStyle = FlatStyle.Flat;
			iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
			iconButton2.IconColor = Color.Black;
			iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton2.IconSize = 28;
			iconButton2.Location = new Point(17, 20);
			iconButton2.Margin = new Padding(4, 5, 4, 5);
			iconButton2.Name = "iconButton2";
			iconButton2.Size = new Size(46, 70);
			iconButton2.TabIndex = 15;
			iconButton2.UseVisualStyleBackColor = true;
			iconButton2.Click += iconButton2_Click;
			// 
			// Registration
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(976, 787);
			Controls.Add(iconButton2);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(button1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 5, 4, 5);
			MaximizeBox = false;
			Name = "Registration";
			Text = "Dream Rent";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private TextBox emailTextBox;
		private TextBox MnameTextBox;
		private Label label2;
		private TextBox FnametextBox;
		private Label label3;
		private TextBox passwordTextBox;
		private Label label5;
		private Button button1;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label4;
		private ComboBox comboBox1;
		private FontAwesome.Sharp.IconButton iconButton2;
		private Label label6;
		private TextBox numbertextBox;
	}
}