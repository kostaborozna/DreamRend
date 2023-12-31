﻿using DreamRend.Models;

namespace DreamRend
{
	public partial class MainPage : Form
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Profile profile = new Profile();
			profile.Show();
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			label2_Click(sender, e);
		}

		private void label3_Click(object sender, EventArgs e)
		{
			this.Hide();
			CreateAp create = new CreateAp();
			create.Show();
		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			label3_Click(sender, e);
		}

		private void label4_Click(object sender, EventArgs e)
		{
			this.Close();
			Autorization autorization = new Autorization();
			autorization.Show();
		}

		private void iconButton3_Click(object sender, EventArgs e)
		{
			label4_Click(sender, e);
		}

		private int itemsPerPage = 9;
		private int currentPage = 1;
		private void MainPage_Load(object sender, EventArgs e)
		{
			using (var context = new DreamRendContext())
			{
				var apartments = context.Apartments
					.OrderBy(a => a.ApartmentId)
					.Skip((currentPage - 1) * itemsPerPage)
					.Take(itemsPerPage)
					.ToList();

				tableLayoutPanel2.Controls.Clear();

				foreach (var apartment in apartments)
				{
					ControlApartamentPage apartmentUserControl = new ControlApartamentPage();

					apartmentUserControl.SetApartmentInfo(apartment.Area, apartment.MainPhoto,
						apartment.Cost, apartment.RoomCount, apartment.Floor, apartment.ApartmentId);

					tableLayoutPanel2.Controls.Add(apartmentUserControl);



				}

				UpdateNavigationButtons();
			}
		}


		private void UpdateNavigationButtons()
		{
			nexticonButton.Visible = HasNextPage();
			iconButton5.Visible = HasPreviousPage();
		}
		private bool HasNextPage()
		{
			using (var context = new DreamRendContext())
			{
				return context.Apartments
					.OrderBy(a => a.ApartmentId)
					.Skip(currentPage * itemsPerPage)
					.Any();
			}

		}
		private bool HasPreviousPage()
		{
			using (var context = new DreamRendContext())
			{
				return context.Apartments
					.OrderBy(a => a.ApartmentId)
					.Take((currentPage - 1) * itemsPerPage)
					.Any();
			}
		}
		private void btnNextPage_Click(object sender, EventArgs e)
		{
			currentPage++;
			MainPage_Load(sender, e);
		}

		private void iconButton5_Click(object sender, EventArgs e)
		{
			currentPage--;

			if (currentPage < 1)
			{
				currentPage = 1;
			}

			MainPage_Load(sender, e);
		}
	}
}
