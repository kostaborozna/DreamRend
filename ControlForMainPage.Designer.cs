namespace DreamRend
{
	partial class ControlForMainPage
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
			roomsLabel = new Label();
			pictureBox1 = new PictureBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			areaLabel = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			costLabel = new Label();
			apNamelabel = new Label();
			tableLayoutPanel3 = new TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			SuspendLayout();
			// 
			// roomsLabel
			// 
			roomsLabel.AutoSize = true;
			roomsLabel.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			roomsLabel.Location = new Point(3, 0);
			roomsLabel.Name = "roomsLabel";
			roomsLabel.Size = new Size(90, 17);
			roomsLabel.TabIndex = 1;
			roomsLabel.Text = "{room_count}";
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(3, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(247, 112);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 143F));
			tableLayoutPanel1.Controls.Add(roomsLabel, 0, 0);
			tableLayoutPanel1.Controls.Add(areaLabel, 1, 0);
			tableLayoutPanel1.Location = new Point(6, 142);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(244, 36);
			tableLayoutPanel1.TabIndex = 3;
			// 
			// areaLabel
			// 
			areaLabel.AutoSize = true;
			areaLabel.Dock = DockStyle.Left;
			areaLabel.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			areaLabel.Location = new Point(104, 0);
			areaLabel.Name = "areaLabel";
			areaLabel.Size = new Size(42, 36);
			areaLabel.TabIndex = 2;
			areaLabel.Text = "{area}";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(costLabel, 0, 0);
			tableLayoutPanel2.Location = new Point(6, 115);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(244, 27);
			tableLayoutPanel2.TabIndex = 4;
			// 
			// costLabel
			// 
			costLabel.AutoSize = true;
			costLabel.Font = new Font("Microsoft JhengHei UI", 12F);
			costLabel.Location = new Point(3, 0);
			costLabel.Name = "costLabel";
			costLabel.Size = new Size(50, 20);
			costLabel.TabIndex = 0;
			costLabel.Text = "{cost}";
			// 
			// apNamelabel
			// 
			apNamelabel.AutoSize = true;
			tableLayoutPanel3.SetColumnSpan(apNamelabel, 2);
			apNamelabel.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			apNamelabel.Location = new Point(3, 0);
			apNamelabel.Name = "apNamelabel";
			apNamelabel.Size = new Size(71, 17);
			apNamelabel.TabIndex = 3;
			apNamelabel.Text = "{ap_name}";
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(apNamelabel, 0, 0);
			tableLayoutPanel3.Location = new Point(6, 167);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(244, 28);
			tableLayoutPanel3.TabIndex = 5;
			// 
			// ControlForMainPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BorderStyle = BorderStyle.FixedSingle;
			Controls.Add(tableLayoutPanel3);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(pictureBox1);
			Name = "ControlForMainPage";
			Size = new Size(254, 198);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label roomsLabel;
		private PictureBox pictureBox1;
		private TableLayoutPanel tableLayoutPanel1;
		private Label areaLabel;
		private TableLayoutPanel tableLayoutPanel2;
		private Label costLabel;
		private Label apNamelabel;
		private TableLayoutPanel tableLayoutPanel3;
	}
}
