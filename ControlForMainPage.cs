using DreamRend.Models;

namespace DreamRend
{
	public partial class ControlForMainPage : UserControl
	{
		public ControlForMainPage()
		{
			InitializeComponent();
		}

		public void SetApartmentInfo(string apName, int? area, byte[] mainPhoto, int? cost, int? roomCount)
		{
			apNamelabel.Text = apName;
			areaLabel.Text = area.ToString() + " м²";
			if(roomCount == 0 )
			{
				roomsLabel.Text = "Студия";
			}
			else
			{
				roomsLabel.Text = $"{roomCount}-комн. кв.";
			}
			costLabel.Text = cost.ToString();
			using (MemoryStream ms = new MemoryStream(mainPhoto))
			{
				pictureBox1.Image = Image.FromStream(ms);
			}

		}
	}
}
