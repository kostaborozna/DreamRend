namespace DreamRend
{
	partial class MainPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
			panel1 = new Panel();
			tableLayoutPanel1 = new TableLayoutPanel();
			label3 = new Label();
			iconButton2 = new FontAwesome.Sharp.IconButton();
			label2 = new Label();
			label4 = new Label();
			iconButton3 = new FontAwesome.Sharp.IconButton();
			iconButton1 = new FontAwesome.Sharp.IconButton();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			btnNextPage = new Button();
			panel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(0, 122, 174);
			panel1.Controls.Add(tableLayoutPanel1);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(-17, -41);
			panel1.Name = "panel1";
			panel1.Size = new Size(230, 645);
			panel1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.967741F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.03226F));
			tableLayoutPanel1.Controls.Add(label3, 1, 1);
			tableLayoutPanel1.Controls.Add(iconButton2, 0, 1);
			tableLayoutPanel1.Controls.Add(label2, 1, 0);
			tableLayoutPanel1.Controls.Add(label4, 1, 2);
			tableLayoutPanel1.Controls.Add(iconButton3, 0, 2);
			tableLayoutPanel1.Controls.Add(iconButton1, 0, 0);
			tableLayoutPanel1.Location = new Point(29, 199);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.6853943F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.3146057F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
			tableLayoutPanel1.Size = new Size(186, 147);
			tableLayoutPanel1.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Fill;
			label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
			label3.ForeColor = Color.White;
			label3.Location = new Point(41, 50);
			label3.Name = "label3";
			label3.Size = new Size(142, 47);
			label3.TabIndex = 5;
			label3.Text = "Создать объявление";
			label3.TextAlign = ContentAlignment.MiddleLeft;
			label3.Click += label3_Click;
			// 
			// iconButton2
			// 
			iconButton2.FlatAppearance.BorderSize = 0;
			iconButton2.FlatStyle = FlatStyle.Flat;
			iconButton2.IconChar = FontAwesome.Sharp.IconChar.Pen;
			iconButton2.IconColor = Color.Black;
			iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton2.IconSize = 28;
			iconButton2.Location = new Point(3, 53);
			iconButton2.Name = "iconButton2";
			iconButton2.Size = new Size(28, 40);
			iconButton2.TabIndex = 4;
			iconButton2.UseVisualStyleBackColor = true;
			iconButton2.Click += iconButton2_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Fill;
			label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
			label2.ForeColor = Color.White;
			label2.Location = new Point(41, 0);
			label2.Name = "label2";
			label2.Size = new Size(142, 50);
			label2.TabIndex = 3;
			label2.Text = "Профиль";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			label2.Click += label2_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Dock = DockStyle.Fill;
			label4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
			label4.ForeColor = Color.White;
			label4.Location = new Point(41, 97);
			label4.Name = "label4";
			label4.Size = new Size(142, 50);
			label4.TabIndex = 7;
			label4.Text = "Выйти";
			label4.TextAlign = ContentAlignment.MiddleLeft;
			label4.Click += label4_Click;
			// 
			// iconButton3
			// 
			iconButton3.FlatAppearance.BorderSize = 0;
			iconButton3.FlatStyle = FlatStyle.Flat;
			iconButton3.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
			iconButton3.IconColor = Color.Black;
			iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton3.IconSize = 28;
			iconButton3.Location = new Point(3, 100);
			iconButton3.Name = "iconButton3";
			iconButton3.Size = new Size(28, 40);
			iconButton3.TabIndex = 6;
			iconButton3.UseVisualStyleBackColor = true;
			iconButton3.Click += iconButton3_Click;
			// 
			// iconButton1
			// 
			iconButton1.FlatAppearance.BorderSize = 0;
			iconButton1.FlatStyle = FlatStyle.Flat;
			iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
			iconButton1.IconColor = Color.Black;
			iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton1.IconSize = 28;
			iconButton1.Location = new Point(3, 3);
			iconButton1.Name = "iconButton1";
			iconButton1.Size = new Size(32, 42);
			iconButton1.TabIndex = 2;
			iconButton1.UseVisualStyleBackColor = true;
			iconButton1.Click += iconButton1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Transparent;
			label1.Location = new Point(44, 134);
			label1.Name = "label1";
			label1.Size = new Size(145, 30);
			label1.TabIndex = 1;
			label1.Text = "DreamRent";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(55, 53);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(124, 78);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
			tableLayoutPanel2.Location = new Point(233, 12);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 3;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.7886162F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 38.2113838F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
			tableLayoutPanel2.Size = new Size(647, 495);
			tableLayoutPanel2.TabIndex = 1;
			// 
			// btnNextPage
			// 
			btnNextPage.Location = new Point(680, 527);
			btnNextPage.Name = "btnNextPage";
			btnNextPage.Size = new Size(170, 47);
			btnNextPage.TabIndex = 2;
			btnNextPage.Text = "button1";
			btnNextPage.UseVisualStyleBackColor = true;
			btnNextPage.Click += btnNextPage_Click;
			// 
			// MainPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(909, 599);
			Controls.Add(btnNextPage);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(panel1);
			Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Name = "MainPage";
			Text = "MainPage";
			Load += MainPage_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private FontAwesome.Sharp.IconButton iconButton1;
		private TableLayoutPanel tableLayoutPanel1;
		private FontAwesome.Sharp.IconButton iconButton3;
		private Label label3;
		private FontAwesome.Sharp.IconButton iconButton2;
		private Label label4;
		private TableLayoutPanel tableLayoutPanel2;
		private Button btnNextPage;
	}
}