namespace DreamRend
{
	partial class Profile
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
			iconButton3 = new FontAwesome.Sharp.IconButton();
			iconButton4 = new FontAwesome.Sharp.IconButton();
			button3 = new Button();
			button4 = new Button();
			tableLayoutPanel2 = new TableLayoutPanel();
			tabPage3 = new TabPage();
			iconButton2 = new FontAwesome.Sharp.IconButton();
			iconButton1 = new FontAwesome.Sharp.IconButton();
			button2 = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			tabPage3.SuspendLayout();
			SuspendLayout();
			// 
			// iconButton3
			// 
			iconButton3.FlatAppearance.BorderSize = 0;
			iconButton3.FlatStyle = FlatStyle.Flat;
			iconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
			iconButton3.IconColor = Color.Black;
			iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton3.IconSize = 50;
			iconButton3.Location = new Point(665, 359);
			iconButton3.Name = "iconButton3";
			iconButton3.Size = new Size(89, 60);
			iconButton3.TabIndex = 4;
			iconButton3.UseVisualStyleBackColor = true;
			iconButton3.Click += iconButton2_Click;
			// 
			// iconButton4
			// 
			iconButton4.FlatAppearance.BorderSize = 0;
			iconButton4.FlatStyle = FlatStyle.Flat;
			iconButton4.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
			iconButton4.IconColor = Color.Black;
			iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton4.IconSize = 50;
			iconButton4.Location = new Point(570, 359);
			iconButton4.Name = "iconButton4";
			iconButton4.Size = new Size(89, 60);
			iconButton4.TabIndex = 3;
			iconButton4.UseVisualStyleBackColor = true;
			iconButton4.Click += iconButton1_Click;
			// 
			// button3
			// 
			button3.Location = new Point(24, 359);
			button3.Name = "button3";
			button3.Size = new Size(185, 68);
			button3.TabIndex = 2;
			button3.Text = "Вернутся на главную страницу";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button2_Click;
			// 
			// button4
			// 
			button4.Location = new Point(285, 364);
			button4.Name = "button4";
			button4.Size = new Size(171, 63);
			button4.TabIndex = 0;
			button4.Text = "Удалить объявление";
			button4.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Location = new Point(0, 0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Size = new Size(200, 100);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(iconButton3);
			tabPage3.Controls.Add(iconButton4);
			tabPage3.Controls.Add(button3);
			tabPage3.Controls.Add(button4);
			tabPage3.Location = new Point(0, 0);
			tabPage3.Name = "tabPage3";
			tabPage3.Size = new Size(200, 100);
			tabPage3.TabIndex = 0;
			// 
			// iconButton2
			// 
			iconButton2.FlatAppearance.BorderSize = 0;
			iconButton2.FlatStyle = FlatStyle.Flat;
			iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
			iconButton2.IconColor = Color.Black;
			iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton2.IconSize = 50;
			iconButton2.Location = new Point(994, 527);
			iconButton2.Margin = new Padding(4, 5, 4, 5);
			iconButton2.Name = "iconButton2";
			iconButton2.Size = new Size(127, 100);
			iconButton2.TabIndex = 8;
			iconButton2.UseVisualStyleBackColor = true;
			iconButton2.Click += iconButton2_Click;
			// 
			// iconButton1
			// 
			iconButton1.FlatAppearance.BorderSize = 0;
			iconButton1.FlatStyle = FlatStyle.Flat;
			iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
			iconButton1.IconColor = Color.Black;
			iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton1.IconSize = 50;
			iconButton1.Location = new Point(859, 527);
			iconButton1.Margin = new Padding(4, 5, 4, 5);
			iconButton1.Name = "iconButton1";
			iconButton1.Size = new Size(127, 100);
			iconButton1.TabIndex = 7;
			iconButton1.UseVisualStyleBackColor = true;
			iconButton1.Click += iconButton1_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(0, 122, 174);
			button2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
			button2.ForeColor = SystemColors.Control;
			button2.Location = new Point(54, 513);
			button2.Margin = new Padding(4, 5, 4, 5);
			button2.Name = "button2";
			button2.Size = new Size(313, 113);
			button2.TabIndex = 6;
			button2.Text = "Вернутся на главную страницу";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
			tableLayoutPanel1.Location = new Point(54, 33);
			tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.94536F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.0546455F));
			tableLayoutPanel1.Size = new Size(1067, 448);
			tableLayoutPanel1.TabIndex = 5;
			// 
			// Profile
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1159, 672);
			Controls.Add(iconButton2);
			Controls.Add(iconButton1);
			Controls.Add(button2);
			Controls.Add(tableLayoutPanel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 5, 4, 5);
			Name = "Profile";
			Text = "DreamRent";
			Load += Profile_Load;
			tabPage3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private FontAwesome.Sharp.IconButton iconButton3;
		private FontAwesome.Sharp.IconButton iconButton4;
		private Button button3;
		private Button button4;
		private TableLayoutPanel tableLayoutPanel2;
		private TabPage tabPage3;
		private FontAwesome.Sharp.IconButton iconButton2;
		private FontAwesome.Sharp.IconButton iconButton1;
		private Button button2;
		private TableLayoutPanel tableLayoutPanel1;
	}
}