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
			pictureBox1 = new PictureBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			apNamelabel = new Label();
			costLabel = new Label();
			tableLayoutPanel3 = new TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			SuspendLayout();
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
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(apNamelabel, 0, 0);
			tableLayoutPanel2.Location = new Point(6, 115);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(244, 27);
			tableLayoutPanel2.TabIndex = 4;
			// 
			// apNamelabel
			// 
			apNamelabel.AutoSize = true;
			apNamelabel.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			apNamelabel.Location = new Point(3, 0);
			apNamelabel.Name = "apNamelabel";
			apNamelabel.Size = new Size(71, 17);
			apNamelabel.TabIndex = 3;
			apNamelabel.Text = "{ap_name}";
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
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(costLabel, 0, 0);
			tableLayoutPanel3.Location = new Point(5, 134);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(245, 28);
			tableLayoutPanel3.TabIndex = 5;
			// 
			// ControlForMainPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BorderStyle = BorderStyle.FixedSingle;
			Controls.Add(tableLayoutPanel3);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(pictureBox1);
			Name = "ControlForMainPage";
			Size = new Size(264, 168);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private PictureBox pictureBox1;
		private TableLayoutPanel tableLayoutPanel2;
		private Label costLabel;
		private Label apNamelabel;
		private TableLayoutPanel tableLayoutPanel3;
	}
}
