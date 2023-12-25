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
			tableLayoutPanel1.Location = new Point(64, 17);
			tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.1256828F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.87431F));
			tableLayoutPanel1.Size = new Size(534, 405);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// apNamelabel
			// 
			apNamelabel.AutoSize = true;
			apNamelabel.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold);
			apNamelabel.Location = new Point(4, 0);
			apNamelabel.Margin = new Padding(4, 0, 4, 0);
			apNamelabel.Name = "apNamelabel";
			apNamelabel.Size = new Size(194, 46);
			apNamelabel.TabIndex = 0;
			apNamelabel.Text = "{apName}";
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Location = new Point(4, 82);
			pictureBox1.Margin = new Padding(4, 5, 4, 5);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(526, 318);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(costLabel, 0, 0);
			tableLayoutPanel2.Location = new Point(699, 17);
			tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(460, 50);
			tableLayoutPanel2.TabIndex = 1;
			// 
			// costLabel
			// 
			costLabel.AutoSize = true;
			costLabel.Font = new Font("Microsoft JhengHei UI", 12F);
			costLabel.Location = new Point(4, 0);
			costLabel.Margin = new Padding(4, 0, 4, 0);
			costLabel.Name = "costLabel";
			costLabel.Size = new Size(76, 30);
			costLabel.TabIndex = 0;
			costLabel.Text = "{cost}";
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(userNamelabel, 0, 0);
			tableLayoutPanel3.Controls.Add(button1, 0, 1);
			tableLayoutPanel3.Location = new Point(699, 113);
			tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 37.4149666F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5850334F));
			tableLayoutPanel3.Size = new Size(460, 245);
			tableLayoutPanel3.TabIndex = 2;
			// 
			// userNamelabel
			// 
			userNamelabel.AutoSize = true;
			userNamelabel.Font = new Font("Microsoft JhengHei UI", 10F);
			userNamelabel.Location = new Point(4, 0);
			userNamelabel.Margin = new Padding(4, 0, 4, 0);
			userNamelabel.Name = "userNamelabel";
			userNamelabel.Size = new Size(108, 25);
			userNamelabel.TabIndex = 0;
			userNamelabel.Text = "userName";
			// 
			// button1
			// 
			button1.Location = new Point(4, 96);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(213, 102);
			button1.TabIndex = 1;
			button1.Text = "Написать продавцу";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold);
			label4.Location = new Point(69, 460);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(192, 41);
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
			tableLayoutPanel4.Location = new Point(69, 530);
			tableLayoutPanel4.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 4;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 182F));
			tableLayoutPanel4.Size = new Size(354, 320);
			tableLayoutPanel4.TabIndex = 4;
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Font = new Font("Microsoft JhengHei UI", 12F);
			addressLabel.Location = new Point(4, 137);
			addressLabel.Margin = new Padding(4, 0, 4, 0);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new Size(86, 30);
			addressLabel.TabIndex = 5;
			addressLabel.Text = "adress";
			// 
			// flourLabel
			// 
			flourLabel.AutoSize = true;
			flourLabel.Font = new Font("Microsoft JhengHei UI", 12F);
			flourLabel.Location = new Point(4, 84);
			flourLabel.Margin = new Padding(4, 0, 4, 0);
			flourLabel.Name = "flourLabel";
			flourLabel.Size = new Size(66, 30);
			flourLabel.TabIndex = 4;
			flourLabel.Text = "flour";
			// 
			// areaLabel
			// 
			areaLabel.AutoSize = true;
			areaLabel.Font = new Font("Microsoft JhengHei UI", 12F);
			areaLabel.Location = new Point(4, 49);
			areaLabel.Margin = new Padding(4, 0, 4, 0);
			areaLabel.Name = "areaLabel";
			areaLabel.Size = new Size(62, 30);
			areaLabel.TabIndex = 3;
			areaLabel.Text = "area";
			// 
			// roomsCountlabel
			// 
			roomsCountlabel.AutoSize = true;
			roomsCountlabel.Font = new Font("Microsoft JhengHei UI", 12F);
			roomsCountlabel.Location = new Point(4, 0);
			roomsCountlabel.Margin = new Padding(4, 0, 4, 0);
			roomsCountlabel.Name = "roomsCountlabel";
			roomsCountlabel.Size = new Size(155, 30);
			roomsCountlabel.TabIndex = 2;
			roomsCountlabel.Text = "roumsCount";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold);
			label9.Location = new Point(699, 393);
			label9.Margin = new Padding(4, 0, 4, 0);
			label9.Name = "label9";
			label9.Size = new Size(164, 41);
			label9.TabIndex = 5;
			label9.Text = "Описание";
			// 
			// infoRichTextBox
			// 
			infoRichTextBox.Font = new Font("Microsoft JhengHei UI", 12F);
			infoRichTextBox.Location = new Point(699, 463);
			infoRichTextBox.Margin = new Padding(4, 5, 4, 5);
			infoRichTextBox.Name = "infoRichTextBox";
			infoRichTextBox.ReadOnly = true;
			infoRichTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
			infoRichTextBox.Size = new Size(458, 384);
			infoRichTextBox.TabIndex = 6;
			infoRichTextBox.Text = "";
			// 
			// ApartamentPage
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1277, 920);
			Controls.Add(infoRichTextBox);
			Controls.Add(label9);
			Controls.Add(tableLayoutPanel4);
			Controls.Add(label4);
			Controls.Add(tableLayoutPanel3);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			Margin = new Padding(4, 5, 4, 5);
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