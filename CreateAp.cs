using DreamRend.Models;
using System.Drawing.Imaging;

namespace DreamRend
{
	public partial class CreateAp : Form
	{
		public CreateAp()
		{
			InitializeComponent();
		}

		private Apartment apartmentInfo;

		private void button1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image Files (*.png;*.jpeg;*.jpg;*.gif;*.bmp)|*.png;*.jpeg;*.jpg;*.gif;*.bmp";
				openFileDialog.Title = "Выберите файл изображения";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = openFileDialog.FileName;
					pictureBox1.Image = Image.FromFile(filePath);

				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MainPage mainPage = new MainPage();
		}
		private byte[] ConvertImageToByteArray(Image image)
		{

			using (MemoryStream ms = new MemoryStream())
			{

				image.Save(ms, ImageFormat.Jpeg);
				return ms.ToArray();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Validator validator = new Validator();
			int selectedPeriod = 0;
			int selectedRoom = 0;


			if (!validator.IsValidIndexComboBox((periodComboBox, "Выберите период"), (roomsCountComboBox, "Выберите количество комнат")))
			{
				return;
			}

			selectedPeriod = periodComboBox.SelectedIndex;
			selectedRoom = roomsCountComboBox.SelectedIndex;


			if (validator.IsValidCost(costTextBox.Text))
			{
				return;
			}
			int cost = int.Parse(costTextBox.Text);


			if (pictureBox1.Image == null)
			{
				MessageBoxHelper.ShowError("Загрузите картинку!");
				return;
			}

			long curentUser = CurrentUser.UserId;

			if (!validator.IsValidApName(addrestextBox.Text))
			{
				return;
			}
			string ap_naname = addrestextBox.Text;

			if (!validator.IsValidInfo(richTextBox1.Text))
			{
				return;
			}

			string info = richTextBox1.Text;

			if (validator.IsValidArea(areaTextBox.Text))
			{
				return;
			}
			int area = int.Parse(costTextBox.Text);





			using (var context = new DreamRendContext())
			{
				Apartment apartmentInfo = new Apartment
				{
					UserId = curentUser,
					Cost = cost,
					Period = selectedPeriod,
					RoomCount = selectedRoom,
					ApName = ap_naname,
					Area = area,
					Info = info,
					MainPhoto = ConvertImageToByteArray(pictureBox1.Image)

				};
				context.Apartments.Add(apartmentInfo);
				context.SaveChanges();
				this.Close();
				MainPage mainPage = new MainPage();
				mainPage.Show();
				MessageBoxHelper.ShowSuccess("Успех");
			}
		}

		

	}
}
