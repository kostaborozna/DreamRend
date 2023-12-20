namespace DreamRend
{
	partial class Autorization
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
			passwordTextBox = new TextBox();
			button1 = new Button();
			button2 = new Button();
			emailTextBox = new TextBox();
			label1 = new Label();
			button3 = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// passwordTextBox
			// 
			passwordTextBox.Font = new Font("Microsoft JhengHei UI", 12F);
			passwordTextBox.Location = new Point(3, 47);
			passwordTextBox.Multiline = true;
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.PasswordChar = '•';
			passwordTextBox.PlaceholderText = "Пароль";
			passwordTextBox.Size = new Size(254, 41);
			passwordTextBox.TabIndex = 5;
			// 
			// button1
			// 
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Microsoft JhengHei UI", 9.75F);
			button1.ForeColor = SystemColors.ControlDark;
			button1.Location = new Point(136, 3);
			button1.Name = "button1";
			button1.Size = new Size(123, 55);
			button1.TabIndex = 6;
			button1.Text = "Регистрация";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.White;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button2.ForeColor = SystemColors.ControlDark;
			button2.Location = new Point(3, 3);
			button2.Name = "button2";
			button2.Size = new Size(125, 55);
			button2.TabIndex = 7;
			button2.Text = "Забыли пароль?";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// emailTextBox
			// 
			emailTextBox.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			emailTextBox.Location = new Point(3, 3);
			emailTextBox.Multiline = true;
			emailTextBox.Name = "emailTextBox";
			emailTextBox.PlaceholderText = "Email";
			emailTextBox.Size = new Size(254, 38);
			emailTextBox.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(105, 9);
			label1.Name = "label1";
			label1.Size = new Size(177, 30);
			label1.TabIndex = 10;
			label1.Text = "Авторизация";
			// 
			// button3
			// 
			button3.BackColor = Color.FromArgb(0, 122, 174);
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.ForeColor = SystemColors.Control;
			button3.Location = new Point(3, 94);
			button3.Name = "button3";
			button3.Size = new Size(260, 46);
			button3.TabIndex = 8;
			button3.Text = "Войти";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(emailTextBox, 0, 0);
			tableLayoutPanel1.Controls.Add(passwordTextBox, 0, 1);
			tableLayoutPanel1.Controls.Add(button3, 0, 2);
			tableLayoutPanel1.Location = new Point(59, 61);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.35165F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.64835F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
			tableLayoutPanel1.Size = new Size(266, 143);
			tableLayoutPanel1.TabIndex = 11;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(button2, 0, 0);
			tableLayoutPanel2.Controls.Add(button1, 1, 0);
			tableLayoutPanel2.Location = new Point(59, 210);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(266, 72);
			tableLayoutPanel2.TabIndex = 12;
			// 
			// Autorization
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(400, 324);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(label1);
			ForeColor = Color.FromArgb(135, 203, 172);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Autorization";
			Text = "Drem Rent";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox passwordTextBox;
		private Button button1;
		private Button button2;
		private TextBox emailTextBox;
		private Label label1;
		private Button button3;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
	}
}
