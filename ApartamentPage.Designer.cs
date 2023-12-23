namespace DreamRend
{
	partial class ApartamentPage
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
			tableLayoutPanel1 = new TableLayoutPanel();
			apNamelabel = new Label();
			pictureBox1 = new PictureBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			costLabel = new Label();
			tableLayoutPanel3 = new TableLayoutPanel();
			userNamelabel = new Label();
			button1 = new Button();
			label4 = new Label();
			tableLayoutPanel4 = new TableLayoutPanel();
			addressLabel = new Label();
			flourLabel = new Label();
			areaLabel = new Label();
			roomsCountlabel = new Label();
			label9 = new Label();
			infoRichTextBox = new RichTextBox();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(apNamelabel, 0, 0);
			tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
			tableLayoutPanel1.Location = new Point(45, 10);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.1256828F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.87431F));
			tableLayoutPanel1.Size = new Size(374, 243);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// apNamelabel
			// 
			apNamelabel.AutoSize = true;
			apNamelabel.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold);
			apNamelabel.Location = new Point(3, 0);
			apNamelabel.Name = "apNamelabel";
			apNamelabel.Size = new Size(128, 30);
			apNamelabel.TabIndex = 0;
			apNamelabel.Text = "{apName}";
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Location = new Point(3, 49);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(368, 191);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(costLabel, 0, 0);
			tableLayoutPanel2.Location = new Point(489, 10);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(322, 30);
			tableLayoutPanel2.TabIndex = 1;
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
			tableLayoutPanel3.Controls.Add(userNamelabel, 0, 0);
			tableLayoutPanel3.Controls.Add(button1, 0, 1);
			tableLayoutPanel3.Location = new Point(489, 68);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 37.4149666F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5850334F));
			tableLayoutPanel3.Size = new Size(322, 147);
			tableLayoutPanel3.TabIndex = 2;
			// 
			// userNamelabel
			// 
			userNamelabel.AutoSize = true;
			userNamelabel.Font = new Font("Microsoft JhengHei UI", 10F);
			userNamelabel.Location = new Point(3, 0);
			userNamelabel.Name = "userNamelabel";
			userNamelabel.Size = new Size(76, 18);
			userNamelabel.TabIndex = 0;
			userNamelabel.Text = "userName";
			// 
			// button1
			// 
			button1.Location = new Point(3, 58);
			button1.Name = "button1";
			button1.Size = new Size(149, 61);
			button1.TabIndex = 1;
			button1.Text = "Написать продавцу";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold);
			label4.Location = new Point(48, 276);
			label4.Name = "label4";
			label4.Size = new Size(137, 28);
			label4.TabIndex = 3;
			label4.Text = "О квартире";
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 1;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.Controls.Add(addressLabel, 0, 3);
			tableLayoutPanel4.Controls.Add(flourLabel, 0, 2);
			tableLayoutPanel4.Controls.Add(areaLabel, 0, 1);
			tableLayoutPanel4.Controls.Add(roomsCountlabel, 0, 0);
			tableLayoutPanel4.Location = new Point(48, 318);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 4;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50.9433975F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 49.0566025F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
			tableLayoutPanel4.Size = new Size(248, 130);
			tableLayoutPanel4.TabIndex = 4;
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Font = new Font("Microsoft JhengHei UI", 12F);
			addressLabel.Location = new Point(3, 77);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new Size(57, 20);
			addressLabel.TabIndex = 5;
			addressLabel.Text = "adress";
			// 
			// flourLabel
			// 
			flourLabel.AutoSize = true;
			flourLabel.Font = new Font("Microsoft JhengHei UI", 12F);
			flourLabel.Location = new Point(3, 53);
			flourLabel.Name = "flourLabel";
			flourLabel.Size = new Size(44, 20);
			flourLabel.TabIndex = 4;
			flourLabel.Text = "flour";
			// 
			// areaLabel
			// 
			areaLabel.AutoSize = true;
			areaLabel.Font = new Font("Microsoft JhengHei UI", 12F);
			areaLabel.Location = new Point(3, 27);
			areaLabel.Name = "areaLabel";
			areaLabel.Size = new Size(42, 20);
			areaLabel.TabIndex = 3;
			areaLabel.Text = "area";
			// 
			// roomsCountlabel
			// 
			roomsCountlabel.AutoSize = true;
			roomsCountlabel.Font = new Font("Microsoft JhengHei UI", 12F);
			roomsCountlabel.Location = new Point(3, 0);
			roomsCountlabel.Name = "roomsCountlabel";
			roomsCountlabel.Size = new Size(104, 20);
			roomsCountlabel.TabIndex = 2;
			roomsCountlabel.Text = "roumsCount";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold);
			label9.Location = new Point(489, 236);
			label9.Name = "label9";
			label9.Size = new Size(120, 28);
			label9.TabIndex = 5;
			label9.Text = "Описание";
			// 
			// infoRichTextBox
			// 
			infoRichTextBox.Font = new Font("Microsoft JhengHei UI", 12F);
			infoRichTextBox.Location = new Point(489, 278);
			infoRichTextBox.Name = "infoRichTextBox";
			infoRichTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
			infoRichTextBox.Size = new Size(322, 232);
			infoRichTextBox.TabIndex = 6;
			infoRichTextBox.Text = "";
			// 
			// ApartamentPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(894, 552);
			Controls.Add(infoRichTextBox);
			Controls.Add(label9);
			Controls.Add(tableLayoutPanel4);
			Controls.Add(label4);
			Controls.Add(tableLayoutPanel3);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			Name = "ApartamentPage";
			Text = "ApartamentPage";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label apNamelabel;
		private TableLayoutPanel tableLayoutPanel2;
		private Label costLabel;
		private TableLayoutPanel tableLayoutPanel3;
		private Label userNamelabel;
		private Label label4;
		private TableLayoutPanel tableLayoutPanel4;
		private Label addressLabel;
		private Label flourLabel;
		private Label areaLabel;
		private Label roomsCountlabel;
		private Label label9;
		private PictureBox pictureBox1;
		private RichTextBox infoRichTextBox;
		private Button button1;
	}
}