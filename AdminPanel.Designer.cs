namespace DreamRend
{
	partial class AdminPanel
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
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tableLayoutPanel1 = new TableLayoutPanel();
			label1 = new Label();
			usersCountlabel = new Label();
			label2 = new Label();
			label3 = new Label();
			tabPage2 = new TabPage();
			dataGridView2 = new DataGridView();
			dataGridView1 = new DataGridView();
			button1 = new Button();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new Point(-3, 2);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(967, 515);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(tableLayoutPanel1);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(930, 445);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Статистика";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(usersCountlabel, 1, 0);
			tableLayoutPanel1.Controls.Add(label2, 0, 1);
			tableLayoutPanel1.Controls.Add(label3, 1, 1);
			tableLayoutPanel1.Location = new Point(104, 50);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(544, 179);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(164, 15);
			label1.TabIndex = 0;
			label1.Text = "Колличество пользователей";
			// 
			// usersCountlabel
			// 
			usersCountlabel.AutoSize = true;
			usersCountlabel.Location = new Point(275, 0);
			usersCountlabel.Name = "usersCountlabel";
			usersCountlabel.Size = new Size(38, 15);
			usersCountlabel.TabIndex = 1;
			usersCountlabel.Text = "label2";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 89);
			label2.Name = "label2";
			label2.Size = new Size(149, 15);
			label2.TabIndex = 2;
			label2.Text = "Колличество объявлений";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(275, 89);
			label3.Name = "label3";
			label3.Size = new Size(38, 15);
			label3.TabIndex = 3;
			label3.Text = "label3";
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(button1);
			tabPage2.Controls.Add(dataGridView2);
			tabPage2.Controls.Add(dataGridView1);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(959, 487);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "БД";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(11, 217);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.Size = new Size(939, 150);
			dataGridView2.TabIndex = 1;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(11, 18);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(939, 179);
			dataGridView1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(115, 402);
			button1.Name = "button1";
			button1.Size = new Size(319, 53);
			button1.TabIndex = 2;
			button1.Text = "Сохранить изменения";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// AdminPanel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(963, 557);
			Controls.Add(tabControl1);
			MinimizeBox = false;
			Name = "AdminPanel";
			ShowIcon = false;
			ShowInTaskbar = false;
			Text = "AdminPanel";
			Load += AdminPanel_Load;
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private Label usersCountlabel;
		private Label label2;
		private Label label3;
		private DataGridView dataGridView2;
		private DataGridView dataGridView1;
		private Button button1;
	}
}