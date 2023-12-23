using DreamRend.Models;
using System.Drawing.Text;

namespace DreamRend
{
	public partial class ApartamentPage : Form
	{
		public ApartamentPage(long apID)
		{
			InitializeComponent();

			using (var context = new DreamRendContext())
			{
				var result = (from apartment in context.Apartments
							  join user in context.Users on apartment.UserId equals user.UserId
							  where apartment.ApartmentId == apID
							  select new
							  {
								  apartment.Cost,
								  apartment.ApName,
								  apartment.Info,
								  apartment.Period,
								  apartment.RoomCount,
								  apartment.MainPhoto,
								  apartment.Area,
								  apartment.Floor,
								  user.Fname,
							  }).FirstOrDefault();

				if (result != null)
				{
					SetNameOfAppartament(result.RoomCount, result.Area, result.Floor);

					addressLabel.Text = "Адрес: " + result.ApName;

					SetCost(result.Period, result.Cost);

					userNamelabel.Text = "Пользователь: \n" + result.Fname;

					roomsCountlabel.Text = "Колличество комнат: " + SetRooomCount(result.RoomCount);

					areaLabel.Text = "Общая площадь: " + result.Area.ToString() + " м²";

					flourLabel.Text = "Этаж: " + result.Floor.ToString();

					infoRichTextBox.Text = result.Info;

					using (MemoryStream ms = new MemoryStream(result.MainPhoto))
					{
						pictureBox1.Image = Image.FromStream(ms);
					}


				}
			}

		}

		private void SetNameOfAppartament(int? roomCount, int? area, int? floor)
		{
			if (roomCount == 0)
			{
				apNamelabel.Text = $"Квартира-студия, {area} м², {floor} эт.";
			}
			else
			{
				apNamelabel.Text = $"{roomCount}-к. квартира, {area} м², {floor} эт.";
			}
		}

		private void SetCost(int? period, int? cost)
		{
			if (period == 0)
			{
				costLabel.Text = $"от {cost} ₽ в месяц";
			}
			else
			{
				costLabel.Text = $"от {cost} ₽ в день";
			}
		}

		private string SetRooomCount(int? roomCount)
		{
			if (roomCount == 0)
			{
				return "Студия";
			}
			else
			{
				return roomCount.ToString() + "кв.";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
