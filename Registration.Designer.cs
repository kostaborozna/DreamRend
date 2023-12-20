namespace DreamRend
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
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(41, 15);
			label1.TabIndex = 0;
			label1.Text = "Почта";
			// 
			// emailTextBox
			// 
			emailTextBox.Location = new Point(114, 3);
			emailTextBox.Multiline = true;
			emailTextBox.Name = "emailTextBox";
			emailTextBox.Size = new Size(95, 23);
			emailTextBox.TabIndex = 1;
			// 
			// MnameTextBox
			// 
			MnameTextBox.Location = new Point(124, 3);
			MnameTextBox.Multiline = true;
			MnameTextBox.Name = "MnameTextBox";
			MnameTextBox.Size = new Size(94, 23);
			MnameTextBox.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(58, 15);
			label2.TabIndex = 3;
			label2.Text = "Фамилия";
			// 
			// FnametextBox
			// 
			FnametextBox.Location = new Point(124, 57);
			FnametextBox.Multiline = true;
			FnametextBox.Name = "FnametextBox";
			FnametextBox.Size = new Size(94, 23);
			FnametextBox.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 54);
			label3.Name = "label3";
			label3.Size = new Size(31, 15);
			label3.TabIndex = 5;
			label3.Text = "Имя";
			// 
			// passwordTextBox
			// 
			passwordTextBox.Location = new Point(114, 57);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.Size = new Size(95, 23);
			passwordTextBox.TabIndex = 9;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 54);
			label5.Name = "label5";
			label5.Size = new Size(49, 15);
			label5.TabIndex = 10;
			label5.Text = "Пароль";
			// 
			// button1
			// 
			button1.Location = new Point(263, 208);
			button1.Name = "button1";
			button1.Size = new Size(128, 61);
			button1.TabIndex = 11;
			button1.Text = "Зарегистророватся";
			button1.UseVisualStyleBackColor = true;
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
			tableLayoutPanel1.Location = new Point(80, 74);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(222, 108);
			tableLayoutPanel1.TabIndex = 12;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(label2, 0, 0);
			tableLayoutPanel2.Controls.Add(label3, 0, 1);
			tableLayoutPanel2.Controls.Add(FnametextBox, 1, 1);
			tableLayoutPanel2.Controls.Add(MnameTextBox, 1, 0);
			tableLayoutPanel2.Location = new Point(357, 74);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(243, 108);
			tableLayoutPanel2.TabIndex = 13;
			// 
			// Registration
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(652, 411);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(button1);
			Name = "Registration";
			Text = "Drem Rent";
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
	}
}