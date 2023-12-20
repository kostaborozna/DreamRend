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
			pictureBox1 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(205, 29);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(57, 57);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(52, 175);
			label1.Name = "label1";
			label1.Size = new Size(31, 15);
			label1.TabIndex = 1;
			label1.Text = "Имя";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(52, 220);
			label2.Name = "label2";
			label2.Size = new Size(58, 15);
			label2.TabIndex = 2;
			label2.Text = "Фамилия";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(52, 266);
			label3.Name = "label3";
			label3.Size = new Size(58, 15);
			label3.TabIndex = 3;
			label3.Text = "Отчество";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(52, 314);
			label4.Name = "label4";
			label4.Size = new Size(41, 15);
			label4.TabIndex = 4;
			label4.Text = "Почта";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(55, 360);
			label5.Name = "label5";
			label5.Size = new Size(49, 15);
			label5.TabIndex = 5;
			label5.Text = "Пароль";
			// 
			// Profile
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(504, 613);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Name = "Profile";
			Text = "Profile";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
	}
}