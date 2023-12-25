using DreamRend.Models;

namespace DreamRend
{
	public partial class ControlApartamentPage : UserControl
	{
		public ControlApartamentPage()
		{
			InitializeComponent();
			AttachEventToAllControls(this, OpenApartamentClickHandler);
		}
		public void DisableClick()
		{
			DetachEventFromAllControls(this, OpenApartamentClickHandler);
		}
		private long apartamentId;
		public void SetApartmentInfo(int area, byte[] mainPhoto, int cost, int roomCount, int floor, long apId)
		{
			apartamentId = apId;
			SetNameOfAppartament(roomCount, area, floor);


			costLabel.Text = cost.ToString() + "₽";
			using (MemoryStream ms = new MemoryStream(mainPhoto))
			{
				pictureBox1.Image = Image.FromStream(ms);
			}

		}

		private void AttachEventToAllControls(Control control, EventHandler eventHandler)
		{
			foreach (Control ctrl in control.Controls)
			{
				AttachEventToAllControls(ctrl, eventHandler);
				ctrl.Click += eventHandler;
			}
		}

		private void DetachEventFromAllControls(Control control, EventHandler eventHandler)
		{
			foreach (Control ctrl in control.Controls)
			{
				DetachEventFromAllControls(ctrl, eventHandler);
				ctrl.Click -= eventHandler;
			}
		}

		private void OpenApartamentClickHandler(object sender, EventArgs e)
		{
			long apId = apartamentId;
			ApartamentPage apartamentPage = new ApartamentPage(apId);
			apartamentPage.Show();
		}

		private void SetNameOfAppartament(int roomCount, int area, int floor)
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
	}
}
