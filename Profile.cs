using DreamRend.Models;
using System.Windows.Forms;

namespace DreamRend
{
	public partial class Profile : Form
	{
		public Profile()
		{
			InitializeComponent();
		}
		private int itemsPerPage = 3;
		private int currentPage = 1;
		private void Profile_Load(object sender, EventArgs e)
		{
			using (var context = new DreamRendContext())
			{
				var apartments = context.Apartments
					.OrderBy(a => a.ApartmentId)
					.Where(a => a.UserId == CurrentUser.UserId)
					.Skip((currentPage - 1) * itemsPerPage)
					.Take(itemsPerPage)
					.ToList();

				tableLayoutPanel1.Controls.Clear();

				foreach (var apartment in apartments)
				{
					ControlApartamentPage apartmentUserControl = new ControlApartamentPage();
					apartmentUserControl.DisableClick();

					apartmentUserControl.SetApartmentInfo(apartment.Area, apartment.MainPhoto,
						apartment.Cost, apartment.RoomCount, apartment.Floor, apartment.ApartmentId);

					tableLayoutPanel1.Controls.Add(apartmentUserControl);

				}

				UpdateNavigationButtons();
			}


		}
		private void UpdateNavigationButtons()
		{
			iconButton2.Visible = HasNextPage();
		}

		private bool HasNextPage()
		{
			using (var context = new DreamRendContext())
			{
				return context.Apartments
					.OrderBy(a => a.ApartmentId)
					.Where(a => a.UserId == CurrentUser.UserId)
					.Skip(currentPage * itemsPerPage)
					.Any();
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			MainPage mainPage = new MainPage();
			this.Close();
			mainPage.Show();
		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			currentPage++;
			Profile_Load(sender, e);
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			currentPage--;

			if (currentPage < 1)
			{
				currentPage = 1;
			}

			Profile_Load(sender, e);
		}

	}
}
